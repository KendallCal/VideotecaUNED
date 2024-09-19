using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Datos: Persona.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeAccesoDatos
{
    public class PersonaDatos
    {
        //Cadena de conexión a la base de datos.
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;

        //Método para obtener la lista de personas desde la base de datos.
        public List<PersonaCls> ObtenerPersonas()
        {
            //Lista para almacenar las Personas obtenidas.
            List<PersonaCls> listaPersonas = new List<PersonaCls>();

            //Uso de using para asegurar que la conexión y el comando se cierren correctamente al salir del bloque.
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Sentencia SQL para seleccionar las Personas.
                string sentencia = @"SELECT Identificacion
                                  ,Nombre
                                  ,PrimerApellido
                                  ,SegundoApellido
                                  ,FechaNacimiento
                              FROM Persona";

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
                                //Crea una instancia de Persona con los datos leídos.
                                PersonaCls persona = new PersonaCls(
                                    identificacion: reader.GetString(reader.GetOrdinal("Identificacion")),
                                    nombre: reader.GetString(reader.GetOrdinal("Nombre")),
                                    apellido1: reader.GetString(reader.GetOrdinal("PrimerApellido")),
                                    apellido2: reader.GetString(reader.GetOrdinal("SegundoApellido")),
                                    fechaNacimiento: reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"))
                                );

                                //Añade a la lista de personas cada Persona.
                                listaPersonas.Add(persona);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        //Captura y muestra los errores de SQL.
                        MessageBox.Show("Error de SQL en [ObtenerPersonas, Datos]: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        //Captura y muestra cualquier otro tipo de error.
                        MessageBox.Show("Error en [ObtenerPersonas, Datos]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Devuelve la lista de personas obtenidas.
            return listaPersonas;
        }
    }
}
