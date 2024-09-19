using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Categoría.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class CategoriaDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para agregar una categoría a la base de datos.
        public void AgregarCategoria(CategoriaCls categoria)
        {
            //Sentencia SQL para insertar una nueva categoría.
            string sentencia = "INSERT INTO CategoriaPelicula (IdCategoria, NombreCategoria, Descripcion) " +
                               "VALUES (@IdCategoria, @NombreCategoria, @Descripcion)";

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (var conexion = new SqlConnection(cadenaConexion))
            using (var comando = new SqlCommand(sentencia, conexion))
            {
                //Asignación de parámetros a la sentencia SQL.
                comando.Parameters.AddWithValue("@IdCategoria", categoria.Id);
                comando.Parameters.AddWithValue("@NombreCategoria", categoria.Categoria);
                comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

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
                    MessageBox.Show("Error de SQL en [AgregarCategoria, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("ErroL en [AgregarCategoria, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método para obtener las categorías desde la base de datos.
        public List<CategoriaCls> ObtenerCategorias()
        {
            //Sentencia SQL para seleccionar las categorías.
            string sentencia = "SELECT IdCategoria, NombreCategoria, Descripcion FROM CategoriaPelicula";

            //Lista para almacenar las categorías obtenidas.
            var listaCategorias = new List<CategoriaCls>();

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (var conexion = new SqlConnection(cadenaConexion))
            using (var comando = new SqlCommand(sentencia, conexion))
            {
                //Try Catch para manejar excepciones sql.
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
                            //Agregar cada categoría leída a la lista de categorías.
                            listaCategorias.Add(new CategoriaCls(
                                id: reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                categoria: reader.GetString(reader.GetOrdinal("NombreCategoria")),
                                descripcion: reader.GetString(reader.GetOrdinal("Descripcion"))
                            ));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerCategoria, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerCategoria, Datos]:  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Devuelve la lista de categorías obtenidas.
            return listaCategorias;
        }
    }
}