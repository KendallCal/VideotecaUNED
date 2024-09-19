using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Préstamo.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class PrestamoDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para agregar un nuevo préstamo a la base de datos.
        public void AgregarPrestamo(PrestamoCls prestamo)
        {
            //Sentencia SQL para insertar un nuevo préstamo.
            string sentenciaPrestamo = "INSERT INTO Prestamo (IdCliente, IdSucursal, IdPelicula, FechaPrestamo, PendienteDevolucion) " +
                                       "VALUES (@IdCliente, @IdSucursal, @IdPelicula, @FechaPrestamo, @PendienteDevolucion)";

            //Uso de using para asegurar la liberación adecuada de los recursos de la conexión.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comandoPrestamo = new SqlCommand(sentenciaPrestamo, conexion))
            {
                //Añade los parámetros a la sentencia SQL.
                comandoPrestamo.Parameters.AddWithValue("@IdCliente", prestamo.Cliente.Id);
                comandoPrestamo.Parameters.AddWithValue("@IdSucursal", prestamo.Sucursal.Id);
                comandoPrestamo.Parameters.AddWithValue("@IdPelicula", prestamo.Pelicula.Id);
                comandoPrestamo.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                comandoPrestamo.Parameters.AddWithValue("@PendienteDevolucion", prestamo.PendienteDevolucion);

                //Abre la conexión y ejecuta la sentencia SQL.
                try
                {
                    //Abre la conexion con la Base de Datos.
                    conexion.Open();

                    //Ejecuta la sentencia.
                    comandoPrestamo.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [AgregarPréstamos, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error al [AgregarPréstamos, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        //Método para obtener préstamos de un cliente específico.
        public List<PrestamoCls> ObtenerPrestamos(int idCliente)
        {
            //Instancia una lista de préstamos.
            var listaPrestamos = new List<PrestamoCls>();

            //Sentencia SQL para seleccionar los datos de préstamos.
            string sentencia = @"
                        SELECT 
                            pr.IdPrestamo,
                            pr.FechaPrestamo,
                            pr.PendienteDevolucion,
                            p.IdPelicula,
                            p.Titulo,
                            c.NombreCategoria,
                            p.AnioLanzamiento,
                            p.Idioma,
                            s.IdSucursal,
                            s.Nombre AS NombreSucursal
                        FROM Prestamo pr
                        JOIN Pelicula p ON pr.IdPelicula = p.IdPelicula
                        JOIN CategoriaPelicula c ON p.IdCategoria = c.IdCategoria
                        JOIN Sucursal s ON pr.IdSucursal = s.IdSucursal
                        WHERE pr.IdCliente = @IdCliente";

            //Uso de using para asegurar la liberación adecuada de los recursos de la conexión y el comando SQL.
            using (var conexion = new SqlConnection(cadenaConexion))
            using (var comando = new SqlCommand(sentencia, conexion))
            {
                //Añade el parámetro a la sentencia SQL.
                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        //Lee cada fila de resultados.
                        while (reader.Read())
                        {
                            //Crea una instancia de la entidad PeliculaCls.
                            var pelicula = new PeliculaCls(
                                id: reader.GetInt32(reader.GetOrdinal("IdPelicula")),
                                titulo: reader.GetString(reader.GetOrdinal("Titulo")),
                                categoria: new CategoriaCls(
                                    id: 0, //No hace falta el ID en este caso.
                                    categoria: reader.GetString(reader.GetOrdinal("NombreCategoria")),
                                    descripcion: "" //No hace falta la descripción en este caso.
                                ),
                                anio: reader.GetInt32(reader.GetOrdinal("AnioLanzamiento")),
                                idioma: reader.GetString(reader.GetOrdinal("Idioma"))
                            );

                            //Crea una instancia de la entidad SucursalCls.
                            var sucursal = new SucursalCls(
                                id: reader.GetInt32(reader.GetOrdinal("IdSucursal")),
                                nombre: reader.GetString(reader.GetOrdinal("NombreSucursal")),
                                encargado: null, //No hace falta el encargado.
                                direccion: "", //No hace falta la dirección
                                telefono: "", //No hace falta el teléfono
                                activo: true //No hace falta saber si esta activa.
                            );

                            //Crea una instancia de la entidad PrestamoCls.
                            var prestamo = new PrestamoCls(
                                cliente: null, //No hace falta el Cliente ya que él realiza el préstamo.
                                sucursal: sucursal,
                                pelicula: pelicula,
                                fechaPrestamo: reader.GetDateTime(reader.GetOrdinal("FechaPrestamo")),
                                pendienteDevolucion: reader.GetBoolean(reader.GetOrdinal("PendienteDevolucion"))
                            )
                            {
                                IdPrestamo = reader.GetInt32(reader.GetOrdinal("IdPrestamo"))
                            };

                            //Añade el préstamo a la lista de préstamos.
                            listaPrestamos.Add(prestamo);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerPréstamos, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerPréstamos, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Retorna la lista de préstamos.
            return listaPrestamos;
        }

        //Método para verificar si el cliente tiene un préstamo pendiente.
        public bool ClienteTienePrestamoPendiente(int idCliente, int idPelicula)
        {
            //Sentencia SQL para contar los préstamos pendientes.
            string sentencia = "SELECT COUNT(*) FROM Prestamo WHERE IdCliente = @IdCliente AND IdPelicula = @IdPelicula AND PendienteDevolucion = 1";

            //Uso de using para asegurar la liberación adecuada de los recursos de la conexión y el comando SQL.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(sentencia, conexion))
            {
                try
                {
                    //Asignación de parámetros a la sentencia SQL.
                    comando.Parameters.AddWithValue("@IdCliente", idCliente);
                    comando.Parameters.AddWithValue("@IdPelicula", idPelicula);

                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Ejecuta la sentencia SQL y retorna true si tiene un préstamo pendiente.
                    return (int)comando.ExecuteScalar() > 0;
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ClienteTienePrestamoPendiente, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ClienteTienePrestamoPendiente, Datos]:  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }
        }
    }
}