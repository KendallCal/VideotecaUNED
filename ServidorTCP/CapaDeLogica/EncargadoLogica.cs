using CapaDeAccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Lógica: Encargado.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 30 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class EncargadoLogica
    {
        //Método para agregar un encargado.
        public static string AgregarEncargado(int id, string identificacion, string nombre, string apellido1, string apellido2, DateTime fechaNacimiento, DateTime fechaIngreso)
        {
            try
            {
                //Instancia el Acceso a Datos del Encargado.
                var encargadoDatos = new EncargadoDatos();

                //Obtiene la lista de Encargados.
                var listaEncargados = encargadoDatos.ObtenerEncargados();

                //Si alcanza los 20 encargados no se pueden agregar más.
                if (listaEncargados.Count >= 20)
                {
                    return "No se pueden agregar más encargados, el máximo es 20.";
                }

                //Verificar si el ID ya existe.
                if (BuscarIDExistente(id))
                {
                    return "El ID del encargado ya existe.";
                }

                //Verificar si el encargado ya existe.
                if (BuscarEncargado(identificacion))
                {
                    return "El encargado ya existe.";
                }

                //Crea y agrega el Encargado.
                var nuevoEncargado = new EncargadoCls(id, identificacion, nombre, apellido1, apellido2, fechaIngreso, fechaNacimiento);

                //Llama a el método Agregar Encargados y envia el nuevo encargado.
                encargadoDatos.AgregarEncargados(nuevoEncargado);

                //Devuelve que se agregó correctamente.
                return "Encargado agregado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error en [AgregarEncargado, Logica]: " + ex.Message;
            }
        }

        //Método para buscar si un ID ya existe en los encargados.
        private static bool BuscarIDExistente(int id)
        {
            //Instancia el Acceso a Datos del Encargado.
            var encargadoDatos = new EncargadoDatos();

            //Obtiene la lista de Encargados.
            var listaEncargados = encargadoDatos.ObtenerEncargados();

            //Recorre la lista en busca de la ID.
            return listaEncargados.Any(encargado => encargado != null && encargado.Id == id);
        }

        //Método para buscar si la Identificación del encargado ya existe.
        private static bool BuscarEncargado(string identificacion)
        {
            //Instancia el Acceso a Datos del Encargado.
            var personaDatos = new PersonaDatos();

            //Obtiene la lista de Encargados.
            var listaPersonas = personaDatos.ObtenerPersonas();

            //Recorre la lista en busca de la Identificación.
            foreach (var encargado in listaPersonas)
            {
                //Si hay clientes.
                if (encargado != null)
                {
                    Debug.WriteLine($"Identificacion guardada {encargado.Identificacion.Trim()}");
                    Debug.WriteLine($"Identificacion puesta {identificacion.Trim()}");

                    //Si la identificación eciste en la lista de personas.
                    if (encargado.Identificacion.Trim() == identificacion)
                    {
                        Debug.WriteLine("Entro a true");

                        //Retorna true.
                        return true;
                    }
                }
            }
            Debug.WriteLine("Entro a false");
            return false;
        }

        //Método para validar los campos.
        public static void ValidarCampos(List<string> errores, string idText, string identificacionString, string nombreString, string apellido1String, string apellido2String, TextBox id, TextBox identificacion, TextBox nombre, TextBox apellido1, TextBox apellido2)
        {
            //Limpia la lista de errores.
            errores.Clear();

            //Valida cada campo.
            ValidarID(errores, idText, id);
            ValidarIdentificacion(errores, identificacionString, identificacion);
            ValidarNombre(errores, nombreString, nombre);
            ValidarApellido1(errores, apellido1String, apellido1);
            ValidarApellido2(errores, apellido2String, apellido2);

            //Muestra los errores si los hay.
            if (errores.Any())
            {
                MostrarErrores(errores);
            }
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
            if (string.IsNullOrWhiteSpace(idText))
            {
                errores.Add("El campo ID no puede estar vacío.");
                CambiarBackground(id);
                return;
            }

            //Valida que el ID sea un número entero.
            if (!int.TryParse(idText, out _))
            {
                errores.Add("El ID debe ser un número entero.");
                CambiarBackground(id);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(id);
        }

        //Método para validar la Identificación.
        private static void ValidarIdentificacion(List<String> errores, string identificacionString, TextBox identificacion)
        {
            //Valida que la Identificación no este vaía.
            if (string.IsNullOrWhiteSpace(identificacionString))
            {
                errores.Add("El campo Identificación no puede estar vacío.");
                CambiarBackground(identificacion);
                return;
            }

            //Valida que Identificación solo tenga menos de 12 digitos.
            if (!int.TryParse(identificacionString, out _) || identificacionString.Length > 12)
            {
                errores.Add("La identificación no puede tener más de 12 dígitos numéricos.");
                CambiarBackground(identificacion);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(identificacion);
        }

        //Método para validar la Nombre.
        private static void ValidarNombre(List<String> errores, string nombreString, TextBox nombre)
        {
            //Valida que el Nombre no este vacío.
            if (string.IsNullOrWhiteSpace(nombreString))
            {
                errores.Add("El campo Nombre no puede estar vacío.");
                CambiarBackground(nombre);
                return;
            }

            //Valida que el nombre solo contenga letras, espacios y tildes.
            if (!nombreString.All(c => char.IsLetter(c) || c == ' ' || "áéíóúÁÉÍÓÚüÜ".Contains(c)))
            {
                errores.Add("El campo Nombre solo puede contener letras y tildes.");
                CambiarBackground(nombre);
                return;
            }

            //Valida que el nombre tenga un máximo de 25 caracteres.
            if (nombreString.Length >= 25)
            {
                errores.Add("El campo Nombre no puede tener más de 25 caracteres.");
                CambiarBackground(nombre);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(nombre);
        }

        //Método para validar el Primer Apellido.
        private static void ValidarApellido1(List<String> errores, string apellido1String, TextBox apellido1)
        {
            //Valida que el Primer Apellido no este vacío.
            if (string.IsNullOrWhiteSpace(apellido1String))
            {
                errores.Add("El campo Primer Apellido no puede estar vacío.");
                CambiarBackground(apellido1);
                return;
            }

            //Valida que el Primer Apellido solo tenga letras y tildes.
            if (!apellido1String.All(c => char.IsLetter(c) || "áéíóúÁÉÍÓÚüÜ".Contains(c)))
            {
                errores.Add("El campo Primer Apellido solo puede contener letras y tildes.");
                CambiarBackground(apellido1);
                return;
            }

            //Valida que el Primer Apellido tenga un máximo de 25 caracteres.
            if (apellido1String.Length >= 25)
            {
                errores.Add("El campo Primer Apellido no puede tener más de 25 caracteres.");
                CambiarBackground(apellido1);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(apellido1);
        }

        //Método para validar el Segundo Apellido.
        private static void ValidarApellido2(List<String> errores, string apellido2String, TextBox apellido2)
        {
            //Valida que el Segundo Apellido no este vacío.
            if (string.IsNullOrWhiteSpace(apellido2String))
            {
                errores.Add("El campo Segundo Apellido no puede estar vacío.");
                CambiarBackground(apellido2);
                return;
            }

            //Valida que el Segundo Apellido solo tenga letras y tildes.
            if (!apellido2String.All(c => char.IsLetter(c) || "áéíóúÁÉÍÓÚüÜ".Contains(c)))
            {
                errores.Add("El campo Segundo Apellido solo puede contener letras y tildes.");
                CambiarBackground(apellido2);
                return;
            }

            //Valida que el Segundo Apellido tenga un máximo de 25 caracteres.
            if (apellido2String.Length >= 25)
            {
                errores.Add("El campo Segundo Apellido no puede tener más de 25 caracteres.");
                CambiarBackground(apellido2);
                return;
            }

            //Si no hay errores, restaura el color de fondo original.
            CambiarBackgroundOriginal(apellido2);
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
