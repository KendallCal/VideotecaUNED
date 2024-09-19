using CapaDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Prestamo Película.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de Julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace ClienteTCP
{
    public partial class PrestamoPeliculas : Form
    {
        //Variables.
        private int idCliente;
        private List<PeliculaCls> peliculasDisponibles;

        //Constructor.
        public PrestamoPeliculas(int idCliente)
        {
            InitializeComponent();

            //Inicializa el ID del Cliente.
            this.idCliente = idCliente;

            //Carga las sucursales.
            CargarSucursales();

            //Agregar evento de clic en la celda.
            dataPeliculas.CellContentClick += DataPeliculas_CellContentClick;

            //Para que no se muestre una fila adicional.
            dataPeliculas.AllowUserToAddRows = false;
        }

        //Método para cargar las Sucursales en el ComboBox.
        private void CargarSucursales()
        {
            try
            {
                //Obtiene la lista de sucursales
                List<SucursalCls> listaSucursales = ClienteTCPDatos.ObtenerSucursales();

                //Filtra las sucursales para obtener solo las activas.
                var sucursalesActivas = listaSucursales.Where(s => s.Activo).ToList();

                //Configura el ComboBox para mostrar las sucursales activas.
                sucursal.DataSource = sucursalesActivas;
                sucursal.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - - - - - - - - - - - - - - - - - - - Diseño  - - - - - - - - - - - - - - - - - - - //
        //Diseño del botón Realizar Préstamo.
        private void btnRealizarPrestamo_MouseEnter(object sender, EventArgs e)
        {
            btnRealizarPrestamo.BackColor = Color.FromArgb(255, 255, 1);
            btnRealizarPrestamo.ForeColor = Color.Black;
        }

        private void btnRealizarPrestamo_MouseLeave(object sender, EventArgs e)
        {
            btnRealizarPrestamo.BackColor = Color.FromArgb(63, 64, 63);
            btnRealizarPrestamo.ForeColor = Color.White;
        }

        // - - - - - - - - - - - - - - - - - - - Acción - - - - - - - - - - - - - - - - - - - //
        //Acción al seleccionar una opción del ComboBox de Sucursales.
        private void sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpia todas las filas existentes.
                dataPeliculas.Rows.Clear();

                //Obtiene la sucursal seleccionada del ComboBox sucursal.
                SucursalCls sucursalSeleccionada = (SucursalCls)sucursal.SelectedItem;

                //Convierte el ID de la sucursal seleccionada a string.
                string idSucursalStr = sucursalSeleccionada.Id.ToString();

                //Obtiene las películas disponibles para la sucursal seleccionada.
                peliculasDisponibles = ClienteTCPDatos.ObtenerPeliculasPorSucursal(idSucursalStr);

                //Recorre cada película disponible y agrega una nueva fila al DataGridView dataPeliculas.
                foreach (var pelicula in peliculasDisponibles)
                {
                    dataPeliculas.Rows.Add(
                        false,
                        pelicula.Id,
                        pelicula.Titulo,
                        pelicula.Categoria.Categoria,
                        pelicula.Anio,
                        pelicula.Idioma
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las películas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Acción al hacer clic en el CheckBox del DataGridView.
        private void DataPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica si se hizo clic en la columna del checkbox.
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                //Itera sobre todas las filas del DataGridView para desmarcar todos los checkboxes.
                foreach (DataGridViewRow row in dataPeliculas.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (checkBox != null)
                    {
                        checkBox.Value = false;
                    }
                }

                //Marca el checkbox de la fila que se hizo click.
                DataGridViewCheckBoxCell selectedCheckBox = dataPeliculas.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                if (selectedCheckBox != null)
                {
                    selectedCheckBox.Value = true;
                }
            }
        }

        //Acción al hacer clic en el botón Realizar Préstamo.
        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtiene el CheckBox Seleccionado.
                DataGridViewRow selectedRow = dataPeliculas.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => row.Cells[0].Value != null && (bool)row.Cells[0].Value);

                //Si se agrego alguna pelicula.
                if (selectedRow != null)
                {
                    //Guarda la película seleccionada.
                    PeliculaCls peliculaSeleccionada = peliculasDisponibles[selectedRow.Index];

                    //Crea el nuevo préstamo.
                    PrestamoCls nuevoPrestamo = new PrestamoCls(
                        new ClienteCls(this.idCliente, "Identificación", "Nombre", "Primer Apellido", "Segundo Apellido", DateTime.Now, DateTime.Now, true),
                        (SucursalCls)sucursal.SelectedItem,
                        peliculaSeleccionada,
                        DateTime.Now,
                        true
                    );

                    //Llama al método agregar Préstamo.
                    var resultado = ClienteTCPDatos.AgregarPrestamo(nuevoPrestamo);

                    //Convierte el resultado de entidad a bool.
                    bool entidad = resultado.Entidad.ToObject<bool>(); 

                    //Convierte el resultado del mensaje a string.
                    string mensaje = resultado.Mensaje.ToString();

                    //Si se logro agregar muesta mensaje de exito, sino el de error.
                    if (entidad)
                    {
                        MessageBox.Show("Préstamo realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una película para realizar el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
