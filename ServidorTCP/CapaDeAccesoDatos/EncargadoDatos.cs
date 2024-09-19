using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Encargados.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class EncargadoDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para agregar Encargados a la Base de Datos.
        public void AgregarEncargados(EncargadoCls encargado)
        {
            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Abre la conexión a la base de datos.
                conexion.Open();

                //Inserta en la tabla Persona y Encargado dentro de una transacción.
                using (SqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        //Sentencia SQL para insertar una nueva persona.
                        string sentenciaPersona = @"INSERT INTO Persona 
                                                    (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento) 
                                                    VALUES (@IdentificacionPersona, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento)";

                        //Asignación de parámetros a la sentencia SQL.
                        using (SqlCommand comandoPersona = new SqlCommand(sentenciaPersona, conexion, transaccion))
                        {
                            comandoPersona.Parameters.AddWithValue("@IdentificacionPersona", encargado.Identificacion);
                            comandoPersona.Parameters.AddWithValue("@Nombre", encargado.Nombre);
                            comandoPersona.Parameters.AddWithValue("@PrimerApellido", encargado.Apellido1);
                            comandoPersona.Parameters.AddWithValue("@SegundoApellido", encargado.Apellido2);
                            comandoPersona.Parameters.AddWithValue("@FechaNacimiento", encargado.FechaNacimiento);
                            comandoPersona.ExecuteNonQuery();
                        }

                        //Sentencia SQL para insertar un nuevo encargado.
                        string sentenciaEncargado = @"INSERT INTO Encargado 
                                                      (IdEncargado, Identificacion, FechaIngreso) 
                                                      VALUES (@IdEncargado, @IdentificacionEncargado, @FechaIngreso)";

                        //Asignación de parámetros a la sentencia SQL.
                        using (SqlCommand comandoEncargado = new SqlCommand(sentenciaEncargado, conexion, transaccion))
                        {
                            comandoEncargado.Parameters.AddWithValue("@IdEncargado", encargado.Id);
                            comandoEncargado.Parameters.AddWithValue("@IdentificacionEncargado", encargado.Identificacion);
                            comandoEncargado.Parameters.AddWithValue("@FechaIngreso", encargado.FechaIngreso);
                            comandoEncargado.ExecuteNonQuery();
                        }

                        //Confirma la transacción.
                        transaccion.Commit();
                    }
                    catch (SqlException ex)
                    {
                        //Captura y muestra los errores de SQL.
                        transaccion.Rollback();
                        MessageBox.Show("Error de SQL en [AgregarEncargado, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    catch (Exception ex)
                    {
                        //Captura y muestra cualquier otro tipo de error.
                        transaccion.Rollback();
                        MessageBox.Show("Error en [AgregarEncargado, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        //Método para obtener los encargados desde la base de datos.
        public List<EncargadoCls> ObtenerEncargados()
        {
            //Lista para almacenar los Encargados obtenidos.
            var listaEncargados = new List<EncargadoCls>();

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Sentencia SQL para seleccionar los Encargados.
                string sentencia = @"SELECT 
                             c.IdEncargado AS id,
                             p.Identificacion,
                             p.Nombre,
                             p.PrimerApellido AS apellido1,
                             p.SegundoApellido AS apellido2,
                             c.FechaIngreso,
                             p.FechaNacimiento
                             FROM Encargado c
                             JOIN Persona p ON c.Identificacion = p.Identificacion";

                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    try
                    {
                        //Abre la conexión a la base de datos.
                        conexion.Open();

                        //Ejecuta la consulta y obtiene un lector de datos.
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Crea una instancia de Encargado con los datos leídos.
                                var encargado = new EncargadoCls
                                (
                                    id: reader.GetInt32(reader.GetOrdinal("id")),
                                    identificacion: reader.GetString(reader.GetOrdinal("Identificacion")),
                                    nombre: reader.GetString(reader.GetOrdinal("Nombre")),
                                    primerApellido: reader.GetString(reader.GetOrdinal("apellido1")),
                                    segundoApellido: reader.GetString(reader.GetOrdinal("apellido2")),
                                    fechaNacimiento: reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                    fechaIngreso: reader.GetDateTime(reader.GetOrdinal("FechaIngreso"))
                                );

                                //Añade a la lista de encargados cada Encargado.
                                listaEncargados.Add(encargado);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        //Captura y muestra los errores de SQL.
                        MessageBox.Show("Error de SQL en [ObtenerEncargados, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        //Captura y muestra cualquier otro tipo de error.
                        MessageBox.Show("Error en [ObtenerEncargados, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Devuelve la lista de encargados obtenidos.
            return listaEncargados;
        }

        //Método para obtener un encargado por su ID.
        public EncargadoCls ObtenerEncargadoPorId(int idEncargado)
        {
            //Inicializa una variable para almacenar la información del encargado.
            EncargadoCls encargado = null;

            //Consulta SQL para obtener la información del encargado y la persona asociada.
            string query = @"SELECT 
                        c.IdEncargado AS id,
                        p.Identificacion,
                        p.Nombre,
                        p.PrimerApellido AS apellido1,
                        p.SegundoApellido AS apellido2,
                        c.FechaIngreso,
                        p.FechaNacimiento
                     FROM Encargado c
                     JOIN Persona p ON c.Identificacion = p.Identificacion
                     WHERE c.IdEncargado = @IdEncargado";

            //Utiliza la conexión a la base de datos y el comando SQL en un bloque using para asegurar la correcta liberación de recursos.
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                //Agrega el parámetro a la consulta SQL.
                command.Parameters.AddWithValue("@IdEncargado", idEncargado);

                try
                {
                    //Abre la conexión a la base de datos.
                    connection.Open();

                    //Ejecuta la consulta y obtiene un lector de datos.
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Si hay filas en el resultado, lee la información del encargado.
                        if (reader.Read())
                        {
                            //Crea una instancia de EncargadoCls con los datos obtenidos.
                            encargado = new EncargadoCls
                            (
                                id: reader.GetInt32(reader.GetOrdinal("id")),
                                identificacion: reader.GetString(reader.GetOrdinal("Identificacion")),
                                nombre: reader.GetString(reader.GetOrdinal("Nombre")),
                                primerApellido: reader.GetString(reader.GetOrdinal("apellido1")),
                                segundoApellido: reader.GetString(reader.GetOrdinal("apellido2")),
                                fechaNacimiento: reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                fechaIngreso: reader.GetDateTime(reader.GetOrdinal("FechaIngreso"))
                            );
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //Captura y muestra los errores de SQL.
                    MessageBox.Show("Error de SQL en [ObtenerEncargadoPorId, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                catch (Exception ex)
                {
                    //Captura y muestra cualquier otro tipo de error.
                    MessageBox.Show("Error en [ObtenerEncargadoPorId, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            //Devuelve la información del encargado.
            return encargado;
        }
    }
}
