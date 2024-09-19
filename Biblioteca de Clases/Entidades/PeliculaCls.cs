using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Película.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    public class PeliculaCls
    {
        //Variables.
        private int id;
        private string titulo;
        private CategoriaCls categoria;
        private int anio;
        private string idioma;

        //Constructor.
        public PeliculaCls(int id, string titulo, CategoriaCls categoria, int anio, string idioma)
        {
            Id = id;
            Titulo = titulo;
            Categoria = categoria;
            Anio = anio;
            Idioma = idioma;
        }

        //Getters and Setters.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public CategoriaCls Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }
    }
}