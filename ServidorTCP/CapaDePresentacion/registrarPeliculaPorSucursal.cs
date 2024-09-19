using Entidades;
using CapaDeLogica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaDeAccesoDatos;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Registrar Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos
 *  Fecha: 31 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDePresentacion
{
    public partial class registrarPeliculaPorSucursal : Form
    {
        //Lista para almacenar errores.
        private List<string> errores = new List<string>();

        //Lista global para almacenar películas.
        private List<PeliculaCls> peliculas = new List<PeliculaCls>();

        //Instancia de PeliculaxSucursalDatos.
        private PeliculaxSucursalDatos peliculaxSucursalDatos;

        //Constructor.
        public registrarPeliculaPorSucursal()
        {
            InitializeComponent();

            //Instacia de Pelicula por Sucursal Datos.
            peliculaxSucursalDatos = new PeliculaxSucursalDatos();

            //Selecciona el null para que se muestre vacío.
            sucursal.SelectedItem = null;

            //Actualiza el DataGridView de las asociaciones.
            ActualizarDataGridView();

            //Actualiza el ComboBox con las Sucursales.
            ActualizarComboBoxSucursales();

            //Actualiza el DataGridView de Películas.
            ActualizarDataGridViewPeliculas();
        }

        //Método para Actualizar Data Grid View.
        private void ActualizarDataGridView()
        {
            try
            {
                //Obtiene las asociaciones y las guarda en la lista de asociaciones.
                List<PeliculaXSucursalCls> listaAsociaciones = peliculaxSucursalDatos.ObtenerPeliculaXSucursal();

                //Limpia el DataGridView.
                dataPeliculasPorSucursal.Rows.Clear();

                //Recorre las asociaciones y las agrega.
                foreach (PeliculaXSucursalCls asociacion in listaAsociaciones)
                {
                    //Guarda los datos de la sucursal.
                    int idSucursal = asociacion.Sucursal.Id;
                    string nombreSucursal = asociacion.Sucursal.Nombre;
                    string telefonoSucursal = asociacion.Sucursal.Telefono;
                    string direccionSucursal = asociacion.Sucursal.Direccion;
                    bool activoSucursal = asociacion.Sucursal.Activo;
                    string encargadoSucursal = asociacion.Sucursal.Encargado != null ? asociacion.Sucursal.Encargado.Nombre : "Sin encargado";

                    //Guarda los datos de Película.
                    int idPelicula = asociacion.Pelicula.Id;
                    string tituloPelicula = asociacion.Pelicula.Titulo;
                    int anioPelicula = asociacion.Pelicula.Anio;
                    string idiomaPelicula = asociacion.Pelicula.Idioma;
                    string categoriaPelicula = asociacion.Pelicula.Categoria != null ? asociacion.Pelicula.Categoria.Categoria : "Sin categoría";

                    //Guarda la cantidad.
                    int cantidad = asociacion.Cantidad;

                    //Agrega los datos al DataGridView.
                    dataPeliculasPorSucursal.Rows.Add(
                        idSucursal,
                        nombreSucursal,
                        telefonoSucursal,
                        encargadoSucursal,
                        direccionSucursal,
                        activoSucursal ? "Activa" : "No activa",
                        idPelicula,
                        tituloPelicula,
                        anioPelicula,
                        idiomaPelicula,
                        categoriaPelicula,
                        cantidad
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las películas por sucursal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para actualizar el ComboBox.
        private void ActualizarComboBoxSucursales()
        {
            try
            {
                //Limpia los items del ComboBox.
                sucursal.Items.Clear();

                //Instancia Sucursal Datos.
                SucursalDatos sucursalDatos = new SucursalDatos();

                //Obtiene las sucursales y las guarda en sucursales.
                var sucursales = sucursalDatos.ObtenerSucursales();

                //Filtra las sucursales activas.
                var sucursalesActivas = sucursales.Where(s => s.Activo).ToList();

                //Si no hay sucursales activas, muestra un mensaje de error y desactiva el ComboBox y otros controles.
                if (!sucursalesActivas.Any())
                {
                    MessageBox.Show("Debe ingresar al menos una sucursal activa antes de registrar una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sucursal.Enabled = false;
                    cantidad.Enabled = false;
                    dataPeliculas.Enabled = false;
                    btnRegistrar.Enabled = false;
                    return;
                }

                //Recorre las sucursales activas y las guarda en el ComboBox.
                foreach (var suc in sucursalesActivas)
                {
                    sucursal.Items.Add(suc);
                }

                //Muestra el nombre de la sucursal en el ComboBox.
                sucursal.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para actualizar el DataGridView de películas.
        private void ActualizarDataGridViewPeliculas()
        {
            try
            {
                //Instancia de Peliculas Datos.
                PeliculaDatos peliculaDatos = new PeliculaDatos();

                //Obtiene las películas y las guarda.
                peliculas = peliculaDatos.ObtenerPeliculas();

                //Limpia las filas.
                dataPeliculas.Rows.Clear();

                //Si no hay películas, muestra un mensaje de error y desactiva el DataGridView y otros controles.
                if (!peliculas.Any())
                {
                    MessageBox.Show("Debe ingresar al menos una película antes de registrar una asociación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataPeliculas.Enabled = false;
                    cantidad.Enabled = false;
                    sucursal.Enabled = false;
                    btnRegistrar.Enabled = false;
                    return;
                }

                //Recorre las películas y las agrega al DataGridView.
                foreach (var pelicula in peliculas)
                {
                    dataPeliculas.Rows.Add(
                        false,
                        pelicula.Id,
                        pelicula.Titulo,
                        pelicula.Anio,
                        pelicula.Categoria.Categoria,
                        pelicula.Idioma
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar DataGridView de películas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - Diseños - - - - - - - - - - - - - - - - - - - - - - - - - //
        //Diseño Hover del Botón Registrar.
        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.FromArgb(255, 255, 1);
            btnRegistrar.ForeColor = Color.Black;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.FromArgb(63, 64, 63);
            btnRegistrar.ForeColor = Color.White;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - Botón Registrar - - - - - - - - - - - - - - - - - - - - - - - - - //
        //Acción del Botón Registrar.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Captura la cantidad.
            string cantidadString = cantidad.Text;

            //Captura la sucursal seleccionada.
            SucursalCls sucursalSeleccionada = (SucursalCls)sucursal.SelectedItem;

            try
            {
                //Valida los campos.
                PeliculaPorSucursalLogica.ValidarCampos(errores, cantidadString, sucursalSeleccionada, cantidad, sucursal);

                //Si hay errores retorna.
                if (errores.Any())
                {
                    return;
                }

                //Variable para guardar la cantidad de películas seleccionadas.
                int cantidadSeleccionada;

                //Si no ha seleccionado muestra mensaje de error y retorna.
                if (!int.TryParse(cantidadString, out cantidadSeleccionada))
                {
                    MessageBox.Show("La cantidad debe ser un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Lista para películas seleccionadas.
                List<PeliculaCls> peliculasSeleccionadas = new List<PeliculaCls>();

                //Recorre el DataGridView.
                foreach (DataGridViewRow row in dataPeliculas.Rows)
                {
                    //Variable para guardar si se seleccionó.
                    bool isSelected = Convert.ToBoolean(row.Cells[0].Value);

                    //Verifica si la película está seleccionada.
                    if (isSelected)
                    {
                        //Variable para guardar el ID de la película.
                        int peliculaId;

                        //Intenta obtener el ID de la película seleccionada.
                        if (int.TryParse(row.Cells[1].Value.ToString(), out peliculaId))
                        {
                            //Busca la película en la lista global de películas obtenidas desde la base de datos.
                            PeliculaCls pelicula = peliculas.FirstOrDefault(p => p.Id == peliculaId);

                            //Si hay películas seleccionadas las añade.
                            if (pelicula != null)
                            {
                                peliculasSeleccionadas.Add(pelicula);
                            }
                            else
                            {
                                MessageBox.Show($"No se encontró ninguna película con el ID {peliculaId}.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"El ID de película '{row.Cells[1].Value}' no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                //Si no hay películas seleccionadas muestra el error.
                if (peliculasSeleccionadas.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una película.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Registra las películas.
                string resultado = PeliculaPorSucursalLogica.RegistrarPeliculaPorSucursal(sucursalSeleccionada, peliculasSeleccionadas, cantidadSeleccionada);

                //Muestra mensaje de éxito o error.
                MessageBox.Show(resultado, resultado.Contains("correctamente") ? "Éxito" : "Error", MessageBoxButtons.OK, resultado.Contains("correctamente") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                //Limpia los campos.
                LimpiarCampos();

                //Actualiza el DataGridView.
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para Limpiar los Campos.
        private void LimpiarCampos()
        {
            cantidad.Clear();
            sucursal.SelectedItem = null;
            dataPeliculas.ClearSelection();
        }
    }
}
