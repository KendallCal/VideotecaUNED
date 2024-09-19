using Entidades;
using CapaDeLogica;
using CapaDeAccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Registrar Cliente.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 1 de Junio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDePresentacion
{
    public partial class registrarCliente : Form
    {
        //Arreglo para guardar los errores.
        private List<string> errores = new List<string>();

        //Calcula la fecha hace 100 años desde la fecha actual.
        DateTime fechaHace100Anios = DateTime.Now.AddYears(-100);

        //Calcula la fecha hace 18 años desde la fecha actual.
        DateTime hace18Anios = DateTime.Now.AddYears(-18);

        //Instancia de ClientesDatos.
        private ClientesDatos clientesDatos;

        //Constructor.
        public registrarCliente()
        {
            InitializeComponent();

            //Inicializa la instancia de ClientesDatos.
            clientesDatos = new ClientesDatos();

            //Establece la fecha mínima.
            nacimiento.MinDate = fechaHace100Anios;
            registro.MinDate = fechaHace100Anios;

            //Establece la fecha máxima.
            nacimiento.MaxDate = hace18Anios;
            registro.MaxDate = DateTime.Today;
        }

        //Carga el DataGridView.
        private void registrarCliente_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        //Método para actualizar y mostrar el DataGridView.
        private void ActualizarDataGridView()
        {
            try
            {
                //Limpia el DataGridView.
                dataClientes.Rows.Clear();

                //Obtiene la lista de clientes desde la capa de datos.
                List<ClienteCls> clientes = clientesDatos.ObtenerClientes();

                //Recorre los clientes y los agrega al DataGridView
                foreach (var cliente in clientes)
                {
                    dataClientes.Rows.Add(
                        cliente.Id, 
                        cliente.Identificacion, 
                        cliente.Nombre, 
                        cliente.Apellido1, 
                        cliente.Apellido2, 
                        cliente.FechaNacimiento.ToShortDateString(), 
                        cliente.FechaRegistro.ToShortDateString(), 
                        cliente.Activo ? "Sí" : "No");
                }

                //Refresca el DataGridView
                dataClientes.Refresh();
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
                string identificacionString = identificacion.Text;
                string nombreString = nombre.Text;
                string apellido1String = apellido1.Text;
                string apellido2String = apellido2.Text;
                DateTime nacimientoDate = nacimiento.Value;
                DateTime registroDate = registro.Value;
                bool activoBool = activo.SelectedItem?.ToString() == "Si";

                //Valida los campos del formulario.
                ClienteLogica.ValidarCampos(errores, idText, identificacionString, nombreString, apellido1String, apellido2String, activo, id, identificacion, nombre, apellido1, apellido2);

                //Si hay errores de validación, no procede con el registro.
                if (errores.Any())
                {
                    return;
                }

                //Intenta convertir el ID a un entero.
                int idInt = int.Parse(idText);

                //Llama al método AgregarCliente para agregar el Cliente.
                string resultado = ClienteLogica.AgregarCliente(idInt, identificacionString, nombreString, apellido1String, apellido2String, registroDate, nacimientoDate, activoBool);

                //Verifica si el resultado indica éxito o error y muestra el mensaje adecuado.
                bool esExito = resultado == "Cliente agregado exitosamente.";

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
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para limpiar los campos de entrada después de registrar un cliente.
        private void LimpiarCampos()
        {
            id.Clear();
            nombre.Clear();
            identificacion.Clear();
            apellido1.Clear();
            apellido2.Clear();
            activo.SelectedItem = null;
        }

        //Método para mostrar un mensaje en un MessageBox.
        private void MostrarMensaje(string mensaje, bool esExito)
        {
            MessageBox.Show(mensaje, esExito ? "Éxito" : "Error", MessageBoxButtons.OK, esExito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}