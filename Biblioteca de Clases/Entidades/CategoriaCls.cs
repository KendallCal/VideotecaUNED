using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Categoría.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class CategoriaCls
    {
        //Variables.
        private int id;
        private string categoria;
        private string descripcion;

        //Constructor.
        public CategoriaCls(int id, string categoria, string descripcion)
        {
            Id = id;
            Categoria = categoria;
            Descripcion = descripcion;
        }

        //Getters and Setters.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}