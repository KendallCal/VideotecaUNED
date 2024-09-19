using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Película por Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class PeliculaXSucursalCls
    {
        //Variables.
        private SucursalCls sucursal;
        private PeliculaCls pelicula;
        private int cantidad;

        //Constructor.
        public PeliculaXSucursalCls(SucursalCls sucursal, PeliculaCls pelicula, int cantidad)
        {
            //Id = id;
            Sucursal = sucursal;
            Pelicula = pelicula;
            Cantidad = cantidad;
        }

        //Getters and Setters.
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

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}