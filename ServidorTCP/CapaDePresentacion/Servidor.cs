using Entidades;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using CapaDeAccesoDatos;
using System.Collections.Generic;
using CapaDeLogica;
using System.Threading.Tasks;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Servidor
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 4 de Julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace CapaDePresentacion
{
    public partial class Servidor : Form
    {
        //Variables.
        bool servidorIniciado;

        //TcpListener para aceptar conexiones de clientes.
        TcpListener tcpListener;

        //Subproceso para escuchar a los clientes.
        Thread subprocesoEscuchaClientes;

        //Delegado para escribir en el textbox de la bitácora.
        EscribirEnTextboxDelegado modificarTextotxtBitacora;

        //Delegado para modificar la lista de clientes conectados.
        ModoficarListBoxDelegado modificarListBoxClientes;

        //Para manejar la cancelación del TcpListener
        CancellationTokenSource cts;

        //Semafaro de préstamos.
        private SemaphoreSlim semaforoPrestamos = new SemaphoreSlim(1, 1);

        //Guarda las identificaciones que estan conectadas.
        private List<string> identificacionesConectadas; 

        //Delegados necesarios para modificar controles de la interfaz gráfica desde un subproceso.
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);

        //Constructor,
        public Servidor()
        {
            InitializeComponent();

            //Inicializa los delegados.
            modificarTextotxtBitacora = new EscribirEnTextboxDelegado(ActualizarBitacora);
            modificarListBoxClientes = new ModoficarListBoxDelegado(ActualizarClientesComectados);

            //Inicializa el botón Detener en falso.
            btnDetener.Enabled = false;

            //Inicializa la lista de identificaciones conectadas.
            identificacionesConectadas = new List<string>();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  Métodos - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //
        //Método para escuchar a los clientes.
        private void EscucharClientes()
        {
            //Inicia el TcpListener para aceptar conexiones entrantes.
            tcpListener.Start();

            //Mantiene el bucle mientras el servidor esté iniciado.
            while (servidorIniciado)
            {
                try
                {
                    //Acepta una nueva conexión de cliente.
                    TcpClient client = tcpListener.AcceptTcpClient();

                    //Crea un nuevo hilo para manejar la comunicación con el cliente aceptado.
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(client);
                }
                catch (SocketException) when (!servidorIniciado)
                {
                    //Ignora la excepción si el servidor no está iniciado.
                    break;
                }
                catch (ThreadAbortException)
                {
                    //Maneja la anulación del hilo si es necesario.
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en [EscucharClientes, Servidor]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        //Método para actualizar la bitácora.
        private void ActualizarBitacora(string texto)
        {
            //Verifica si el formulario está cerrado o el TextBox está desechado.
            if (bitacora.IsDisposed)
                return;

            //Verifica si se necesita invocar desde otro hilo.
            if (bitacora.InvokeRequired)
            {
                //Si se necesita invocar, llama al delegado modificarTextotxtBitacora en el hilo adecuado con el texto proporcionado.
                bitacora.Invoke(modificarTextotxtBitacora, new object[] { texto });
            }
            else
            {
                //Añade el texto con la fecha y hora actual al TextBox de la bitácora.
                bitacora.AppendText(DateTime.Now.ToString() + " - " + texto);

                //Añade una nueva línea al final del texto.
                bitacora.AppendText(Environment.NewLine);
            }
        }

        //Método para actualizar la lista de clientes conectados.
        private void ActualizarClientesComectados(string texto, bool agregar)
        {
            //Verifica si se requiere una invocación desde un hilo diferente al hilo principal.
            if (conectados.InvokeRequired)
            {
                //Si es necesario, invoca de manera segura el delegado modificarListBoxClientes en el hilo principal.
                conectados.Invoke(modificarListBoxClientes, new object[] { texto, agregar });
            }
            else
            {
                //Si la invocación no es necesaria (se está ejecutando en el hilo principal), actualiza la lista directamente.
                if (agregar)
                {
                    //Agrega el texto a la lista conectados.
                    conectados.Items.Add(texto);
                }
                else
                {
                    //Remueve el texto de la lista conectados.
                    conectados.Items.Remove(texto);
                }
            }
        }

        // - - - - - - - - - Métodos para agregar, eliminar y verificar si el cliente esta conectado. - - - - - - - - - //
        //Método para verificar si esta conectado.
        private bool EstaIdentificacionConectada(string identificacion)
        {
            lock (identificacionesConectadas)
            {
                return identificacionesConectadas.Contains(identificacion);
            }
        }

        //Método pra agregar el cliente a la lista de conectados.
        private void AgregarIdentificacionConectada(string identificacion)
        {
            lock (identificacionesConectadas)
            {
                identificacionesConectadas.Add(identificacion);
            }
        }

        //Método para eliminar el cliente de la lista de conectados.
        private void RemoverIdentificacionConectada(string identificacion)
        {
            lock (identificacionesConectadas)
            {
                identificacionesConectadas.Remove(identificacion);
            }
        }

        //Método para manejar la comunicación con un cliente específico.
        private async void ComunicacionCliente(object cliente)
        {
            //Convierte el objeto cliente a TcpClient.
            TcpClient tcCliente = (TcpClient)cliente;

            //Crea un lector para recibir datos del flujo de red del cliente.
            StreamReader reader = new StreamReader(tcCliente.GetStream());

            //Crea un escritor para enviar datos al flujo de red del cliente.
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());

            //Crea una variable para la identificación.
            string identificadorCliente = null;

            //Variable por si la desconexión es voluntaria.
            bool desconexionVoluntaria = false; 

            try
            {
                //Bucle para mantener la comunicación mientras el servidor esté iniciado.
                while (servidorIniciado)
                {
                    try
                    {
                        //Verifica que el cliente este conectado.
                        if (!tcCliente.Connected)
                            break;

                        //Lee el mensaje enviado por el cliente.
                        var mensaje = reader.ReadLine();

                        //Si el mensaje es null, sale.
                        if (mensaje == null) 
                            break;

                        //Deserializa el mensaje recibido.
                        MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje);

                        //Switch para manejar diferentes tipos de mensajes según el método especificado en el mensaje.
                        switch (mensajeRecibido.Metodo)
                        {
                            case "Conectar":
                                //Deserializa el mensaje en un objeto MensajeSocket<string> para obtener el identificador del cliente.
                                MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);
                                identificadorCliente = mensajeConectar.Entidad;

                                //Intenta conectar al cliente llamando al método Conectar.
                                if (Conectar(identificadorCliente))
                                {
                                    //Si la conexión es exitosa, registra en la bitácora y actualiza la lista de clientes conectados.
                                    ActualizarBitacora(identificadorCliente + " se conectó.");
                                    ActualizarClientesComectados(identificadorCliente, true);
                                }
                                else
                                {
                                    //Si no se puede conectar, envía una respuesta de conexión fallida al cliente.
                                    servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(new { Metodo = "ConectarRespuesta", Entidad = false }));
                                    servidorStreamWriter.Flush();
                                }
                                break;
                            case "Desconectar":
                                //Deserializa el mensaje en un objeto MensajeSocket<string> para obtener el identificador del cliente a desconectar.
                                MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);
                                identificadorCliente = mensajeDesconectar.Entidad;

                                //Marca que la desconexión es voluntaria.
                                desconexionVoluntaria = true;

                                //Registra en la bitácora que el cliente se ha desconectado y actualiza la lista de clientes conectados.
                                ActualizarClientesComectados(identificadorCliente, false);

                                //Llama al método Desconectar con el identificador de cliente.
                                Desconectar(identificadorCliente);
                                break;
                            case "VerificarCliente":
                                //Deserializa el mensaje para obtener el identificador de cliente a verificar.
                                MensajeSocket<string> mensajeVerificarCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);

                                //Verifica si el cliente es válido y envía la respuesta al cliente.
                                bool esClienteValido = VerificarCliente(mensajeVerificarCliente.Entidad);

                                //Envia el resultado de la operación.
                                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(new { Metodo = "VerificarClienteRespuesta", Entidad = esClienteValido }));
                                servidorStreamWriter.Flush();
                                break;
                            case "ObtenerCliente":
                                //Deserializa el mensaje para obtener el identificador de cliente a obtener.
                                MensajeSocket<string> mensajeObtenerCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);

                                //Obtiene el cliente especificado y envía la respuesta al cliente.
                                ObtenerCliente(mensajeObtenerCliente.Entidad, servidorStreamWriter);
                                break;
                            case "ObtenerSucursales":
                                //Obtiene la lista de sucursales y envía la respuesta al cliente.
                                ObtenerSucursales(ref servidorStreamWriter);
                                break;
                            case "ObtenerPeliculasAsociadas":
                                //Deserializa el mensaje para obtener el identificador de sucursal y obtener las películas asociadas.
                                MensajeSocket<string> mensajeObtenerPeliculasPorSucursal = JsonConvert.DeserializeObject<MensajeSocket<string>>(mensaje);

                                //Obtiene las películas asociadas a la sucursal especificada y envía la respuesta al cliente.
                                ObtenerPeliculasAsociadas(mensajeObtenerPeliculasPorSucursal.Entidad, ref servidorStreamWriter);
                                break;
                            case "AgregarPrestamo":
                                //Deserializa el mensaje recibido para obtener la información del préstamo que se va a agregar.
                                MensajeSocket<PrestamoCls> mensajeAgregarPrestamo = JsonConvert.DeserializeObject<MensajeSocket<PrestamoCls>>(mensaje);

                                //Llama al método Asincrónico para agregar el préstamo en la base de datos y almacena el resultado.
                                var resultado = await AgregarPrestamo(mensajeAgregarPrestamo.Entidad);

                                //Envía el resultado de la operación de agregar préstamo de vuelta al cliente, serializándolo a formato JSON.
                                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(resultado));
                                servidorStreamWriter.Flush();
                                break;
                            case "ObtenerPrestamos":
                                //Deserializa el mensaje para obtener el identificador de cliente y obtiene los préstamos asociados.
                                MensajeSocket<int> mensajeObtenerPrestamos = JsonConvert.DeserializeObject<MensajeSocket<int>>(mensaje);

                                //Obtiene los préstamos del cliente especificado y envía la respuesta al cliente.
                                ObtenerPrestamos(mensajeObtenerPrestamos.Entidad, ref servidorStreamWriter);
                                break;
                            default:
                                break;
                        }
                    }
                    catch (IOException)
                    {
                        break;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ocurrió un error en [ComunicacionCliente, Servidor]: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            finally
            {
                try
                {
                    tcCliente.Close();
                }
                catch
                {
                    //Try-Catch Silencioso.
                }

                if (identificadorCliente != null && !desconexionVoluntaria)
                {
                    //Si el cliente cerro el programa sin desconectarse o se perdio la conexión.
                    ActualizarBitacora(identificadorCliente + " se desconectó abruptamente.");
                    ActualizarClientesComectados(identificadorCliente, false);
                    RemoverIdentificacionConectada(identificadorCliente);
                }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Conectar y Desconectar - - - - - - - - - - - - - - - - - - - - - //
        //Método para conectar un cliente.
        private bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                //Verifica si el cliente esta conectado.
                if (EstaIdentificacionConectada(pIdentificadorCliente))
                {
                    ActualizarBitacora(pIdentificadorCliente + " intentó conectarse pero ya está conectado.");
                    return false;
                }

                //Accede a la capa de datos para obtener el cliente por su identificador.
                ClientesDatos clientesDatos = new ClientesDatos();
                ClienteCls cliente = clientesDatos.ObtenerClientePorIdentificador(pIdentificadorCliente);

                //Verifica si el cliente existe y está activo.
                if (cliente != null && cliente.Activo)
                {
                    //Lo agrega como conectado.
                    AgregarIdentificacionConectada(pIdentificadorCliente); 
                    return true;
                }
                else
                {
                    //Actualiza la bitácora indicando que el cliente no pudo conectar porque está inactivo.
                    ActualizarBitacora(pIdentificadorCliente + " no se logró conectar porque está inactivo.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en [Conectar, Servidor]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método para desconectar un cliente.
        private void Desconectar(string pIdentificadorCliente)
        {
            try
            { 
                //Remueve el identificador de la lista de conectados.
                RemoverIdentificacionConectada(pIdentificadorCliente);

                //Actualiza la bitácora indicando que el cliente se ha desconectado.
                ActualizarBitacora(pIdentificadorCliente + " se desconectó.");

                //Actualiza la lista de clientes conectados, marcando al cliente como desconectado.
                ActualizarClientesComectados(pIdentificadorCliente, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en [Descoenctar, Servidor]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Método de Clientes  - - - - - - - - - - - - - - - - - - - - - //
        //Método para verificar si el cliente existe en la base de datos.
        private bool VerificarCliente(string identificacionCliente)
        {
            //Instancia de ClientesDatos para acceder a la base de datos.
            ClientesDatos clientesDatos = new ClientesDatos();

            //Obtiene la lista de clientes desde la base de datos.
            List<ClienteCls> listaClientes = clientesDatos.ObtenerClientes();

            //Recorre la lista de clientes para verificar si existe el cliente con la identificación proporcionada.
            foreach (ClienteCls cliente in listaClientes)
            {
                if (cliente.Identificacion == identificacionCliente)
                {
                    //Si existe retorna true.
                    return true;
                }
            }
            //Si no existe retorna false.
            return false;
        }

        //Método para obtener un cliente específico.
        private void ObtenerCliente(string identificadorCliente, StreamWriter servidorStreamWriter)
        {
            //Instancia de ClientesDatos para acceder a la base de datos.
            ClientesDatos clientesDatos = new ClientesDatos();

            //Obtener el cliente específico desde la base de datos.
            ClienteCls cliente = clientesDatos.ObtenerClientePorIdentificador(identificadorCliente);

            //Enviar la respuesta al ClienteTCP que solicitó el cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(new MensajeSocket<ClienteCls> { Metodo = "ObtenerClienteRespuesta", Entidad = cliente }));
            servidorStreamWriter.Flush();
        }

        // - - - - - - - - - - - - - - - - - - - - - Métodos para Registrar Prestamos - - - - - - - - - - - - - - - - - - - - - //
        //Método para obtener las sucursales.
        private void ObtenerSucursales(ref StreamWriter servidorStreamWriter)
        {
            //Instancia una lista de Sucursales.
            List<SucursalCls> listaSucursales = new List<SucursalCls>();

            //Instancia de ClientesDatos para acceder a la base de datos.
            SucursalDatos clientesDatos = new SucursalDatos();

            //Obtiene las sucursales.
            listaSucursales = clientesDatos.ObtenerSucursales();

            //Enviar la respuesta al ClienteTCP que solicitó el cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaSucursales));
            servidorStreamWriter.Flush();
        }

        //Método para Obtener las Peliculas Asociadas a la Sucursal.
        private void ObtenerPeliculasAsociadas(string pIdSucursal, ref StreamWriter servidorStreamWriter)
        {
            //Instancia de PeliculaxSucursalDatos para acceder a la base de datos.
            PeliculaxSucursalDatos datosPeliculaxSucursal = new PeliculaxSucursalDatos();

            //Conveirte el ID de sucursal a string si es necesario
            string idSucursalStr = pIdSucursal.ToString();

            //Obtiene las películas por sucursal utilizando el ID de la sucursal convertido a string.
            List<PeliculaCls> listaPeliculasAsociadas = datosPeliculaxSucursal.ObtenerPeliculasAsociadaSucursal(idSucursalStr);

            //Enviar la respuesta al ClienteTCP que solicitó el cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaPeliculasAsociadas));
            servidorStreamWriter.Flush();
        }

        //Método para Agregar los Préstamos.
        private async Task<dynamic> AgregarPrestamo(PrestamoCls nuevoPrestamo)
        {
            //Espera a que se libere el semáforo antes de continuar.
            await semaforoPrestamos.WaitAsync();

            try
            {
                //Crea instancias de la lógica y datos de préstamos.
                PrestamoLogica logicaPrestamo = new PrestamoLogica();
                PrestamoDatos datosPrestamo = new PrestamoDatos();

                //Valida si el préstamo es correcto.
                bool esValido = logicaPrestamo.ValidarPrestamos(nuevoPrestamo);
                if (!esValido)
                {
                    //Verifica si el cliente ya tiene un préstamo pendiente para la misma película.
                    if (datosPrestamo.ClienteTienePrestamoPendiente(nuevoPrestamo.Cliente.Id, nuevoPrestamo.Pelicula.Id))
                    {
                        return new { Entidad = false, Mensaje = "El cliente ya tiene un préstamo pendiente de esta película." };
                    }

                    //Verifica si hay inventario disponible para la película solicitada.
                    if (!logicaPrestamo.VerificarInventario(nuevoPrestamo.Sucursal.Id, nuevoPrestamo.Pelicula.Id))
                    {
                        return new { Entidad = false, Mensaje = "No hay inventario disponible para esta película." };
                    }
                }

                //Agrega el nuevo préstamo a la base de datos.
                logicaPrestamo.AgregarPrestamo(nuevoPrestamo);

                //Actualiza la bitácora con la información del préstamo agregado.
                ActualizarBitacora($"El cliente ID {nuevoPrestamo.Cliente.Id} agregó un préstamo.");

                //Retorna un objeto indicando que el préstamo se agregó con éxito.
                return new { Entidad = true, Mensaje = "Préstamo agregado con éxito." };
            }
            catch (Exception ex)
            {
                //En caso de error, retorna un objeto indicando el fallo y el mensaje de la excepción.
                return new { Entidad = false, Mensaje = ex.Message };
            }
            finally
            {
                //Libera el semáforo.
                semaforoPrestamos.Release();
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Métodos para Consultar Prestamos - - - - - - - - - - - - - - - - - - - - - //
        //Método para obtener los préstamos.
        public void ObtenerPrestamos(int idCliente, ref StreamWriter servidorStreamWriter)
        {
            try
            {
                //Instancia de la capa de datos para acceder a los préstamos.
                PrestamoDatos prestamoDatos = new PrestamoDatos();

                //Obtiene la lista de préstamos del cliente especificado.
                List<PrestamoCls> listaPrestamos = prestamoDatos.ObtenerPrestamos(idCliente);

                //Asegúrate de enviar siempre un arreglo, incluso si está vacío.
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaPrestamos));
                servidorStreamWriter.Flush();

                //Registra en la bitácora la consulta exitosa de préstamos por parte del cliente.
                ActualizarBitacora($"El cliente ID {idCliente} consultó sus préstamos.");
            }
            catch (Exception ex)
            {
                //En caso de error, envía un arreglo vacío al cliente y muestra un mensaje de error.
                servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(new List<PrestamoCls>()));
                MessageBox.Show("Ocurrió un error en [ObtenerPréstamo, Servidor]: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Diseños - - - - - - - - - - - - - - - - - - - - - - - - //
        //Diseño del botón Iniciar.
        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            if (btnIniciar.Enabled)
                btnIniciar.BackColor = Color.FromArgb(0, 147, 40);
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            if (!btnIniciar.Enabled)
                btnIniciar.BackColor = Color.FromArgb(0, 147, 40);
            else
                btnIniciar.BackColor = Color.FromArgb(63, 64, 63);
        }

        //Diseño del botón Detener.
        private void btnDetener_MouseEnter(object sender, EventArgs e)
        {
            if (btnDetener.Enabled)
                btnDetener.BackColor = Color.FromArgb(189, 0, 2);
        }

        private void btnDetener_MouseLeave(object sender, EventArgs e)
        {
            if (!btnDetener.Enabled)
                btnDetener.BackColor = Color.FromArgb(189, 0, 2);
            else
                btnDetener.BackColor = Color.FromArgb(63, 64, 63);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - Acción - - - - - - - - - - - - - - - - - - - - - - - - //
        //Acción del botón Iniciar.
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Dirección IP local y puerto para el servidor.
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 15500);

            //Guarda que se inició el servidor.
            servidorIniciado = true;

            //Inicializa el token de cancelación para controlar la cancelación del bucle de escucha de clientes.
            cts = new CancellationTokenSource();

            //Inicia el subproceso para escuchar a los clientes.
            subprocesoEscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
            subprocesoEscuchaClientes.Start();
            subprocesoEscuchaClientes.IsBackground = true;

            //Actualiza el estado del servidor y los botones.
            estado.Text = "Escuchando clientes en (127.0.0.1, 15500)";
            estado.ForeColor = Color.Green;
            btnIniciar.BackColor = Color.FromArgb(0, 147, 40);
            btnDetener.BackColor = Color.FromArgb(63, 64, 63);
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;

            //Registra en la bitácora que el servidor se ha iniciado.
            ActualizarBitacora("Servidor iniciado en (127.0.0.1, 15500)");
        }

        //Acción del botón Detener.
        private void btnDetener_Click(object sender, EventArgs e)
        {
            //Detiene el servidor.
            servidorIniciado = false;

            //Cancela el token de cancelación.
            cts.Cancel();

            //Detiene el listener TCP.
            tcpListener.Stop();

            //Termina el subproceso que escucha a los clientes.
            subprocesoEscuchaClientes.Abort();

            //Actualiza el estado del servidor y los botones.
            estado.Text = "Sin iniciar";
            estado.ForeColor = Color.Red;
            btnDetener.BackColor = Color.FromArgb(189, 0, 2);
            btnIniciar.BackColor = Color.FromArgb(63, 64, 63);
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
            ActualizarBitacora("Servidor detenido.");
        }
    }
}
