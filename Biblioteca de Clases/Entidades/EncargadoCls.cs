using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Encargado.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class EncargadoCls : PersonaCls
    {
        //Variables.
        private int id;
        private DateTime fechaIngreso;

        //Constructor.
        public EncargadoCls(int id, string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaIngreso)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            Id = id;
            FechaIngreso = fechaIngreso;
        }

        //Getters and Setters.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
    }
}