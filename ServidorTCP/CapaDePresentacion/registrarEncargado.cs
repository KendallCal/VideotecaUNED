using CapaDeAccesoDatos;
using CapaDeLogica;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Registrar Encargado.
 *  Estudiante: Kendall Andrey Calderón Burgos
 *  Fecha: 30 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDePresentacion
{
    public partial class registrarEncargado : Form
    {
        //Arreglo para guardar los errores.
        private List<string> errores = new List<string>();

        //Calcula la fecha hace 100 años desde la fecha actual.
        DateTime fechaHace100Anios = DateTime.Now.AddYears(-100);

        //Calcula la fecha hace 18 años desde la fecha actual.
        DateTime hace18Anios = DateTime.Now.AddYears(-18);

        //Instancia de ClientesDatos.
        private EncargadoDatos encargadosDatos;

        //Constructor.
        public registrarEncargado()
        {
            InitializeComponent();

            //Inicializa la instancia de ClientesDatos.
            encargadosDatos = new EncargadoDatos();

            //Establece la fecha mínima.
            nacimiento.MinDate = fechaHace100Anios;
            ingreso.MinDate = fechaHace100Anios;

            //Establece la fecha máxima.
            nacimiento.MaxDate = hace18Anios;
            ingreso.MaxDate = DateTime.Today;
        }

        //Carga el DataGridView.
        private void registrarEncargado_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        //Método para actualizar y mostrar el DataGridView.
        private void ActualizarDataGridView()
        {
            try
            {
                //Limpia el DataGridView.
                dataEncargados.Rows.Clear();

                //Obtiene la lista de clientes desde la capa de datos.
                List<EncargadoCls> encargados = encargadosDatos.ObtenerEncargados();

                //Recorrer los encargados y los agrega al DataGridView.
                foreach (var encargado in encargados)
                {
                    if (encargado != null)
                    {
                        dataEncargados.Rows.Add(
                            encargado.Id, 
                            encargado.Identificacion, 
                            encargado.Nombre, 
                            encargado.Apellido1, 
                            encargado.Apellido2, 
                            encargado.FechaNacimiento.ToShortDateString(), 
                            encargado.FechaIngreso.ToShortDateString());
                    }
                }

                //Refresca el DataGridView
                dataEncargados.Refresh();
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
                //Capturar los datos.
                string idText = id.Text;
                string identificacionString = identificacion.Text;
                string nombreString = nombre.Text;
                string apellido1String = apellido1.Text;
                string apellido2String = apellido2.Text;
                DateTime nacimientoDate = nacimiento.Value;
                DateTime ingresoDate = ingreso.Value;

                //Valida los campos del formulario.
                EncargadoLogica.ValidarCampos(errores, idText, identificacionString, nombreString, apellido1String, apellido2String, id, identificacion, nombre, apellido1, apellido2);

                //Si hay errores de validación, no procede con el registro.
                if (errores.Any())
                    {
                    return;
                }

                //Intenta convertir el ID a un entero.
                int idInt = int.Parse(id.Text);

                //Llama al método AgregarEncargado para agregar el Encargado.
                string resultado = EncargadoLogica.AgregarEncargado(idInt, identificacion.Text, nombre.Text, apellido1.Text, apellido2.Text, nacimiento.Value, ingreso.Value);

                //Verifica si el resultado indica éxito o error y muestra el mensaje adecuado.
                bool esExito = resultado == "Encargado agregado exitosamente.";

                //Muestra si se guardó con éxito o ya existía la ID.
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
               MostrarMensaje("Error al registrar encargado: " + ex.Message, false);
            }
        }

        //Método para mostrar un mensaje en un MessageBox.
        private void MostrarMensaje(string mensaje, bool esExito)
        {
            MessageBox.Show(mensaje, esExito ? "Éxito" : "Error", MessageBoxButtons.OK, esExito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        //Método para limpiar los campos de entrada después de registrar un encargado.
        private void LimpiarCampos()
        {
            id.Clear();
            nombre.Clear();
            identificacion.Clear();
            apellido1.Clear();
            apellido2.Clear();
        }
    }
}
