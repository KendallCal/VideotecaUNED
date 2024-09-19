using CapaDeAccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Lógica: Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 31 de mayo de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class SucursalLogica
    {
        //Método para registrar las sucursales.
        public static string AgregarSucursal(int id, string nombre, EncargadoCls encargado, string telefono, string direccion, bool activo)
        {
            try
            {
                //Instancia el Acceso a Datos de la Sucursal.
                SucursalDatos sucursalDatos = new SucursalDatos();

                //Obtiene la lista de Sucursales.
                List<SucursalCls> listaSucursales = sucursalDatos.ObtenerSucursales();

                //Si se alcanza el límite de sucursales, se devuelve un mensaje de error.
                if (listaSucursales.Count >= 5)
                {
                    return "No se pueden agregar más sucursales, el máximo es 5.";
                }

                //Verifica si el ID de la sucursal ya existe.
                if (BuscarIDExistente(id))
                {
                    return "El ID de la sucursal ya existe.";
                }

                //Crea y agrega la Sucursal.
                SucursalCls nuevaSucursal = new SucursalCls(id, nombre, encargado, telefono, direccion, activo);

                //Llama a el método Agregar Sucursal y envia la nueva sucursal.
                sucursalDatos.AgregarSucursal(nuevaSucursal);

                //Devuelve un mensaje indicando que la sucursal se agregó correctamente.
                return "Sucursal registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error en [AgregarSucursal, Logica]: " + ex.Message;
            }
        }

        //Método para buscar si un ID ya existe en las películas.
        public static bool BuscarIDExistente(int id)
        {
            //Instancia el Acceso a Datos de la Sucursal.
            SucursalDatos sucursalDatos = new SucursalDatos();

            //Obtiene la lista de Sucursales.
            List<SucursalCls> listaSucursales = sucursalDatos.ObtenerSucursales();

            //Recorre la lista de sucursales en busca del ID.
            foreach (var sucursal in listaSucursales)
            {
                //Si el ID existe.
                if (sucursal != null && sucursal.Id == id)
                {
                    //Retorna true.
                    return true;
                }
            }
            return false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Métodos para validar los campos - - - - - - - - - - - - - - - - - - - - - - - - //
        //Método para validar los campos.
        public static void ValidarCampos(List<String> errores, string idText, string nombreString, string direccionString, string telefonoString, EncargadoCls encargadoSeleccionado, bool activoBool, TextBox id, TextBox nombre, TextBox direccion, TextBox telefono, ComboBox encargado, ComboBox activa)
        {
            //Limpia la lista de errores.
            errores.Clear();

            //Valida cada campo.
            validaID(errores,idText, id);
            validaNombre(errores, nombreString, nombre);
            validaDireccion(errores, direccionString, direccion);
            validaTelefono(errores, telefonoString, telefono);
            validaEncargado(errores, encargadoSeleccionado, encargado);
            validaActiva(errores, activoBool, activa);

            // Muestra los errores si los hay.
            if (errores.Any())
            {
                mostrarErrores(errores);
            }
        }

        //Método para mostrar los errores.
        private static void mostrarErrores(List<String> errores)
        {
            //Concatena todos los errores en un solo mensaje.
            string mensajeErrores = string.Join("\n", errores);

            //Muestra el mensaje de errores en un MessageBox.
            MessageBox.Show(mensajeErrores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método para validar el ID.
        private static void validaID(List<String> errores, string idString, TextBox id)
        {
            //Verifica si el ID está vacío.
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                errores.Add("El campo ID no puede estar vacío.");
                CambiarBackground(id);
                return;
            }

            //Verifica si el ID es un número entero.
            if (!int.TryParse(id.Text, out _))
            {
                errores.Add("El ID debe ser un número entero.");
                CambiarBackground(id);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(id);
        }

        //Método para validar el Nombre.
        private static void validaNombre(List<String> errores, string nombreString, TextBox nombre)
        {
            //Verifica si el Nombre está vacío.
            if (string.IsNullOrWhiteSpace(nombre.Text))
            {
                errores.Add("El campo Nombre no puede estar vacío.");
                CambiarBackground(nombre);
                return;
            }

            //Verifica si el nombre contiene caracteres inválidos.
            if (!nombre.Text.All(c => char.IsLetter(c) || c == ' ' || "áéíóúÁÉÍÓÚñÑ0123456789#:".Contains(c)))
            {
                errores.Add("El nombre debe contener solo letras, tildes y la letra ñ.");
                CambiarBackground(nombre);
                return;
            }

            //Valida que el nombre tenga un máximo de 50 caracteres.
            if (nombre.Text.Length >= 50)
            {
                errores.Add("El campo Nombre no puede tener más de 50 caracteres.");
                CambiarBackground(nombre);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(nombre);
        }

        //Método para validar el Dirección.
        private static void validaDireccion(List<String> errores, string direccionString, TextBox direccion)
        {
            //Verifica si el Dirección está vacío.
            if (string.IsNullOrWhiteSpace(direccion.Text))
            {
                errores.Add("El campo Dirección no puede estar vacío.");
                CambiarBackground(direccion);
                return;
            }

            //Verifica si la dirección contiene caracteres inválidos.
            if (!direccion.Text.All(c => char.IsLetterOrDigit(c) || c == ' ' || c == ',' || c == '.' || "áéíóúÁÉÍÓÚñÑÑ:".Contains(c)))
            {
                errores.Add("La dirección debe contener solo letra y números.");
                CambiarBackground(direccion);
                return;
            }

            //Valida que el dirección tenga un máximo de 150 caracteres.
            if (direccion.Text.Length >= 150)
            {
                errores.Add("El campo Dirección no puede tener más de 150 caracteres.");
                CambiarBackground(direccion);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(direccion);
        }

        //Método para validar el Teléfono.
        private static void validaTelefono(List<String> errores, string telefonoString, TextBox telefono)
        {
            //Verifica si el Teléfono está vacío.
            if (string.IsNullOrWhiteSpace(telefono.Text))
            {
                errores.Add("El campo Teléfono no puede estar vacío.");
                CambiarBackground(telefono);
                return;
            }

            //Verifica si el contiene caracteres inválidos.
            if (!telefono.Text.All(c => char.IsDigit(c) || c == '+'))
            {
                errores.Add("El teléfono debe contener solo números.");
                CambiarBackground(telefono);
                return;
            }

            //Valida que el teléfono tenga un máximo de 10 caracteres.
            if (telefono.Text.Length >= 10)
            {
                errores.Add("El campo Teléfono no puede tener más de 10 caracteres.");
                CambiarBackground(telefono);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(telefono);
        }

        //Método para validar el Encargado.
        private static void validaEncargado(List<String> errores, EncargadoCls encargadoSeleccionado, ComboBox encargado)
        {
            //Verifica si no se ha seleccionado ningún encargado.
            if (encargado.SelectedItem == null)
            {
                errores.Add("Debe seleccionar un encargado.");
                CambiarBackgroundComboBox(encargado);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginalComboBox(encargado);
        }

        //Método para validar si la sucursal está activa.
        private static void validaActiva(List<String> errores, bool activoBool, ComboBox activa)
        {
            //Verifica si no se ha seleccionado ninguna opción para la actividad de la sucursal.
            if (activa.SelectedItem == null)
            {
                errores.Add("Debe seleccionar si la sucursal está activa o no.");
                CambiarBackgroundComboBox(activa);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginalComboBox(activa);
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
