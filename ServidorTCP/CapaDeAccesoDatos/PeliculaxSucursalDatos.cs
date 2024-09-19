using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Pelicula Por Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class PeliculaxSucursalDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para insertar una nueva asociación de película por sucursal
        public string agregarPeliculasXSucursal(int idSucursal, int idPelicula, int cantidad)
        {
            try
            {
                //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    //Sentencia SQL para insertar una nueva Pelicula Por Sucursal.
                    string query = @"INSERT INTO PeliculaxSucursal (IdSucursal, IdPelicula, Cantidad)
                                      VALUES (@IdSucursal, @IdPelicula, @Cantidad)";

                    //Asignación de parámetros a la sentencia SQL.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                        command.Parameters.AddWithValue("@IdPelicula", idPelicula);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);

                        //Abre la conexión a la base de datos.
                        connection.Open();
                        command.ExecuteNonQuery();

                        //Retorna mensaje de exito.
                        return "Asociación de película por sucursal registrada correctamente.";
                    }
                }
            }
            catch (SqlException ex)
            {
                //Captura y retorna los errores de SQL.
                return "Error de SQL en [guardarPeliculasXSucursal, Datos]: " + ex.Message;
            }
            catch (Exception ex)
            {
                //Captura y retorna cualquier otro tipo de error.
                return "Error en [guardarPeliculasXSucursal, Datos]: " + ex.Message;
            }
        }

        //Método para obtener todas las películas por sucursal desde la base de datos.
        public List<PeliculaXSucursalCls> ObtenerPeliculaXSucursal()
        {
            //Lista para almacenar las películas por sucursal obtenidas.
            var listaPeliculasXSucursal = new List<PeliculaXSucursalCls>();

            //Sentencia SQL para seleccionar todas las películas por sucursal.
            string sentencia = @"
                SELECT 
                    s.IdSucursal, 
                    s.Nombre AS NombreSucursal, 
                    e.IdEncargado,
                    p.Identificacion AS IdentificacionEncargado,
                    p.Nombre AS NombreEncargado,
                    p.PrimerApellido,
                    p.SegundoApellido,
                    p.FechaNacimiento AS FechaNacimientoEncargado,
                    e.FechaIngreso AS FechaIngresoEncargado,
                    s.Direccion,
                    s.Telefono,
                    s.Activo AS SucursalActiva,
                    pxs.IdPelicula,
                    pxs.Cantidad,
                    pelicula.Titulo,
                    pelicula.AnioLanzamiento,
                    categoria.IdCategoria,
                    categoria.NombreCategoria,
                    categoria.Descripcion,
                    pelicula.Idioma
                FROM PeliculaxSucursal pxs
                JOIN Sucursal s ON pxs.IdSucursal = s.IdSucursal
                JOIN Encargado e ON s.IdEncargado = e.IdEncargado
                JOIN Persona p ON e.Identificacion = p.Identificacion
                JOIN Pelicula pelicula ON pxs.IdPelicula = pelicula.IdPelicula
                JOIN CategoriaPelicula categoria ON pelicula.IdCategoria = categoria.IdCategoria";

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
                            //Crea una instancia de Encargado con los datos leídos.
                            var encargado = new EncargadoCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("IdEncargado")),
                                identificacion: reader.GetString(reader.GetOrdinal("IdentificacionEncargado")),
                                nombre: reader.GetString(reader.GetOrdinal("NombreEncargado")),
                                primerApellido: reader.GetString(reader.GetOrdinal("PrimerApellido")),
                                segundoApellido: reader.GetString(reader.GetOrdinal("SegundoApellido")),
                                fechaNacimiento: reader.GetDateTime(reader.GetOrdinal("FechaNacimientoEncargado")),
                                fechaIngreso: reader.GetDateTime(reader.GetOrdinal("FechaIngresoEncargado"))
                            );

                            //Crea una instancia de Sucursal con los datos leídos.
                            var sucursal = new SucursalCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("IdSucursal")),
                                nombre: reader.GetString(reader.GetOrdinal("NombreSucursal")),
                                encargado: encargado,
                                direccion: reader.GetString(reader.GetOrdinal("Direccion")),
                                telefono: reader.GetString(reader.GetOrdinal("Telefono")),
                                activo: reader.GetBoolean(reader.GetOrdinal("SucursalActiva"))
                            );

                            //Crea una instancia de Categoría de Película con los datos leídos.
                            var categoria = new CategoriaCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                categoria: reader.GetString(reader.GetOrdinal("NombreCategoria")),
                                descripcion: reader.GetString(reader.GetOrdinal("Descripcion"))
                            );

                            //Crea una instancia de Película con los datos leídos.
                            var pelicula = new PeliculaCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("IdPelicula")),
                                categoria: categoria,
                                titulo: reader.GetString(reader.GetOrdinal("Titulo")),
                                anio: reader.GetInt32(reader.GetOrdinal("AnioLanzamiento")),
                                idioma: reader.GetString(reader.GetOrdinal("Idioma"))
                            );

                            //Crea una instancia de Película por Sucursal con los datos leídos.
                            var peliculaXSucursal = new PeliculaXSucursalCls
                            (
                                sucursal: sucursal,
                                pelicula: pelicula,
                                cantidad: reader.GetInt32(reader.GetOrdinal("Cantidad"))
                            );

                            //Agrega la película por sucursal creada a la lista de películas por sucursal.
                            listaPeliculasXSucursal.Add(peliculaXSucursal);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerPeliculasPorSucursal, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerPeliculasPorSucursal, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Devuelve la lista de películas por sucursal obtenidas.
            return listaPeliculasXSucursal;
        }

        //Método para obtener películas por sucursal.
        public List<PeliculaCls> ObtenerPeliculasAsociadaSucursal(string idSucursal)
        {
            //Inicializa una lista para almacenar las películas.
            var listaPeliculas = new List<PeliculaCls>();

            //Consulta SQL para obtener las películas y sus categorías asociadas en una sucursal específica.
            string sentencia = @"
                                SELECT 
                                    p.IdPelicula,
                                    p.Titulo,
                                    p.AnioLanzamiento,
                                    p.Idioma,
                                    c.IdCategoria,
                                    c.NombreCategoria,
                                    c.Descripcion
                                FROM PeliculaxSucursal ps
                                JOIN Pelicula p ON ps.IdPelicula = p.IdPelicula
                                JOIN CategoriaPelicula c ON p.IdCategoria = c.IdCategoria
                                WHERE ps.IdSucursal = @IdSucursal";

            //Utiliza la conexión a la base de datos y el comando SQL en un bloque using para asegurar la correcta liberación de recursos.
            using (var conexion = new SqlConnection(cadenaConexion))
            using (var comando = new SqlCommand(sentencia, conexion))
            {
                comando.Parameters.AddWithValue("@IdSucursal", idSucursal);

                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Ejecuta la consulta y obtiene un lector de datos.
                    using (var reader = comando.ExecuteReader())
                    {
                        //Mientras haya filas en el resultado, lee la información de las películas y sus categorías.
                        while (reader.Read())
                        {
                            //Lee los datos de la categoría.
                            var categoria = new CategoriaCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                categoria: reader.GetString(reader.GetOrdinal("NombreCategoria")),
                                descripcion: reader.GetString(reader.GetOrdinal("Descripcion"))
                            );

                            //Lee los datos de la película.
                            var pelicula = new PeliculaCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("IdPelicula")),
                                categoria: categoria,
                                titulo: reader.GetString(reader.GetOrdinal("Titulo")),
                                anio: reader.GetInt32(reader.GetOrdinal("AnioLanzamiento")),
                                idioma: reader.GetString(reader.GetOrdinal("Idioma"))
                            );

                            //Agrega la película a la lista.
                            listaPeliculas.Add(pelicula);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerPeliculasAsociadaSucursal, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerPeliculasAsociadaSucursal, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Devuelve la lista de películas.
            return listaPeliculas;
        }

        //Método para verificar si hay inventario de una película en una sucursal
        public bool VerificarInventarioPelicula(int idSucursal, int idPelicula)
        {
            //Sentencia SQL para contar cuántas copias de la película hay en la sucursal especificada.
            string sentencia = "SELECT COUNT(*) FROM PeliculaxSucursal WHERE IdSucursal = @IdSucursal AND IdPelicula = @IdPelicula AND Cantidad > 0";

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(sentencia, conexion))
            {
                //Asignación de parámetros a la sentencia SQL.
                comando.Parameters.AddWithValue("@IdSucursal", idSucursal);
                comando.Parameters.AddWithValue("@IdPelicula", idPelicula);

                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Ejecuta la consulta y retorna true si hay inventario disponible.
                    return (int)comando.ExecuteScalar() > 0;
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [VerificarInventarioPelicula, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [VerificarInventarioPelicula, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        //Método para actualizar el inventario de una película en una sucursal.
        public void ActualizarInventario(int idSucursal, int idPelicula)
        {
            //Sentencia SQL para reducir en uno la cantidad de la película en la sucursal especificada.
            string sentencia = "UPDATE PeliculaxSucursal SET Cantidad = Cantidad - 1 WHERE IdSucursal = @IdSucursal AND IdPelicula = @IdPelicula";

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(sentencia, conexion))
            {
                //Asignación de parámetros a la sentencia SQL.
                comando.Parameters.AddWithValue("@IdSucursal", idSucursal);
                comando.Parameters.AddWithValue("@IdPelicula", idPelicula);

                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Ejecuta la sentencia SQL para actualizar la cantidad en la base de datos.
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ActualizarInventario, Datos]:" + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ActualizarInventario, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
