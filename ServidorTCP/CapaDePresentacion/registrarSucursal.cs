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
    public partial class registrarSucursal : Form
    {
        //Arreglo para guardar los errores.
        private List<string> errores = new List<string>();

        //Instancia de ClientesDatos.
        private SucursalDatos sucursalDatos;

        //Constructor.
        public registrarSucursal()
        {
            InitializeComponent();

            //Instancia la Sucursal Datos para obtener las sucursales de la base de datos.
            sucursalDatos = new SucursalDatos();

            //Carga los datos en el DataGridView.
            ActualizarDataGridView();
        }

        //Carga los encargados al ComboBox y el DataGridView.
        private void registrarSucursal_Load(object sender, EventArgs e)
        {
            try
            {
                //Instancia la Categoria Datos para obtener los ecargados de la base de datos.
                EncargadoDatos encargadoDatos = new EncargadoDatos();

                //Obtiene las Categorías y las guarda en Lista Encargados.
                var listaEncargados = encargadoDatos.ObtenerEncargados();

                //Si no hay ningún encargado, muestra un mensaje de error y deshabilita los controles.
                if (listaEncargados.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un encargado antes de registrar una sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id.Enabled = false;
                    nombre.Enabled = false;
                    direccion.Enabled = false;
                    telefono.Enabled = false;
                    encargado.Enabled = false;
                    activa.Enabled = false;
                    btnRegistrar.Enabled = false;
                    return;
                }

                // signa la lista de encargados al origen de datos del ComboBox.
                encargado.DataSource = listaEncargados;

                //Especifica la propiedad de la clase EncargadoCls que se utilizará para mostrar el nombre del encargado en el ComboBox.
                encargado.DisplayMember = "Nombre";

                //Especifica la propiedad de la clase EncargadoCls que se utilizará como valor seleccionado en el ComboBox.
                encargado.ValueMember = "Id";

                //Inicia el ComboBox en null.
                encargado.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al cargar los encargados: " + ex.Message, false);
            }

        }

        //Método para actualizar la tabla.
        private void ActualizarDataGridView()
        {
            try
            {
                //Limpia el DataGridView.
                dataSucursales.Rows.Clear();

                //Obtiene las Sucursales y las guarda en Lista Sucursales.
                var listaSucursales = sucursalDatos.ObtenerSucursales();

                //Recorre las sucursales y las añade al DataGridView.
                foreach (var sucursal in listaSucursales)
                {
                    if (sucursal != null)
                    {
                        //Se agrega cada dato a las columnas.
                        dataSucursales.Rows.Add(
                            sucursal.Id,
                            sucursal.Nombre,
                            sucursal.Encargado.Id,
                            sucursal.Encargado.Identificacion,
                            sucursal.Encargado.Nombre,
                            sucursal.Encargado.Apellido1,
                            sucursal.Encargado.Apellido2,
                            sucursal.Encargado.FechaNacimiento.ToString("dd/MM/yyyy"),
                            sucursal.Encargado.FechaIngreso.ToString("dd/MM/yyyy"),
                            sucursal.Telefono,
                            sucursal.Direccion,
                            sucursal.Activo ? "Sí" : "No"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al actualizar el DataGridView: " + ex.Message, false);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - Diseños - - - - - - - - - - - - - - - - - - - - - - - - - //
        //Diseño del Hover del botón Registrar.
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
        //Acción del botón Registrar al hacer click.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Captura los datos de los TextBox y ComboBox.
                string idText = id.Text;
                string nombreString = nombre.Text;
                string direccionString = direccion.Text;
                string telefonoString = telefono.Text;
                EncargadoCls encargadoSeleccionado = (EncargadoCls)encargado.SelectedItem;
                bool activoBool = activa.SelectedItem?.ToString() == "Si"; // Utiliza el operador de navegación segura ?. para evitar excepciones si SelectedItem es null.

                //Valida los campos.
                SucursalLogica.ValidarCampos(errores, idText, nombreString, direccionString, telefonoString, encargadoSeleccionado, activoBool, id, nombre, direccion, telefono, encargado, activa);

                //Si hay errores, se detiene el proceso.
                if (errores.Any())
                {
                    return;
                }

                //Intenta convertir el ID a un entero.
                int idInt = int.Parse(idText);

                //Guarda los datos en la lógica de sucursales.
                string resultado = SucursalLogica.AgregarSucursal(idInt, nombreString, encargadoSeleccionado, telefonoString, direccionString, activoBool);

                //Verifica si el resultado indica éxito o error y muestra el mensaje adecuado.
                bool esExito = resultado == "Sucursal registrada exitosamente.";

                //Muestra si se guardó con éxito o si ya existía la ID.
                MostrarMensaje(resultado, esExito);

                //Limpia los campos si se agregó correctamente.
                if (esExito)
                {
                    ActualizarDataGridView();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error: " + ex.Message, false);
            }
        }

        //Método para limpiar los campos de entrada después de registrar una sucursal.
        private void LimpiarCampos()
        {
            id.Clear();
            nombre.Clear();
            direccion.Clear();
            telefono.Clear();
            encargado.SelectedItem = null;
            activa.SelectedItem = null;
        }

        //Método para mostrar un mensaje en un MessageBox.
        private void MostrarMensaje(string mensaje, bool esExito)
        {
            MessageBox.Show(mensaje, esExito ? "Éxito" : "Error", MessageBoxButtons.OK, esExito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}