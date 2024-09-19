using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Cliente.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class ClientesDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para agregar un cliente a la base de datos.
        public void AgregarClientes(ClienteCls cliente)
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
                        string sentenciaPersona = "INSERT INTO Persona (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento) " +
                                                   "VALUES (@IdentificacionPersona, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento)";

                        using (SqlCommand comandoPersona = new SqlCommand(sentenciaPersona, conexion, transaccion))
                        {
                            comandoPersona.Parameters.AddWithValue("@IdentificacionPersona", cliente.Identificacion);
                            comandoPersona.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                            comandoPersona.Parameters.AddWithValue("@PrimerApellido", cliente.Apellido1);
                            comandoPersona.Parameters.AddWithValue("@SegundoApellido", cliente.Apellido2);
                            comandoPersona.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                            comandoPersona.ExecuteNonQuery();
                        }

                        //Sentencia SQL para insertar un nuevo cliente.
                        string sentenciaCliente = "INSERT INTO Cliente (IdCliente, Identificacion, FechaRegistro, Activo) " +
                                                  "VALUES (@IdCliente, @IdentificacionCliente, @FechaRegistro, @Activo)";

                        using (SqlCommand comandoCliente = new SqlCommand(sentenciaCliente, conexion, transaccion))
                        {
                            comandoCliente.Parameters.AddWithValue("@IdCliente", cliente.Id);
                            comandoCliente.Parameters.AddWithValue("@IdentificacionCliente", cliente.Identificacion);
                            comandoCliente.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                            comandoCliente.Parameters.AddWithValue("@Activo", cliente.Activo);
                            comandoCliente.ExecuteNonQuery();
                        }

                        //Confirma la transacción.
                        transaccion.Commit();
                    }
                    catch (SqlException ex)
                    {
                        //Captura y muestra los errores de SQL.
                        transaccion.Rollback();
                        MessageBox.Show("Error de SQL en [AgregarClientes, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    catch (Exception ex)
                    {
                        //Captura y muestra cualquier otro tipo de error.
                        transaccion.Rollback();
                        MessageBox.Show("Error en [AgregarClientes, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        //Método para obtener la lista de clientes desde la base de datos.
        public List<ClienteCls> ObtenerClientes()
        {
            //Lista para almacenar los Clientes obtenidos.
            List<ClienteCls> listaClientes = new List<ClienteCls>();

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Sentencia SQL para seleccionar los Clientes.
                string sentencia = @"SELECT 
                                        c.IdCliente AS id,
                                        p.Identificacion,
                                        p.Nombre,
                                        p.PrimerApellido AS apellido1,
                                        p.SegundoApellido AS apellido2,
                                        c.FechaRegistro,
                                        p.FechaNacimiento,
                                        c.Activo
                                     FROM 
                                        Cliente c
                                     JOIN 
                                        Persona p ON c.Identificacion = p.Identificacion";

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
                                //Crea una instancia de Cliente con los datos leídos.
                                ClienteCls cliente = new ClienteCls(
                                    id: reader.GetInt32(reader.GetOrdinal("id")),
                                    identificacion: reader.GetString(reader.GetOrdinal("Identificacion")),
                                    nombre: reader.GetString(reader.GetOrdinal("Nombre")),
                                    primerApellido: reader.GetString(reader.GetOrdinal("apellido1")),
                                    segundoApellido: reader.GetString(reader.GetOrdinal("apellido2")),
                                    fechaNacimiento: reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                    fechaRegistro: reader.GetDateTime(reader.GetOrdinal("FechaRegistro")),
                                    activo: reader.GetBoolean(reader.GetOrdinal("Activo"))
                                );

                                //Añade a la lista de clientes cada Cliente.
                                listaClientes.Add(cliente);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        //Captura y muestra los errores de SQL.
                        MessageBox.Show("Error de SQL en [ObtenerClientes, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        //Captura y muestra cualquier otro tipo de error.
                        MessageBox.Show("Error en [ObtenerClientes, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Devuelve la lista de clientes obtenidos.
            return listaClientes;
        }

        //Método para obtener un cliente específico por su identificador desde la base de datos.
        public ClienteCls ObtenerClientePorIdentificador(string identificadorCliente)
        {
            //Declaración de variable para almacenar el cliente obtenido.
            ClienteCls cliente = null;

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Sentencia SQL para seleccionar un cliente por su identificador.
                string sentencia = @"SELECT 
                                c.IdCliente AS id,
                                p.Identificacion,
                                p.Nombre,
                                p.PrimerApellido AS apellido1,
                                p.SegundoApellido AS apellido2,
                                c.FechaRegistro,
                                p.FechaNacimiento,
                                c.Activo
                             FROM 
                                Cliente c
                             JOIN 
                                Persona p ON c.Identificacion = p.Identificacion
                             WHERE 
                                p.Identificacion = @IdentificacionCliente";

                //Uso de SqlCommand para ejecutar la sentencia SQL.
                using (SqlCommand comando = new SqlCommand(sentencia, conexion))
                {
                    //Asignación de parámetros a la sentencia SQL.
                    comando.Parameters.AddWithValue("@IdentificacionCliente", identificadorCliente);

                    //Abre la conexión a la base de datos.
                    try
                    {
                        conexion.Open();

                        //Ejecuta la consulta y obtiene un lector de datos.
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            //Verifica si se encontró un resultado.
                            if (reader.Read())
                            {
                                //Crea una instancia de Cliente con los datos leídos.
                                cliente = new ClienteCls(
                                    id: reader.GetInt32(reader.GetOrdinal("id")),
                                    identificacion: reader.GetString(reader.GetOrdinal("Identificacion")),
                                    nombre: reader.GetString(reader.GetOrdinal("Nombre")),
                                    primerApellido: reader.GetString(reader.GetOrdinal("apellido1")),
                                    segundoApellido: reader.GetString(reader.GetOrdinal("apellido2")),
                                    fechaNacimiento: reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                    fechaRegistro: reader.GetDateTime(reader.GetOrdinal("FechaRegistro")),
                                    activo: reader.GetBoolean(reader.GetOrdinal("Activo"))
                                );
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        //Captura y muestra los errores de SQL.
                        MessageBox.Show("Error de SQL en [ObtenerClientePorIdentificador, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        //Captura y muestra cualquier otro tipo de error.
                        MessageBox.Show("Error en [ObtenerClientePorIdentificador, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Devuelve el cliente obtenido.
            return cliente;
        }
    }
}
