using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Cliente.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class ClienteCls : PersonaCls
    {
        //Variables.
        private int id;
        private DateTime fechaRegistro;
        private bool activo;

        //Constructor.
        public ClienteCls(int id, string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaRegistro, bool activo)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            Id = id;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        //Getters and Setters.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}