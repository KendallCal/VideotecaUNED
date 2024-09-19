using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Sucursal.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class SucursalDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para agregar una nueva sucursal a la base de datos.
        public void AgregarSucursal(SucursalCls sucursal)
        {
            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    //Abre la conexión a la base de datos.
                    conexion.Open();

                    //Sentencia SQL para insertar una nueva sucursal.
                    string sentenciaSucursal = "INSERT INTO Sucursal (IdSucursal, IdEncargado, Nombre, Direccion, Telefono, Activo) " +
                                               "VALUES (@IdSucursal, @IdEncargado, @Nombre, @Direccion, @Telefono, @Activo)";

                    //Asignación de parámetros a la sentencia SQL.
                    using (SqlCommand comandoSucursal = new SqlCommand(sentenciaSucursal, conexion))
                    {
                        comandoSucursal.Parameters.AddWithValue("@IdSucursal", sucursal.Id);
                        comandoSucursal.Parameters.AddWithValue("@IdEncargado", sucursal.Encargado.Id);
                        comandoSucursal.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                        comandoSucursal.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                        comandoSucursal.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
                        comandoSucursal.Parameters.AddWithValue("@Activo", sucursal.Activo);

                        //Ejecuta la sentencia SQL para insertar los datos.
                        comandoSucursal.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [AgregarSucursal, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [AgregarSucursal, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Método para obtener la lista de sucursales desde la base de datos.
        public List<SucursalCls> ObtenerSucursales()
        {
            //Lista para almacenar las categorías obtenidas.
            List<SucursalCls> listaSucursales = new List<SucursalCls>();

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    //Sentencia SQL para seleccionar los Sucursal.
                    string sentencia = @"SELECT 
                                         s.IdSucursal, 
                                         s.Nombre AS NombreSucursal, 
                                         e.IdEncargado,
                                         p.Identificacion AS IdentificacionEncargado,
                                         p.Nombre AS NombreEncargado,
                                         p.PrimerApellido,
                                         p.SegundoApellido,
                                         p.FechaNacimiento,
                                         e.FechaIngreso,
                                         s.Direccion,
                                         s.Telefono,
                                         s.Activo 
                                     FROM Sucursal s
                                     JOIN Encargado e ON s.IdEncargado = e.IdEncargado
                                     JOIN Persona p ON e.Identificacion = p.Identificacion";

                    //Utiliza la conexión a la base de datos y el comando SQL en un bloque using para asegurar la correcta liberación de recursos.
                    using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                    {
                        //Abre la conexión a la base de datos.
                        conexion.Open();

                        //Ejecuta la consulta y obtiene un lector de datos.
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Crea una instancia de Encargado con los datos leídos.
                                SucursalCls sucursal = new SucursalCls
                                (
                                    reader.GetInt32(reader.GetOrdinal("IdSucursal")),
                                    reader.GetString(reader.GetOrdinal("NombreSucursal")),
                                    new EncargadoCls
                                    (
                                        reader.GetInt32(reader.GetOrdinal("IdEncargado")),
                                        reader.GetString(reader.GetOrdinal("IdentificacionEncargado")),
                                        reader.GetString(reader.GetOrdinal("NombreEncargado")),
                                        reader.GetString(reader.GetOrdinal("PrimerApellido")),
                                        reader.GetString(reader.GetOrdinal("SegundoApellido")),
                                        reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                        reader.GetDateTime(reader.GetOrdinal("FechaIngreso"))
                                    ),
                                    reader.GetString(reader.GetOrdinal("Telefono")),
                                    reader.GetString(reader.GetOrdinal("Direccion")),
                                    reader.GetBoolean(reader.GetOrdinal("Activo"))
                                );
                                //Añade a la lista de sucursales cada Sucursal.
                                listaSucursales.Add(sucursal);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerSucursales, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerSucursales, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Devuelve la lista de sucursales obtenidas.
            return listaSucursales;
        }
    }
}
