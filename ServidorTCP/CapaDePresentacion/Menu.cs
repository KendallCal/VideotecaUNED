using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Menu.
 *  Estudiante: Kendall Andrey Calderón Burgos
 *  Fecha: 29 de mayo del 2024
 *  Segundo Cuatrimeste
 */

namespace CapaDePresentacion
{
    public partial class Menu : Form
    {
        //Variables.
        private Button activarButton;
        private Panel activarLateral;
        private bool mousePresionado;
        private Point lastPoint;

        //Variable para almacenar la instancia del formulario Servidor.
        private Servidor servidorForm;

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

            //Muestra el panel Menu Datos desde el inicio.
            cambiarOpcion(new MenuDatos());

            //Crea una instancia inicial del formulario Servidor y almacenarla.
            servidorForm = new Servidor();
        }

        //Método para cambiar de opción.
        private void cambiarOpcion(Form opcion)
        {
            try
            {
                if (opcion != null)
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
                else
                {
                    MessageBox.Show("El formulario a mostrar es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar la opción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método para actualizar el estado de los botones.
        private void ActivarBotonSeleccionado(Button button, Panel lateral)
        {
            if (button != null && lateral != null)
            {
                if (activarButton != null)
                {
                    //Restaura el color y el lateral del botón anterior.
                    activarButton.BackColor = Color.Black;
                    activarLateral.Visible = false;

                    //Restaura el icono del botón anterior.
                    if (activarButton == Servidor)
                        Servidor.Image = Properties.Resources.IconoServidor;
                    else if (activarButton == registrarCategoria)
                        registrarCategoria.Image = Properties.Resources.iconCategoria;
                    else if (activarButton == registrarPelicula)
                        registrarPelicula.Image = Properties.Resources.iconPelicula;
                    else if (activarButton == registrarEncargado)
                        registrarEncargado.Image = Properties.Resources.iconEncargado;
                    else if (activarButton == registrarSucursal)
                        registrarSucursal.Image = Properties.Resources.iconTienda;
                    else if (activarButton == registrarCliente)
                        registrarCliente.Image = Properties.Resources.iconoCliente;
                    else if (activarButton == registrarPeliculaSucursal)
                        registrarPeliculaSucursal.Image = Properties.Resources.iconoPeliculaXSucursal;
                }

                //Actualiza el botón actual.
                activarButton = button;
                activarLateral = lateral;

                activarButton.BackColor = Color.FromArgb(59, 59, 59);
                activarLateral.Visible = true;

                //Establece el icono hover del botón actual.
                if (activarButton == Servidor)
                    Servidor.Image = Properties.Resources.IconoServidorHover;
                else if (activarButton == registrarCategoria)
                    registrarCategoria.Image = Properties.Resources.iconCategoriaHover;
                else if (activarButton == registrarPelicula)
                    registrarPelicula.Image = Properties.Resources.iconPeliculaHover;
                else if (activarButton == registrarEncargado)
                    registrarEncargado.Image = Properties.Resources.iconoEncargadoHover;
                else if (activarButton == registrarSucursal)
                    registrarSucursal.Image = Properties.Resources.iconTiendaHover;
                else if (activarButton == registrarCliente)
                    registrarCliente.Image = Properties.Resources.iconoClienteHover;
                else if (activarButton == registrarPeliculaSucursal)
                    registrarPeliculaSucursal.Image = Properties.Resources.iconoPeliculaXSucursalHover;
            }
            else
            {
                //Si se pasa null como argumento, restablece todos los botones.
                if (activarButton != null)
                {
                    activarButton.BackColor = Color.Black;
                    activarLateral.Visible = false;

                    if (activarButton == Servidor)
                        Servidor.Image = Properties.Resources.IconoServidor;
                    else if (activarButton == registrarCategoria)
                        registrarCategoria.Image = Properties.Resources.iconCategoria;
                    else if (activarButton == registrarPelicula)
                        registrarPelicula.Image = Properties.Resources.iconPelicula;
                    else if (activarButton == registrarEncargado)
                        registrarEncargado.Image = Properties.Resources.iconEncargado;
                    else if (activarButton == registrarSucursal)
                        registrarSucursal.Image = Properties.Resources.iconTienda;
                    else if (activarButton == registrarCliente)
                        registrarCliente.Image = Properties.Resources.iconoCliente;
                    else if (activarButton == registrarPeliculaSucursal)
                        registrarPeliculaSucursal.Image = Properties.Resources.iconoPeliculaXSucursal;

                    activarButton = null;
                    activarLateral = null;
                }
            }
        }

        // - - - - - - - - - - - - - - - Diseño de los Botones - - - - - - - - - - - - - - - //
        //Diseño del Botón Salir.
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.FromArgb(255, 255, 1);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        //Diseño del Botón Titulo.
        private void titulo_MouseEnter(object sender, EventArgs e)
        {
            titulo.ForeColor = Color.White;
        }

        private void titulo_MouseLeave(object sender, EventArgs e)
        {
            titulo.ForeColor = Color.FromArgb(253, 255, 0);
        }

        //Diseño del Botón Servidor.
        private void Servidor_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != Servidor)
            {
                Servidor.BackColor = Color.FromArgb(59, 59, 59);
                lateralServidor.Visible = true;
                Servidor.Image = Properties.Resources.IconoServidorHover;
            }
        }

        private void Servidor_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != Servidor)
            {
                Servidor.BackColor = Color.Black;
                lateralServidor.Visible = false;
                Servidor.Image = Properties.Resources.IconoServidor;
            }
        }

        //Diseño del Botón Categoría.
        private void registrarCategoria_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != registrarCategoria)
            {
                registrarCategoria.BackColor = Color.FromArgb(59, 59, 59);
                lateralCategoria.Visible = true;
                registrarCategoria.Image = Properties.Resources.iconCategoriaHover;
            }
        }

        private void registrarCategoria_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != registrarCategoria)
            {
                registrarCategoria.BackColor = Color.Black;
                lateralCategoria.Visible = false;
                registrarCategoria.Image = Properties.Resources.iconCategoria;
            }
        }

        //Diseño del botón Película.
        private void registrarPelicula_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != registrarPelicula)
            {
                registrarPelicula.BackColor = Color.FromArgb(59, 59, 59);
                lateralPelicula.Visible = true;
                registrarPelicula.Image = Properties.Resources.iconPeliculaHover;
            }
        }

        private void registrarPelicula_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != registrarPelicula)
            {
                registrarPelicula.BackColor = Color.Black;
                lateralPelicula.Visible = false;
                registrarPelicula.Image = Properties.Resources.iconPelicula;
            }
        }

        //Diseño del botón Encargado.
        private void registrarEncargado_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != registrarEncargado)
            {
                registrarEncargado.BackColor = Color.FromArgb(59, 59, 59);
                lateralEncargado.Visible = true;
                registrarEncargado.Image = Properties.Resources.iconoEncargadoHover;
            }
        }

        private void registrarEncargado_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != registrarEncargado)
            {
                registrarEncargado.BackColor = Color.Black;
                lateralEncargado.Visible = false;
                registrarEncargado.Image = Properties.Resources.iconEncargado;
            }
        }

        //Diseño del botón Sucursal.
        private void registrarSucursal_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != registrarSucursal)
            {
                registrarSucursal.BackColor = Color.FromArgb(59, 59, 59);
                lateralSucursal.Visible = true;
                registrarSucursal.Image = Properties.Resources.iconTiendaHover;
            }
        }

        private void registrarSucursal_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != registrarSucursal)
            {
                registrarSucursal.BackColor = Color.Black;
                lateralSucursal.Visible = false;
                registrarSucursal.Image = Properties.Resources.iconTienda;
            }
        }

        //Diseño del botón Cliente.
        private void registrarCliente_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != registrarCliente)
            {
                registrarCliente.BackColor = Color.FromArgb(59, 59, 59);
                lateralCliente.Visible = true;
                registrarCliente.Image = Properties.Resources.iconoClienteHover;
            }
        }

        private void registrarCliente_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != registrarCliente)
            {
                registrarCliente.BackColor = Color.Black;
                lateralCliente.Visible = false;
                registrarCliente.Image = Properties.Resources.iconoCliente;
            }
        }

        //Diseño del botón Películas por Sucursal.
        private void registrarPeliculaSucursal_MouseEnter(object sender, EventArgs e)
        {
            if (activarButton != registrarPeliculaSucursal)
            {
                registrarPeliculaSucursal.BackColor = Color.FromArgb(59, 59, 59);
                lateralPeliculasPorSucursal.Visible = true;
                registrarPeliculaSucursal.Image = Properties.Resources.iconoPeliculaXSucursalHover;
            }
        }

        private void registrarPeliculaSucursal_MouseLeave(object sender, EventArgs e)
        {
            if (activarButton != registrarPeliculaSucursal)
            {
                registrarPeliculaSucursal.BackColor = Color.Black;
                lateralPeliculasPorSucursal.Visible = false;
                registrarPeliculaSucursal.Image = Properties.Resources.iconoPeliculaXSucursal;
            }
        }

        // - - - - - - - - - - - - - - - - - - Acción de los botones - - - - - - - - - - - - - - - - - - 
        //Acción del panel principal para mover la ventana.
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Marca como true el bool de presionado.
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

        //Acción del botón Salir.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Se encarga de salir de la aplicación.
            Application.Exit();
        }

        //Acción del botón Titulo.
        private void titulo_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(null, null);
            cambiarOpcion(new MenuDatos());
        }

        //Acción del botón Servidor.
        private void Servidor_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(Servidor, lateralServidor);
            cambiarOpcion(servidorForm);
        }

        //Acción del botón Registrar Categorías.
        private void registrarCategoria_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(registrarCategoria, lateralCategoria);
            cambiarOpcion(new registrarCategoria());
        }

        //Acción del botón Registrar Películas.
        private void registrarPelicula_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(registrarPelicula, lateralPelicula);
            cambiarOpcion(new registrarPelicula());
        }

        //Acción del botón Registrar Encargados.
        private void registrarEncargado_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(registrarEncargado, lateralEncargado);
            cambiarOpcion(new registrarEncargado());
        }

        //Acción del botón Registrar Sucursales.
        private void registrarSucursal_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(registrarSucursal, lateralSucursal);
            cambiarOpcion(new registrarSucursal());
        }

        //Acción del botón Registrar Clientes.
        private void registrarCliente_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(registrarCliente, lateralCliente);
            cambiarOpcion(new registrarCliente());
        }

        //Acción del botón Registrar Películas por Sucursal.
        private void registrarPeliculaSucursal_Click(object sender, EventArgs e)
        {
            ActivarBotonSeleccionado(registrarPeliculaSucursal, lateralPeliculasPorSucursal);
            cambiarOpcion(new registrarPeliculaPorSucursal());
        }
    }
}