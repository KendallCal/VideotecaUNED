using CapaDeAccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Lógica: Pelicula.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 30 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class PeliculaLogica
    {
        //Método para agregar una película.
        public static string AgregarPelicula(int id, string titulo, CategoriaCls categoria, int anio, string idioma)
        {
            try
            {
                //Instancia el Acceso a Datos de la Película.
                PeliculaDatos peliculaDatos = new PeliculaDatos();

                //Obtiene las peliculas.
                List<PeliculaCls> listaPeliculas = peliculaDatos.ObtenerPeliculas();

                //Si alcanza las 20 películas no se pueden agregar más.
                if (listaPeliculas.Count >= 20)
                {
                    return "No se pueden agregar más películas, el máximo es 20.";
                }

                //Verificar si el ID ya existe.
                if (BuscarIDExistente(id))
                {
                    return "El ID de la película ya existe.";
                }

                //Crea y agrega la Película.
                PeliculaCls nuevaPelicula = new PeliculaCls(id, titulo, categoria, anio, idioma);

                //Llama a el método Agregar Película y envia la nueva película.
                peliculaDatos.AgregarPelicula(nuevaPelicula);

                //Devuelve que se agregó correctamente.
                return "Película agregada exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error en [AgregarPelicula, Logica]: " + ex.Message;
            }
        }

        //Método para buscar si un ID ya existe en las películas.
        public static bool BuscarIDExistente(int id)
        {
            //Instancia el Acceso a Datos de la Película.
            PeliculaDatos peliculaDatos = new PeliculaDatos();

            //Obtiene las peliculas.
            List<PeliculaCls> listaPeliculas = peliculaDatos.ObtenerPeliculas();    

            //Itera en la lista de Peliculas en busca peliculas
            foreach (var pelicula in listaPeliculas)
            {
                if (pelicula != null && pelicula.Id == id)
                {
                    //Retorna true.
                    return true;
                }
            }
            return false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Métodos para validar los campos - - - - - - - - - - - - - - - - - - - - - - - - //
        //Método para validar los campos.
        public static void ValidarCampos(List<String> errores, string idText, string peliculaString, CategoriaCls categoriaSeleccionada, string anioText, string idiomaString, TextBox id, TextBox pelicula, ComboBox categoria, TextBox anio, TextBox idioma)
        {
            //Limpia la lista de errores.
            errores.Clear();

            //Valida cada campo.
            validaID(errores, idText, id);
            validaNombrePelicula(errores, peliculaString, pelicula);
            validaCategoria(errores, categoriaSeleccionada, categoria);
            validaAnio(errores, anioText, anio);
            validaIdioma(errores, idiomaString, idioma);

            //Muestra los errores si los hay.
            if (errores.Any())
            {
                mostrarErrores(errores);
            }
        }

        //Método para mostrar los errores.
        private static void mostrarErrores(List<string> errores)
        {
            //Concatena todos los errores en un solo mensaje.
            string mensajeErrores = string.Join("\n", errores);

            //Muestra el mensaje de errores en un MessageBox.
            MessageBox.Show(mensajeErrores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método para validar el ID.
        private static void validaID(List<string> errores, string idText, TextBox id)
        {
            //Valida que el ID no este vacío.
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                errores.Add("El campo ID no puede estar vacío.");
                CambiarBackground(id);
                return;
            }

            //Valida que el ID solo sean números enteros.
            if (!int.TryParse(id.Text, out _))
            {
                errores.Add("El ID debe ser un número entero.");
                CambiarBackground(id);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(id);
        }

        //Método para validar el Nombre de la película.
        private static void validaNombrePelicula(List<string> errores, string peliculaString, TextBox pelicula)
        {
            //Valida que el Nombre de la película no este vacío.
            if (string.IsNullOrWhiteSpace(pelicula.Text))
            {
                errores.Add("El campo Nombre no puede estar vacío.");
                CambiarBackground(pelicula);
                return;
            }

            //Valida que el nombre de la película solo tenga letras, números, admita tildes y espacio.
            if (!pelicula.Text.All(c => char.IsLetterOrDigit(c) || c == ' ' || "áéíóúÁÉÍÓÚ;:'".Contains(c)))
            {
                errores.Add("El campo Nombre solo puede contener letras, números y espacios.");
                CambiarBackground(pelicula);
                return;
            }

            //Valida que la película tenga un máximo de 150 caracteres.
            if (pelicula.Text.Length >= 100)
            {
                errores.Add("El campo Película no puede tener más de 100 caracteres.");
                CambiarBackground(pelicula);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(pelicula);
        }

        //Método para validar la categoría.
        private static void validaCategoria(List<string> errores, CategoriaCls categoriaSeleccionada, ComboBox categoria)
        {
            //Valida que se haya seleccionado una categoría.
            if (categoria.SelectedItem == null)
            {
                errores.Add("Debe seleccionar una categoría.");
                CambiarBackgroundComboBox(categoria);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginalComboBox(categoria);
        }

        //Método para validar el año.
        private static void validaAnio(List<string> errores, string anioText, TextBox anio)
        {
            //Valida que el año no esté vacío.
            if (string.IsNullOrWhiteSpace(anio.Text))
            {
                errores.Add("El campo Año no puede estar vacío.");
                CambiarBackground(anio);
                return;
            }

            //Valida que el año sea un número entero y tenga exactamente 4 dígitos.
            if (!int.TryParse(anio.Text, out int anioInt) || anio.Text.Length != 4)
            {
                errores.Add("El año debe ser un número entero de 4 dígitos.");
                CambiarBackground(anio);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(anio);
        }

        //Método para validar el idioma.
        private static void validaIdioma(List<string> errores, string idiomaString, TextBox idioma)
        {
            //Valida que el idioma no esté vacío.
            if (string.IsNullOrWhiteSpace(idioma.Text))
            {
                errores.Add("El campo Idioma no puede estar vacío.");
                CambiarBackground(idioma);
                return;
            }

            //Valida que el idioma solo tenga letras y espacio.
            if (!idioma.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                errores.Add("El campo Idioma solo puede contener letras y espacios.");
                CambiarBackground(idioma);
                return;
            }

            //Valida que la idioma tenga un máximo de 25 caracteres.
            if (idioma.Text.Length >= 25)
            {
                errores.Add("El campo Idioma no puede tener más de 25 caracteres.");
                CambiarBackground(idioma);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(idioma);
        }

        //Diseño del Hover de los TextBox.
        private static void CambiarBackground(TextBox textBox)
        {
            textBox.BackColor = Color.FromArgb(247, 160, 139);
        }

        private static void CambiarBackgroundOriginal(TextBox textBox)
        {
            textBox.BackColor = Color.White;
        }

        //Diseño del Hover de los ComboBox.
        private static void CambiarBackgroundComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Color.FromArgb(247, 160, 139);
        }

        private static void CambiarBackgroundOriginalComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
        }
    }
}
