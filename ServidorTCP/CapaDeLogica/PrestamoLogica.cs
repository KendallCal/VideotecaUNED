using System;
using CapaDeAccesoDatos;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Lógica: Préstamo.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 10 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeLogica
{
    public class PrestamoLogica
    {
        //Instancias de las clases de acceso a datos
        private readonly PrestamoDatos prestamoDatos = new PrestamoDatos();
        private readonly PeliculaxSucursalDatos peliculaxSucursalDatos = new PeliculaxSucursalDatos();

        //Método para Agregar el Préstamo.
        public void AgregarPrestamo(PrestamoCls nuevoPrestamo)
        {
            try
            {
                //Valida el préstamo y actualiza el inventario si es válido
                if (ValidarPrestamos(nuevoPrestamo))
                {
                    //Agrega el préstamo.
                    prestamoDatos.AgregarPrestamo(nuevoPrestamo);

                    //Actualiza el inventario.
                    peliculaxSucursalDatos.ActualizarInventario(nuevoPrestamo.Sucursal.Id, nuevoPrestamo.Pelicula.Id);
                }
                else
                {
                    throw new InvalidOperationException("El préstamo no es válido.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error en [AgregarPréstamo, Logica]: " + ex.Message);
            }
        }

        //Método para Validar los prestamos.
        public bool ValidarPrestamos(PrestamoCls nuevoPrestamo)
        {
            //Verificar si el cliente tiene un préstamo pendiente de la misma película
            if (prestamoDatos.ClienteTienePrestamoPendiente(nuevoPrestamo.Cliente.Id, nuevoPrestamo.Pelicula.Id))
            {
                return false;
            }

            //Verificar si la película tiene inventario disponible.
            if (!peliculaxSucursalDatos.VerificarInventarioPelicula(nuevoPrestamo.Sucursal.Id, nuevoPrestamo.Pelicula.Id))
            {
                return false;
            }

            return true;
        }

        //Método para verificar si hay inventario.
        public bool VerificarInventario(int sucursalId, int peliculaId)
        {
            return peliculaxSucursalDatos.VerificarInventarioPelicula(sucursalId, peliculaId);
        }
    }
}