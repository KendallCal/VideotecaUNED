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
 *  Lógica: Cliente.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 1 de junio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class ClienteLogica
    {
        //Método para agregar un cliente.
        public static string AgregarCliente(int id, string identificacion, string nombre, string apellido1, string apellido2, DateTime fechaRegistro, DateTime fechaNacimiento, bool activo)
        {
            try
            {
                //Instancia el Acceso a Datos del Cliente.
                ClientesDatos clienteDatos = new ClientesDatos();

                //Obtiene la lista de Clientes.
                List<ClienteCls> listaClientes = clienteDatos.ObtenerClientes();

                //Verifica si se alcanzó el límite de clientes.
                if (listaClientes.Count >= 20)
                {
                    return "No se pueden agregar más clientes, el máximo es 20.";
                }

                //Verifica si el ID ya existe.
                if (BuscarIDExistente(id))
                {
                    return "El ID del cliente ya existe.";
                }

                //Verificar si el Cliente ya existe.
                if (BuscarCliente(identificacion))
                {
                    return "El Cliente ya existe.";
                }

                //Crea y agrega la Película.
                ClienteCls nuevoCliente = new ClienteCls(id, identificacion, nombre, apellido1, apellido2, fechaRegistro, fechaNacimiento, activo);

                //Llama a el método Agregar Clientes y envia el nuevo cliente.
                clienteDatos.AgregarClientes(nuevoCliente);

                //Devolver que se agregó correctamente.
                return "Cliente agregado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error en [AgregarCliente, Logica]: " + ex.Message;
            }
        }

        //Método para buscar si un ID ya existe en los clientes.
        private static bool BuscarIDExistente(int id)
        {
            //Instancia el Acceso a Datos del Cliente.
            ClientesDatos clienteDatos = new ClientesDatos();

            //Obtiene la lista de Clientes.
            List<ClienteCls> listaClientes = clienteDatos.ObtenerClientes();

            //Recorre la lista en busca del ID.
            foreach (var cliente in listaClientes)
            {
                if (cliente != null && cliente.Id == id)
                {
                    //Si el ID existe, retorna true.
                    return true;
                }
            }
            return false;
        }

        //Método para buscar si la Identificación del Encargado ya existe.
        private static bool BuscarCliente(string identificacion)
        {
            //Instancia el Acceso a Datos del Encargado.
            PersonaDatos personaDatos = new PersonaDatos();

            //Obtiene la lista de Encargados.
            List<PersonaCls> listaPersonas = personaDatos.ObtenerPersonas();

            //Recorre la lista en busca de la Identificación.
            foreach (var cliente in listaPersonas)
            {
                //Si hay clientes.
                if (cliente != null)
                {
                    Debug.WriteLine($"Identificacion guardada {cliente.Identificacion.Trim()}");
                    Debug.WriteLine($"Identificacion puesta {identificacion.Trim()}");

                    //Si la identificación eciste en la lista de personas.
                    if (cliente.Identificacion.Trim() == identificacion)
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
        public static void ValidarCampos(List<string> errores, string idText, string identificacionString, string nombreString, string apellido1String, string apellido2String, ComboBox activo, TextBox id, TextBox identificacion, TextBox nombre, TextBox apellido1, TextBox apellido2)
        {
            //Limpia la lista de errores.
            errores.Clear();

            //Valida cada campo.
            validaID(errores, idText, id);
            validaIdentificacion(errores, identificacionString, identificacion);
            validaNombre(errores, nombreString, nombre);
            validaApellido1(errores, apellido1String, apellido1);
            validaApellido2(errores, apellido2String, apellido2);
            validaActiva(errores, activo);

            //Muestra los errores si los hay.
            if (errores.Any())
            {
                mostrarErrores(errores);
            }
        }

        //Método para mostrar los errores en un MessageBox.
        private static void mostrarErrores(List<String> errores)
        {
            // Concatena todos los errores en un solo mensaje.
            string mensajeErrores = string.Join("\n", errores);

            // Muestra el mensaje de errores en un MessageBox.
            MessageBox.Show(mensajeErrores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método para validar el campo ID.
        private static void validaID(List<String> errores, string idText, TextBox id)
        {
            //Valida que ek ID no este Vació.
            if (string.IsNullOrWhiteSpace(idText))
            {
                errores.Add("El campo ID no puede estar vacío.");
                CambiarBackground(id);
                return;
            }

            //Valida que ek ID sea un número entero.
            if (!int.TryParse(idText, out _))
            {
                errores.Add("El ID debe ser un número entero.");
                CambiarBackground(id);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(id);
        }

        //Método para validar la Identificación.
        private static void validaIdentificacion(List<String> errores, string identificacionString, TextBox identificacion)
        {
            //Valida que la Identificación no este Vacía.
            if (string.IsNullOrWhiteSpace(identificacionString))
            {
                errores.Add("El campo Identificación no puede estar vacío.");
                CambiarBackground(identificacion);
                return;
            }

            //Valida que Identificación solo tenga 9 digitos.
            if (!int.TryParse(identificacionString, out _) || identificacionString.Length > 12)
            {
                errores.Add("La identificación no puede tener más de 12 dígitos numericos.");
                CambiarBackground(identificacion);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(identificacion);
        }

        //Método para validar el Nombre.
        private static void validaNombre(List<String> errores, string nombreString, TextBox nombre)
        {
            //Valida que el Nombre no este Vacío.
            if (string.IsNullOrWhiteSpace(nombreString))
            {
                errores.Add("El campo Nombre no puede estar vacío.");
                CambiarBackground(nombre);
                return;
            }

            //Valida que el Nombre solo tenga letras, tildes y espacios.
            if (!nombreString.All(c => char.IsLetter(c) || c == ' ' || "áéíóúÁÉÍÓÚñÑ'".Contains(c)))
            {
                errores.Add("El nombre solo puede contener letras, tildes y espacios.");
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

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(nombre);
        }

        //Método para validar el Primer Apellido.
        private static void validaApellido1(List<String> errores, string apellido1String, TextBox apellido1)
        {
            //Valida que el Primer Apellido no este vacío.
            if (string.IsNullOrWhiteSpace(apellido1String))
            {
                errores.Add("El campo Primer Apellido no puede estar vacío.");
                CambiarBackground(apellido1);
                return;
            }

            //Valida que Segundo Apellido no este vacío.
            if (!apellido1String.All(c => char.IsLetter(c) || "áéíóúÁÉÍÓÚñÑ".Contains(c)))
            {
                errores.Add("El Primer Apellido solo puede contener letras y tildes.");
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

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(apellido1);
        }

        //Método para validar el Segundo Apellido.
        private static void validaApellido2(List<String> errores, string apellido2String, TextBox apellido2)
        {
            //Valida que el Primer Apellido no este vacío.
            if (string.IsNullOrWhiteSpace(apellido2String))
            {
                errores.Add("El campo Segundo Apellido no puede estar vacío.");
                CambiarBackground(apellido2);
                return;
            }

            //Valida que Segundo Apellido solo tenga letras y tildes.
            if (!apellido2String.All(c => char.IsLetter(c) || "áéíóúÁÉÍÓÚñÑ".Contains(c)))
            {
                errores.Add("El Segundo Apellido solo puede contener letras y tildes.");
                CambiarBackground(apellido2);
                return;
            }

            //Valida que el Segundo Apellido tenga un máximo de 25 caracteres.
            if (apellido2String.Length >= 25)
            {
                errores.Add("El campo Primer Segundo no puede tener más de 25 caracteres.");
                CambiarBackground(apellido2);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(apellido2);
        }

        //Método para validar si esta activo o no.
        private static void validaActiva(List<String> errores, ComboBox activo)
        {
            //Verifica si no se ha seleccionado ninguna opción para la actividad de la sucursal.
            if (activo.SelectedItem == null)
            {
                errores.Add("Debe seleccionar si la sucursal está activa o no.");
                CambiarBackgroundComboBox(activo);
                return;
            }
            CambiarBackgroundOriginalComboBox(activo);
        }

        // Método para cambiar el fondo de un TextBox.
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