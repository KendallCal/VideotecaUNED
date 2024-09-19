using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Película.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class PeliculaDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para agregar una película a la base de datos.
        public void AgregarPelicula(PeliculaCls pelicula)
        {
            //Sentencia SQL para insertar una nueva película.
            string sentencia = "INSERT INTO Pelicula (IdPelicula, IdCategoria, Titulo, AnioLanzamiento, Idioma) " +
                               "VALUES (@IdPelicula, @IdCategoria, @Titulo, @AnioLanzamiento, @Idioma)";

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (var conexion = new SqlConnection(cadenaConexion))
            using (var comando = new SqlCommand(sentencia, conexion))
            {
                //Asignación de parámetros a la sentencia SQL.
                comando.Parameters.AddWithValue("@IdPelicula", pelicula.Id);
                comando.Parameters.AddWithValue("@IdCategoria", pelicula.Categoria.Id);
                comando.Parameters.AddWithValue("@Titulo", pelicula.Titulo);
                comando.Parameters.AddWithValue("@AnioLanzamiento", pelicula.Anio);
                comando.Parameters.AddWithValue("@Idioma", pelicula.Idioma);

                //Try Catch para manejar excepciones sql.
                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Ejecuta la sentencia SQL para insertar los datos.
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [AgregarPelículas, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [AgregarPelículas, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método para obtener las películas desde la base de datos.
        public List<PeliculaCls> ObtenerPeliculas()
        {
            //Sentencia SQL para seleccionar las películas.
            string sentencia = @"SELECT 
                                 p.IdPelicula, 
                                 p.Titulo, 
                                 c.IdCategoria, 
                                 c.NombreCategoria,
                                 c.Descripcion,
                                 p.AnioLanzamiento, 
                                 p.Idioma 
                                 FROM Pelicula p
                                 JOIN CategoriaPelicula c ON p.IdCategoria = c.IdCategoria";

            //Lista para almacenar las películas obtenidas.
            var listaPeliculas = new List<PeliculaCls>();

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (var conexion = new SqlConnection(cadenaConexion))
            using (var comando = new SqlCommand(sentencia, conexion))
            {
                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Ejecuta la consulta y obtiene un lector de datos.
                    using (var reader = comando.ExecuteReader())
                    {
                        //Lee los datos obtenidos fila por fila.
                        while (reader.Read())
                        {
                            //Crea una instancia de CategoriaCls con los datos leídos.
                            var categoria = new CategoriaCls(
                                id: reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                categoria: reader.GetString(reader.GetOrdinal("NombreCategoria")),
                                descripcion: reader.GetString(reader.GetOrdinal("Descripcion"))
                            );

                            //Crea una instancia de PeliculaCls con los datos leídos.
                            var pelicula = new PeliculaCls(
                                id: reader.GetInt32(reader.GetOrdinal("IdPelicula")),
                                titulo: reader.GetString(reader.GetOrdinal("Titulo")),
                                categoria: categoria,
                                anio: reader.GetInt32(reader.GetOrdinal("AnioLanzamiento")),
                                idioma: reader.GetString(reader.GetOrdinal("Idioma"))
                            );

                            //Agregar la película creada a la lista de películas.
                            listaPeliculas.Add(pelicula);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerPelículas, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerPelículas, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Devuelve la lista de películas obtenidas.
            return listaPeliculas;
        }
    }
}
