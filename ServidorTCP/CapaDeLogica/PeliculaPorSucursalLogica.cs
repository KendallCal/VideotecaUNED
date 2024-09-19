using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaDeAccesoDatos;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 1. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Lógica: Película por Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 1 de junio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class PeliculaPorSucursalLogica
    {
        //Método para registrar las asociasiones de peliculas por sucursal.
        public static string RegistrarPeliculaPorSucursal(SucursalCls sucursal, List<PeliculaCls> peliculas, int cantidad)
        {
            try
            {
                //Instancia el Acceso a Datos de PeliculasxSucursal.
                PeliculaxSucursalDatos datos = new PeliculaxSucursalDatos();

                //Obtiene la lista de Peliculas Por Sucursales.
                List<PeliculaXSucursalCls> listaPeliculasxSucursal = datos.ObtenerPeliculaXSucursal();

                //Recorre las peliculas.
                foreach (var pelicula in peliculas)
                {
                    //Verifica que la combinación ya existe.
                    if (ExisteAsociacion(sucursal, pelicula))
                    {
                        if (peliculas.Count > 1)
                        {
                            return "La combinación de la sucursal y las películas ya existe.";
                        }
                        else
                        {
                            return "La combinación de la sucursal y película ya existe.";
                        }
                    }

                    //Verifica el limite de asosicaciones.
                    if (listaPeliculasxSucursal.Count >= 100)
                    {
                        return "No se pueden agregar más asociaciones, el límite es de 100.";
                    }

                    //Crea una nueva asociación de PeliculaXSucursalCls.
                    PeliculaXSucursalCls nuevaAsociacion = new PeliculaXSucursalCls(sucursal, pelicula, cantidad);

                    //Guarda la Pelicula por Sucursal.
                    string resultado = datos.agregarPeliculasXSucursal(nuevaAsociacion.Sucursal.Id, nuevaAsociacion.Pelicula.Id, nuevaAsociacion.Cantidad);

                }
                //Devuelve que la asociación se agregó correctamente
                return "Asociación de películas por sucursal realizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error en [AgregarPeliculaPorSucursal, Logica]: " + ex.Message;
            }
        }

        //Método para verificar que exista la asociación.
        private static bool ExisteAsociacion(SucursalCls sucursal, PeliculaCls pelicula)
        {
            //Instancia el Acceso a Datos de PeliculasxSucursal.
            PeliculaxSucursalDatos datos = new PeliculaxSucursalDatos();

            //Obtiene la lista de Peliculas Por Sucursales.
            List<PeliculaXSucursalCls> listaPeliculasxSucursal = datos.ObtenerPeliculaXSucursal();

            //Devuelve si existe o no.
            return listaPeliculasxSucursal.Any(p => p != null && p.Sucursal.Id == sucursal.Id && p.Pelicula.Id == pelicula.Id);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Métodos para validar los campos - - - - - - - - - - - - - - - - - - - - - - - - //
        //Método para validar los campos.
        public static void ValidarCampos(List<String> errores, string cantidadString, SucursalCls sucursalSeleccionada, TextBox cantidad, ComboBox sucursal)
        {
            //Limpia la lista de errores.
            errores.Clear();

            //Valida cada campo.
            validaSucursal(errores, sucursalSeleccionada, sucursal);
            validaCantidad(errores, cantidadString, cantidad);

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

        //Método para validar si la sucursal está activa.
        private static void validaSucursal(List<String> errores, SucursalCls sucursalSeleccionada, ComboBox sucursal)
        {
            //Verifica si no se ha seleccionado ninguna opción para la actividad de la sucursal.
            if (sucursal.SelectedItem == null)
            {
                errores.Add("Debe seleccionar una sucursal");
                CambiarBackgroundComboBox(sucursal);
                return;
            }
            CambiarBackgroundOriginalComboBox(sucursal);
        }

        //Método para validar la cantidad.
        private static void validaCantidad(List<String> errores, string cantidaString, TextBox cantidad)
        {
            //Verifica si la cantidad está vacío.
            if (!int.TryParse(cantidad.Text, out int cantidadValor) || cantidadValor <= 0)
            {
                errores.Add("El campo Cantidad no puede estar vacío y debe ser mayor a 0.");
                CambiarBackground(cantidad);
                return;
            }

            //Verifica si el ID es un número entero.
            if (!int.TryParse(cantidad.Text, out _))
            {
                errores.Add("La cantidad debe ser un número entero mayor a 0.");
                CambiarBackground(cantidad);
                return;
            }

            //Restaura el color de fondo original si no hay errores.
            CambiarBackgroundOriginal(cantidad);
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
