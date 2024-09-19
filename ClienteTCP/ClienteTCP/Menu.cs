using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Menú.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 4 de Julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace ClienteTCP
{
    public partial class Menu : Form
    {
        //Variables.
        private Button activarButton;
        private Panel activarLateral;
        private bool mousePresionado;
        private Point lastPoint;

        //Instancia del form Conexion y Validación.
        private ConexionYValidacion conexionForm;

        /*
            Este código de crear los bordes redondos fue agarrado de un video.
            Fuente: https://www.youtube.com/watch?v=HvloZEKo5p0
        */

        //Para hacer los bordes redondos.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        //Constructor.
        public Menu()
        {
            InitializeComponent();

            //Para hacer los bordes redondos.
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //Centra la ventana.
            this.StartPosition = FormStartPosition.CenterScreen;

            //Activa el Hover del Botón.
            ActivarBotonSeleccionado(btnConexion, lateralConexion);

            //Crea una instancia de Conexion y Validacion si no existe.
            if (conexionForm == null)
            {
                conexionForm = new ConexionYValidacion();
                conexionForm.ServidorEstadoCambiado += ConexionForm_ServidorEstadoCambiado;
            }

            //Cambia la opción.
            cambiarOpcion(conexionForm);

            //Suscribe al evento de cambio de estado del servidor.
            conexionForm.ServidorEstadoCambiado += ConexionForm_ServidorEstadoCambiado;
        }

        //Método para cambiar de opción.
        private void cambiarOpcion(Form opcion)
        {
            try
            {
                //Limpia todos los controles del panelPrincipal.
                this.panelPrincipal.Controls.Clear();

                //Indica que el form no es TopLevel.
                opcion.TopLevel = false;

                //Hace que el form se ajuste al tamaño del panel principal.
                opcion.Dock = DockStyle.Fill;

                //Agrega el form al panel principal.
                this.panelPrincipal.Controls.Add(opcion);

                //Establece la propiedad tag.
                this.panelPrincipal.Tag = opcion;

                //Muestra el form.
                opcion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar la opción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para cambiar el estado del servidor.
        private void ConexionForm_ServidorEstadoCambiado(object sender, bool estado)
        {
            ActualizarInformacion(estado);
        }
       
        //Método para actualizar la información.
        public void ActualizarInformacion(bool servidorConectado)
        {
            if (servidorConectado)
            {
                //Si el servidor se conecta muestra que esta conectado.
                estado.ForeColor = Color.Green;
                estado.Text = "   Conectado";

                //Obtiene el nombre del cliente y lo muestra en el label y lo centra.
                string nombreCompletoCliente = conexionForm.NombreCompletoCliente;
                txtCliente.Text = nombreCompletoCliente;
                txtCliente.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                //Si no se conecta muestra lo siguiente.
                estado.ForeColor = Color.Red;
                estado.Text = "Desconectado";
                txtCliente.Text = "";
            }

            //Habilita los botones si está activo.
            btnPrestamo.Visible = servidorConectado;
            btnConsultar.Visible = servidorConectado;
            btnPrestamo.Enabled = servidorConectado;
            btnConsultar.Enabled = servidorConectado;
        }

        //Método para actualizar el estado de los botones.
        private void ActivarBotonSeleccionado(Button button, Panel lateral)
        {
            //Si los botónes estan activos.
            if (button != null && lateral != null)
            {
                if (activarButton != null)
                {
                    //Restaura el color y el lateral del botón anterior.
                    activarButton.BackColor = Color.Black;
                    activarLateral.Visible = false;

                    //Restaura el icono del botón anterior.
                    if (activarButton == btnConexion)
                        btnConexion.Image = Properties.Resources.IconoValidacion;
                    else if (activarButton == btnPrestamo)
                        btnPrestamo.Image = Properties.Resources.IconoPelicula;
                    else if (activarButton == btnConsultar)
                        btnConsultar.Image = Properties.Resources.IconoConsulta;
                }

                //Actualiza el botón actual.
                activarButton = button;
                activarLateral = lateral;
                activarButton.BackColor = Color.FromArgb(59, 59, 59);
                activarLateral.Visible = true;

                //Establece el icono hover del botón actual.
                if (activarButton == btnConexion)
                    btnConexion.Image = Properties.Resources.IconoValidacionHover;
                else if (activarButton == btnPrestamo)
                    btnPrestamo.Image = Properties.Resources.IconoPeliculaHover;
                else if (activarButton == btnConsultar)
                    btnConsultar.Image = Properties.Resources.IconoConsultaHover;
            }
            else
            {
                //Si se pasa null como argumento, restablece todos los botones.
                if (activarButton != null)
                {
                    activarButton.BackColor = Color.Black;
                    activarLateral.Visible = false;

                    if (activarButton == btnConexion)
                        btnConexion.Image = Properties.Resources.IconoValidacion;
                    else if (activarButton == btnPrestamo)
                        btnPrestamo.Image = Properties.Resources.IconoPelicula;
                    else if (activarButton == btnConsultar)
                        btnConsultar.Image = Properties.Resources.IconoConsulta;

                    activarButton = null;
                    activarLateral = null;
                }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - Diseños - - - - - - - - - - - - - - - - - - - - //
        //Diseño del Botón Salir.
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.FromArgb(255, 255, 1);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        //Diseño del Botón Conexión y Validación.
        private void btnConexion_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != btnConexion)
            {
                btnConexion.BackColor = Color.FromArgb(59, 59, 59);
                lateralConexion.Visible = true;
                btnConexion.Image = Properties.Resources.IconoValidacionHover;
            }
        }

        private void btnConexion_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != btnConexion)
            {
                btnConexion.BackColor = Color.Black;
                lateralConexion.Visible = false;
                btnConexion.Image = Properties.Resources.IconoValidacion;
            }
        }

        //Diseño del Botón Préstamo de Películas.
        private void btnPrestamo_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != btnPrestamo)
            {
                btnPrestamo.BackColor = Color.FromArgb(59, 59, 59);
                lateralPrestamo.Visible = true;
                btnPrestamo.Image = Properties.Resources.IconoPeliculaHover;
            }
        }

        private void btnPrestamo_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != btnPrestamo)
            {
                btnPrestamo.BackColor = Color.Black;
                lateralPrestamo.Visible = false;
                btnPrestamo.Image = Properties.Resources.IconoPelicula;
            }
        }

        //Diseño del Botón Consultar Préstamos.
        private void btnConsultar_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != btnConsultar)
            {
                btnConsultar.BackColor = Color.FromArgb(59, 59, 59);
                lateralConsultar.Visible = true;
                btnConsultar.Image = Properties.Resources.IconoConsultaHover;
            }
        }

        private void btnConsultar_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != btnConsultar)
            {
                btnConsultar.BackColor = Color.Black;
                lateralConsultar.Visible = false;
                btnConsultar.Image = Properties.Resources.IconoConsulta;
            }
        }

        // - - - - - - - - - - - - - - - - - - - - Acción - - - - - - - - - - - - - - - - - - - - //
        //Acción del panel principal para mover la ventana.
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePresionado = true;

                //Guarda la ubicación del mouse en el formulario.
                lastPoint = e.Location;
            }
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePresionado)
            {
                //Calcula el desplazamiento desde la última posición del mouse.
                int deltaX = e.X - lastPoint.X;
                int deltaY = e.Y - lastPoint.Y;

                //Mueve el formulario según el desplazamiento calculado.
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            mousePresionado = false;
        }

        //Acción del Botón Salir.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Acción del Botón Conexión y Validación.
        private void btnConexion_Click(object sender, EventArgs e)
        {
            //Para el Hover del botón.
            ActivarBotonSeleccionado(btnConexion, lateralConexion);

            //Crea una instancia de ConexionYValidacion si no existe.
            if (conexionForm == null)
            {
                conexionForm = new ConexionYValidacion();
                conexionForm.ServidorEstadoCambiado += ConexionForm_ServidorEstadoCambiado;
            }

            //Cambia el form.
            cambiarOpcion(conexionForm);

            //Suscribe al evento de cambio de estado del servidor.
            conexionForm.ServidorEstadoCambiado += ConexionForm_ServidorEstadoCambiado;
        }

        //Acción del Botón Préstamo de Películas.
        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            //Activa el diseño del botón.
            ActivarBotonSeleccionado(btnPrestamo, lateralPrestamo);

            //Obtiene el ID desde el formulario de conexión y validación.
            int idCliente = conexionForm.IdCliente;

            //Crea una instancia de Prestamo Peliculas pasando el ID del cliente.
            PrestamoPeliculas prestamoPeliculasForm = new PrestamoPeliculas(idCliente);

            //Cambia la opción para mostrar el formulario de préstamo de películas.
            cambiarOpcion(prestamoPeliculasForm);
        }

        //Acción del Botón Consultar Préstamos.
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Activa el diseño del botón.
            ActivarBotonSeleccionado(btnConsultar, lateralConsultar);

            //Obtiene el ID desde el formulario de conexión y validación.
            int idCliente = conexionForm.IdCliente;

            //Crea una instancia de Consulta Peliculas pasando el ID del cliente.
            ConsultarPrestamos consultaPeliculasForm = new ConsultarPrestamos(idCliente);

            //Cambia la opción para mostrar el formulario de consulta de prestamos.
            cambiarOpcion(consultaPeliculasForm);
        }
    }
}
