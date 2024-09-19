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
 *  Opción: Registrar Película.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 30 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDePresentacion
{
    public partial class registrarPelicula : Form
    {
        //Arreglo para guardar los errores.
        private List<string> errores = new List<string>();

        //Instancia de ClientesDatos.
        private CategoriaDatos categoriaDatos;

        //Constructor.
        public registrarPelicula()
        {
            InitializeComponent();

            //Inicializa la instancia de ClientesDatos.
            categoriaDatos = new CategoriaDatos();
        }

        //Carga las categorías los datos a los ComboBox y al DataGridView.
        private void registrarPelicula_Load(object sender, EventArgs e)
        {
            try
            {
                //Carga los datos en el DataGridView.
                actualizarDataGridView();

                //Obtiene las Categorías y las guarda en Lista Categorías.
                var listaCategorias = categoriaDatos.ObtenerCategorias();

                //Si no hay ninguna categoría, muestra un mensaje de error.
                if (listaCategorias.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos una categoría antes de registrar una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id.Enabled = false;
                    pelicula.Enabled = false;
                    categoria.Enabled = false;
                    anio.Enabled = false;
                    idioma.Enabled = false;
                    btnRegistrar.Enabled = false;
                    return;
                }

                //Asigna la lista de categorías al origen de datos del ComboBox.
                categoria.DataSource = listaCategorias;

                //Especifica la propiedad de la clase CategoriaCls que se utilizará para mostrar el nombre de la categoría en el ComboBox.
                categoria.DisplayMember = "Categoria";

                //Especifica la propiedad de la clase CategoriaCls que se utilizará como valor seleccionado en el ComboBox.
                categoria.ValueMember = "Id";

                //Inicia el ComboBox en null.
                categoria.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al cargar las categorías: " + ex.Message, false);
            }
        }

        //Método para actualizar y mostrar el DataGridView.
        public void actualizarDataGridView()
        {
            try
            {
                //Limpia el DataGridView antes de cargar nuevos datos.
                dataPeliculas.Rows.Clear();

                //Instancia de Pelicula Datos para obtener las películas de la base de datos.
                PeliculaDatos peliculaDatos = new PeliculaDatos();

                //Obtiene las Películas y las guarda en una lista de películas.
                var listaPeliculas = peliculaDatos.ObtenerPeliculas();

                //Recorre las películas y las añade al DataGridView.
                foreach (var pelicula in listaPeliculas)
                {
                    if (pelicula != null)
                    {
                        //Se agrega cada dato a las columnas.
                        dataPeliculas.Rows.Add(
                            pelicula.Id,
                            pelicula.Titulo,
                            pelicula.Categoria.Id,
                            pelicula.Categoria.Categoria,
                            pelicula.Categoria.Descripcion,
                            pelicula.Anio,
                            pelicula.Idioma
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
                //Captura los datos de los TextBox.
                string idText = id.Text;
                string peliculaString = pelicula.Text;
                CategoriaCls categoriaSeleccionada = (CategoriaCls)categoria.SelectedItem;
                string anioText = anio.Text;
                string idiomaString = idioma.Text;

                //Valida los campos.
                PeliculaLogica.ValidarCampos(errores, idText, peliculaString, categoriaSeleccionada, anioText, idiomaString, id, pelicula, categoria, anio, idioma);

                //Si hay errores, se detiene el proceso.
                if (errores.Any())
                {
                    return;
                }

                //Intenta convertir el ID a un entero.
                int idInt = int.Parse(idText);

                //Intenta convertir el Año a un entero.
                int anioInt = int.Parse(anioText);

                //Guarda los datos en la clase.
                string resultado = PeliculaLogica.AgregarPelicula(idInt, peliculaString, categoriaSeleccionada, anioInt, idiomaString);

                //Verifica si el resultado indica éxito o error y muestra el mensaje adecuado.
                bool esExito = resultado == "Película agregada exitosamente.";

                //Muestra si se guardó con éxito o ya existía la ID.
                MostrarMensaje(resultado, esExito);

                //Limpia los campos si se agregó correctamente.
                if (esExito)
                {
                    actualizarDataGridView();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al registrar la película: " + ex.Message, false);
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
            pelicula.Clear();
            anio.Clear();
            idioma.Clear();
            categoria.SelectedItem = null;
        }
    }
}
