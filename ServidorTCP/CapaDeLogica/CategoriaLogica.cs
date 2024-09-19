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
 *  Lógica: Categoría.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 29 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class CategoriaLogica
    {
        //Método para agregar una categoría.
        public static string AgregarCategoria(int id, string categoria, string descripcion)
        {
            try
            {
                //Instancia el Acceso a Datos de la Categoría.
                CategoriaDatos categoriaDatos = new CategoriaDatos();

                //Obtiene las categorias para validar la ID.
                List<CategoriaCls> categoriaPelicula = categoriaDatos.ObtenerCategorias();

                //Si alcanza las 20 categorías no se pueden agregar más.
                if (categoriaPelicula.Count >= 20)
                    return "No se pueden agregar más categorías, el máximo es 20.";

                //Valida si el ID ya exíste.
                if (BuscarIDExistente(id))
                    return "El ID de la categoría ya existe.";

                //Crea y agrega la Categoría.
                CategoriaCls nuevaCategoria = new CategoriaCls(id, categoria, descripcion);

                //Llama a el método Agregar Categoría y envia la nueva categoría.
                categoriaDatos.AgregarCategoria(nuevaCategoria);

                //Devuelve que se agregó correctamente.
                return "Categoría agregada exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error en [AgregarCategoria, Logica]: " + ex.Message;
            }
        }

        //Método para buscar si un ID ya existe en las categorías.
        private static bool BuscarIDExistente(int id)
        {
            //Instancia el Acceso a Datos de la Categoría.
            CategoriaDatos categoriaDatos = new CategoriaDatos();

            //Obtiene las categorias para validar la ID.
            List<CategoriaCls> categoriaPelicula = categoriaDatos.ObtenerCategorias();

            //Recorre el arreglo en busca del ID.
            return categoriaPelicula.Any(categoria => categoria?.Id == id);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Métodos para validar los campos - - - - - - - - - - - - - - - - - - - - - - - - //
        //Método para validar los campos.
        public static void ValidarCampos(List<string> errores, string idString, string categoriaString, string descripcionString, TextBox id, TextBox categoria, TextBox descripcion)
        {
            //Limpia la lista de errores.
            errores.Clear();

            //Valida cada campo.
            ValidarID(errores, idString, id);
            ValidarNombre(errores, categoriaString, categoria);
            ValidarDescripcion(errores, descripcionString, descripcion);

            //Muestra los errores si los hay.
            if (errores.Any())
                MostrarErrores(errores);
        }

        //Método para mostrar los errores.
        private static void MostrarErrores(List<String> errores)
        {
            //Concatena todos los errores en un solo mensaje.
            string mensajeErrores = string.Join("\n", errores);

            //Muestra el mensaje de errores en un MessageBox.
            MessageBox.Show(mensajeErrores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método para validar la ID.
        private static void ValidarID(List<String> errores, string idText, TextBox id)
        {
            //Valida que el ID no este vacío.
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                errores.Add("El campo ID no puede estar vacío.");
                CambiarBackground(id);
                return;
            }

            //Valida que el ID solo sean numeros enteros.
            if (!int.TryParse(id.Text, out _))
            {
                errores.Add("El ID debe ser un número entero.");
                CambiarBackground(id);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(id);
        }

        //Método para validar el Nombre.
        private static void ValidarNombre(List<String> errores, string categoriaText, TextBox categoria)
        {
            //Valida que el Nombre no este vacío.
            if (string.IsNullOrWhiteSpace(categoria.Text))
            {
                errores.Add("El campo Nombre no puede estar vacío.");
                CambiarBackground(categoria);
                return;
            }

            //Valida que el nombre solo tenga letras, admita tildes y espacio.
            if (!categoria.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                errores.Add("El campo Nombre solo puede contener letras y espacios.");
                CambiarBackground(categoria);
                return;
            }

            //Valida que el nombre tenga un máximo de 25 caracteres.
            if (categoria.Text.Length >= 25)
            {
                errores.Add("El campo Nombre no puede tener más de 25 caracteres.");
                CambiarBackground(categoria);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(categoria);
        }

        //Método para validar la Descripción.
        private static void ValidarDescripcion(List<String> errores, string descripcionText, TextBox descripcion)
        {
            //Valida que la descripción no este vacia.
            if (string.IsNullOrWhiteSpace(descripcion.Text))
            {
                errores.Add("El campo Descripción no puede estar vacío.");
                CambiarBackground(descripcion);
                return;
            }

            //Valida que la descripción solo tenga letras y admita tildes.
            if (!descripcion.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || " ,.áéíóúÁÉÍÓÚüÜ".Contains(c)))
            {
                errores.Add("El campo Descripción solo puede contener letras.");
                CambiarBackground(descripcion);
                return;
            }

            //Valida que la descripción tenga un máximo de 150 caracteres.
            if (descripcion.Text.Length >= 150)
            {
                errores.Add("El campo Descripción no puede tener más de 150 caracteres.");
                CambiarBackground(descripcion);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(descripcion);
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
    }
}
