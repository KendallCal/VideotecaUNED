using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Persona.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
	public class PersonaCls
	{
		//Variables.
		private string identificacion;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private DateTime fechaNacimiento;

		//Constructor.
        public PersonaCls(string identificacion, string nombre, string apellido1, string apellido2, DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            FechaNacimiento = fechaNacimiento;
        }

        //Getters and Setters.
        public string Identificacion
		{
			get { return identificacion; }
			set { identificacion = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Apellido1
        {
			get { return apellido1; }
			set { apellido1 = value; }
		}

		public string Apellido2
        {
			get { return apellido2; }
			set { apellido2 = value; }
		}

		public DateTime FechaNacimiento
        {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}
	}
}
