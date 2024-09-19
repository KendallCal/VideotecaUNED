using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDeDatos;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Conexión y Validación.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 4 de Julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace ClienteTCP
{
    public partial class ConexionYValidacion : Form
    {
        //Variables.
        private bool servidorActivado;

        //Evento para notificar cambios en el estado del servidor.
        public event EventHandler<bool> ServidorEstadoCambiado;

        //Evento para enviar idCliente y nombre completo.
        public event EventHandler<(int, string)> ClienteConectado; 

        //Encapsulador para obtener nombre completo.
        public string NombreCompletoCliente { get; private set; }

        //Encapsulador para obtener el ID del Cliente.
        public int IdCliente { get; private set; }
        
        //Constructor.
        public ConexionYValidacion()
        {
            InitializeComponent();

            //Inicializa el servidor en falso.
            servidorActivado = false;
        }

        //Método donde actualiza el cambio de estado del servidor.
        protected virtual void EstadoCambiado(bool estado)
        {
            ServidorEstadoCambiado?.Invoke(this, estado);
        }

        //Método donde actualiza el nombre completo y el ID cliente.
        protected virtual void ClienteCambiado(int idCliente, string nombreCompleto)
        {
            ClienteConectado?.Invoke(this, (idCliente, nombreCompleto));
            IdCliente = idCliente;
            NombreCompletoCliente = nombreCompleto;
        }

        //Método para conectar con el servidor.
        private void ConectarServidor()
        {
            //Si no esta vacío.
            if (!identificador.Text.Equals(string.Empty))
            {
                //Conecta al Servidor con el Identificador.
                if (ClienteTCPDatos.Conectar(identificador.Text))
                {
                    //Verifica el cliente.
                    bool clienteValido = ClienteTCPDatos.VerificarCliente(identificador.Text);

                    if (clienteValido)
                    {
                        //Obtiene información del cliente.
                        ClienteCls cliente = ClienteTCPDatos.ObtenerCliente(identificador.Text);

                        //Muestra información en los labels.
                        id.Text = cliente.Id.ToString();
                        identificacion.Text = cliente.Identificacion;
                        nombre.Text = $"{cliente.Nombre} {cliente.Apellido1} {cliente.Apellido2}";
                        activo.Text = cliente.Activo ? "Activo" : "Inactivo";
                        nacimiento.Text = cliente.FechaNacimiento.ToShortDateString();
                        registro.Text = cliente.FechaRegistro.ToShortDateString();

                        //Guarda el nombre completo del cliente
                        NombreCompletoCliente = $"{cliente.Nombre} {cliente.Apellido1} {cliente.Apellido2}";

                        //Guarda el id del cliente
                        IdCliente = cliente.Id;

                        //Llama al evento para notificar el cambio del nombre y idCliente.
                        ClienteCambiado(IdCliente, NombreCompletoCliente);

                        //Cambia la interfaz al Conectar.
                        estado.Text = "Conectado a (127.0.0.1, 15500)";
                        estado.ForeColor = Color.Green;
                        servidorActivado = true;
                        btnConectar.Enabled = false;
                        btnDesconectar.Enabled = true;
                        identificador.Enabled = false;

                        //Llama al evento para notificar el cambio de estado del servidor.
                        EstadoCambiado(servidorActivado);
                    }
                    else
                    {
                        MessageBox.Show($"El Cliente {identificador.Text} no esta registrado, no es valido o ya esta conectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que el servidor esté escuchando clientes.", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un identificador primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para desconectar del servidor.
        private void DesconectarServidor()
        {
            //LLama a Desconectar.
            ClienteTCPDatos.Desconectar(identificador.Text);

            //Cambios de la interfaz al Desconectar.
            estado.Text = "Desconectado.";
            estado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            servidorActivado = false;
            identificador.Enabled = true;

            //Limpia los campos.
            limpiarCampos();

            //Llama al evento para notificar el cambio de estado del servidor.
            EstadoCambiado(servidorActivado);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Diseños - - - - - - - - - - - - - - - - - - - - - - - - //
        //Diseño del Botón Iniciar.
        private void btnConectar_MouseEnter(object sender, EventArgs e)
        {
            btnConectar.BackColor = Color.FromArgb(0, 147, 40);
        }

        private void btnConectar_MouseLeave(object sender, EventArgs e)
        {
            btnConectar.BackColor = Color.FromArgb(63, 64, 63);
        }

        //Diseño del Botón Detener.
        private void btnDesconectar_MouseEnter(object sender, EventArgs e)
        {
            btnDesconectar.BackColor = Color.FromArgb(189, 0, 2);
        }

        private void btnDesconectar_MouseLeave(object sender, EventArgs e)
        {
            btnDesconectar.BackColor = Color.FromArgb(63, 64, 63);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Acción - - - - - - - - - - - - - - - - - - - - - - - - //
        //Acción del Botón Iniciar.
        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConectarServidor();
        }

        //Acción del Botón Detener.
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            DesconectarServidor();
        }

        //Método para Limpiar los campos.
        private void limpiarCampos()
        {
            identificador.Text = "";
            id.Text = "";
            identificacion.Text = "";
            nombre.Text = "";
            activo.Text = "";
            nacimiento.Text = "";
            registro.Text = "";
        }
    }
}
