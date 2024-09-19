using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Préstamo.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class PrestamoCls
    {
        //Variables
        private int idPrestamo;
        private ClienteCls cliente;
        private SucursalCls sucursal;
        private PeliculaCls pelicula;
        private DateTime fechaPrestamo;
        private bool pendienteDevolucion;

        //Constructor.
        public PrestamoCls(ClienteCls cliente, SucursalCls sucursal, PeliculaCls pelicula, DateTime fechaPrestamo, bool pendienteDevolucion)
        {
            Cliente = cliente;
            Sucursal = sucursal;
            Pelicula = pelicula;
            FechaPrestamo = fechaPrestamo;
            PendienteDevolucion = pendienteDevolucion;
        }

        //Getters and Setters
        public int IdPrestamo
        {
            get { return idPrestamo; }
            set { idPrestamo = value; }
        }

        public ClienteCls Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public SucursalCls Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public PeliculaCls Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }

        public DateTime FechaPrestamo
        {
            get { return fechaPrestamo; }
            set { fechaPrestamo = value; }
        }

        public bool PendienteDevolucion
        {
            get { return pendienteDevolucion; }
            set { pendienteDevolucion = value; }
        }

        //Método para marcar la devolución del préstamo.
        public void MarcarDevolucion()
        {
            pendienteDevolucion = false;
        }
    }
}
