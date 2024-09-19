using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
using Entidades;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Conexión: Cliente.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 6 - 7 de Julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDeDatos
{
    public class ClienteTCPDatos
    {
        //Almacena la dirección IP del servidor al que el cliente se conectará.
        private static IPAddress ipServidor;

        //Representa la conexión TCP del cliente con el servidor.
        private static TcpClient cliente;

        //Representa el punto final del servidor al que el cliente se conectará, combinando la dirección IP del servidor y el número de puerto.
        private static IPEndPoint serverEndPoint;

        //Permite al cliente escribir datos hacia el servidor a través de la conexión TCP.
        private static StreamWriter clienteStreamWriter;

        //Permite al cliente leer datos del servidor a través de la conexión TCP.
        private static StreamReader clienteStreamReader;

        // - - - - - - - - - - - - - - - - - - - - - Conectar y Desconectar - - - - - - - - - - - - - - - - - - - - - //
        //Intenta establecer una conexión TCP/IP con el servidor especificado.
        public static bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                //Guarda la IP del servidor.
                ipServidor = IPAddress.Parse("127.0.0.1");

                //Crea un nuevo cliente TCP/IP.
                cliente = new TcpClient();

                //Establece el punto final del servidor.
                serverEndPoint = new IPEndPoint(ipServidor, 15500);

                //Intenta conectar el cliente al servidor utilizando el punto final especificado.
                cliente.Connect(serverEndPoint);

                //Prepara un mensaje para enviar al servidor con el método y la entidad específica (identificador del cliente).
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };

                //Prepara los flujos de escritura y lectura para comunicarse con el servidor a través del cliente.
                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());

                //Convierte el mensaje a formato JSON y lo envía al servidor a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));

                //Asegura que todos los datos se envíen al servidor.
                clienteStreamWriter.Flush();
            }
            catch (SocketException)
            {
                return false;
            }
            //Si la conexión se establece correctamente, devuelve True.
            return true;
        }

        //Desconecta el Cliente del servidor.
        public static void Desconectar(string pIdentificadorCliente)
        {
            try
            {
                //Crea un mensaje de socket para indicar al servidor que se desea desconectar.
                MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };

                //Envía el mensaje serializado en formato JSON al servidor a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));

                //Asegura que todos los datos se envíen al servidor.
                clienteStreamWriter.Flush();

                //Cierra la conexión del cliente TCP/IP.
                cliente.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al Desconectarse : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Método de Clientes  - - - - - - - - - - - - - - - - - - - - - //
        //Método para verificar los clientes.
        public static bool VerificarCliente(string pIdentificadorCliente)
        {
            try
            {
                //Crea un mensaje de verificación del cliente.
                MensajeSocket<string> mensajeVerificar = new MensajeSocket<string>
                {
                    Metodo = "VerificarCliente",
                    Entidad = pIdentificadorCliente
                };

                //Envía el mensaje al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeVerificar));
                clienteStreamWriter.Flush();

                //Lee la respuesta del servidor.
                string respuesta = clienteStreamReader.ReadLine();

                //Deserializa la respuesta.
                MensajeSocket<bool> resultadoVerificacion = JsonConvert.DeserializeObject<MensajeSocket<bool>>(respuesta);

                //Devuelve el resultado de la verificación.
                return resultadoVerificacion.Entidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al verificar clientes en Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método para obtener un cliente específico desde el servidor.
        public static ClienteCls ObtenerCliente(string identificadorCliente)
        {
            try
            {
                //Crea un mensaje para obtener el cliente con el método y el identificador del cliente.
                MensajeSocket<string> mensajeObtenerCliente = new MensajeSocket<string> { Metodo = "ObtenerCliente", Entidad = identificadorCliente };

                //Envía el mensaje serializado en formato JSON al servidor a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerCliente));
                clienteStreamWriter.Flush();

                //Lee la respuesta del ServidorTCP.
                string respuesta = clienteStreamReader.ReadLine();

                //Deserializa la respuesta del ServidorTCP.
                MensajeSocket<ClienteCls> mensajeCliente = JsonConvert.DeserializeObject<MensajeSocket<ClienteCls>>(respuesta);

                //Devuelve la entidad de cliente obtenida del servidor.
                return mensajeCliente.Entidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener el Cliente  en Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Métodos para Registrar Prestamos - - - - - - - - - - - - - - - - - - - - - //
        //Método para Obtener las Sucursales.
        public static List<SucursalCls> ObtenerSucursales()
        {
            //Instancia una lista de sucursales.
            List<SucursalCls> listaSucursales = new List<SucursalCls>();

            try
            {
                //Prepara un mensaje para obtener las sucursales.
                MensajeSocket<string> mensajeObtenerSucursales = new MensajeSocket<string> { Metodo = "ObtenerSucursales" };

                //Envía el mensaje serializado al ServidorTCP a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerSucursales));
                clienteStreamWriter.Flush();

                //Lee la respuesta del ServidorTCP.
                var mensaje = clienteStreamReader.ReadLine();

                //Deserializa la respuesta del servidor en una lista de sucursales.
                listaSucursales = JsonConvert.DeserializeObject<List<SucursalCls>>(mensaje);

                //Devuelve la lista de sucursales.
                return listaSucursales;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las Sucursales en Datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; 
            }
        }

        //Método para Obtener las Peliculas Asociadas a la Sucursal.
        public static List<PeliculaCls> ObtenerPeliculasPorSucursal(string idSucursal)
        {
            //Instancia una lista de Peliculas.
            List<PeliculaCls> listaPeliculas = new List<PeliculaCls>();

            try
            {
                //Prepara un mensaje para obtener las peliculas.
                MensajeSocket<string> mensajeObtenerPeliculasAsociadas = new MensajeSocket<string> { Metodo = "ObtenerPeliculasAsociadas", Entidad = idSucursal };

                //Envía el mensaje serializado al ServidorTCP a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerPeliculasAsociadas));
                clienteStreamWriter.Flush();

                //Lee la respuesta del ServidorTCP.
                var mensaje = clienteStreamReader.ReadLine();

                //Deserializa la respuesta del servidor en una lista de peliculas.
                listaPeliculas = JsonConvert.DeserializeObject<List<PeliculaCls>>(mensaje);

                //Devuelve la lista de peliculas asociadas.
                return listaPeliculas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las Peliculas Asociadas a la Sucursal en Datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Método estático para agregar un préstamo utilizando sockets.
        public static dynamic AgregarPrestamo(PrestamoCls nuevoPrestamo)
        {
            try
            {
                //Crea un mensaje de socket para agregar el préstamo.
                MensajeSocket<PrestamoCls> mensajeAgregarPrestamo = new MensajeSocket<PrestamoCls> { Metodo = "AgregarPrestamo", Entidad = nuevoPrestamo };

                //Envía el mensaje serializado al servidor a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAgregarPrestamo));
                clienteStreamWriter.Flush();

                //Lee la respuesta del servidor.
                var mensaje = clienteStreamReader.ReadLine();

                //Deserializa la respuesta.
                dynamic respuesta = JsonConvert.DeserializeObject(mensaje);

                //Devuelve la respuesta.
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el Préstamo en Datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Métodos para Consultar Prestamos - - - - - - - - - - - - - - - - - - - - - //
        //Método estático para obtener los préstamos asociados al ID del Cliente utilizando sockets.
        public static List<PrestamoCls> ObtenerPrestamos(int idCliente)
        {
            //Lista para almacenar los préstamos obtenidos.
            List<PrestamoCls> listaPrestamos = new List<PrestamoCls>();

            try
            {
                //Crea un mensaje de socket para solicitar los préstamos del cliente especificado.
                MensajeSocket<int> mensajeObtenerPrestamos = new MensajeSocket<int> { Metodo = "ObtenerPrestamos", Entidad = idCliente };

                //Envía el mensaje serializado al cliente a través del flujo de escritura.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerPrestamos));
                clienteStreamWriter.Flush();

                //Lee la respuesta del cliente.
                var mensaje = clienteStreamReader.ReadLine();

                //Deserializa la respuesta.
                dynamic response = JsonConvert.DeserializeObject(mensaje);

                //Verifica el tipo de respuesta.
                if (response is JArray)
                {
                    //Si la respuesta es un arreglo JSON, conviértelo a una lista de objetos PrestamoCls.
                    listaPrestamos = response.ToObject<List<PrestamoCls>>();
                }
                else if (response.Error != null)
                {
                    throw new Exception($"Error al obtener préstamos: {response.Error}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Obtener los Préstamos en Datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            //Devuelve la lista de préstamos obtenidos.
            return listaPrestamos;
        }
    }
}
