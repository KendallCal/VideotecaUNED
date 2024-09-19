using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class SucursalCls
    {
        //Variables.
        private int id;
        private string nombre;
        private EncargadoCls encargado;
        private string telefono;
        private string direccion;
        private bool activo;

        //Constructor.
        public SucursalCls(int id, string nombre, EncargadoCls encargado, string telefono, string direccion, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Encargado = encargado;
            Telefono = telefono;
            Direccion = direccion;
            Activo = activo;
        }

        //Getters and Setters.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public EncargadoCls Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}