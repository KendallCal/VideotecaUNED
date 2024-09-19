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
 *  Opción: Registrar Categoría Película.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 29 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDePresentacion
{
    public partial class registrarCategoria : Form
    {
        //Arreglo para guardar los errores.
        private List<string> errores = new List<string>();

        // Instancia de ClientesDatos
        private CategoriaDatos categoriaDatos;

        //Constructor.
        public registrarCategoria()
        {
            InitializeComponent();

            //Inicializa la instancia de ClientesDatos.
            categoriaDatos = new CategoriaDatos();
        }

        //Carga el DataGridView.
        private void registrarCategoriaPelicula_Load(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }

        //Método para actualizar y mostrar el DataGridView.
        public void actualizarDataGridView()
        {
            try
            {
                //Limpia el DataGridView.
                dataCategorias.Rows.Clear();

                //Obtiene la lista de clientes desde la capa de Acceso a Datos.
                List<CategoriaCls> categorias = categoriaDatos.ObtenerCategorias();

                //Recorre los clientes y los agrega al DataGridView.
                foreach (var categoria in categorias)
                {
                    dataCategorias.Rows.Add(categoria.Id, categoria.Categoria, categoria.Descripcion);
                }

                //Actualiza el DataGridView.
                dataCategorias.Refresh();
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
                //Captura los datos de los TextBox.
                string idString = id.Text;
                string categoriaString = categoria.Text;
                string descripcionString = descripcion.Text;

                //Valida los campos.
                CategoriaLogica.ValidarCampos(errores, idString, categoriaString, descripcionString, id, categoria, descripcion);

                //Si hay errores, se detiene el proceso.
                if (errores.Any())
                {
                    return;
                }

                //Intenta convertir el ID a un entero.
                int idInt = int.Parse(idString);

                //Guarda los datos en la lógica.
                string resultado = CategoriaLogica.AgregarCategoria(idInt, categoriaString, descripcionString);

                //Verifica si el ID ya existe.
                bool esExito = resultado == "Categoría agregada exitosamente.";

                //Muestra si se guardó con éxito o si ya existía el ID.
                MostrarMensaje(resultado, esExito);

                //Limpia los campos si se agregó correctamente.
                if (esExito)
                {
                    LimpiarCampos();
                    actualizarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al registrar la categoría: " + ex.Message, false);
            }
        }

        //Método para mostrar un mensaje en un MessageBox.
        private void MostrarMensaje(string mensaje, bool esExito)
        {
            MessageBox.Show(mensaje, esExito ? "Éxito" : "Error", MessageBoxButtons.OK, esExito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        //Método para limpiar los campos de entrada después de registrar una categoría.
        private void LimpiarCampos()
        {
            id.Clear();
            categoria.Clear();
            descripcion.Clear();
        }
    }
}
