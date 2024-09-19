using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDeDatos;
using Entidades;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Opción: Consulta de Préstamos.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 7 de Julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace ClienteTCP
{
    public partial class ConsultarPrestamos : Form
    {
        //Variables.
        private int idCliente;

        //Constructor
        public ConsultarPrestamos(int idCliente)
        {
            InitializeComponent();

            //Guarda el ID obtenido de menú.
            this.idCliente = idCliente;

            //Carga los Prestamos.
            CargarPrestamos();
        }

        //Método para cargar los prestamos en el DataGridView.
        private void CargarPrestamos()
        {
            try
            {
                //Obtiene los prestamos asociados a la ID del Cliente.
                List<PrestamoCls> listaPrestamos = ClienteTCPDatos.ObtenerPrestamos(idCliente);

                //Limpiar el DataGridView.
                dataPrestamos.Rows.Clear();

                //Itera en la lista de prestamos y los añade al DataGridView
                foreach (var prestamo in listaPrestamos)
                {
                    dataPrestamos.Rows.Add(
                        prestamo.IdPrestamo,
                        prestamo.FechaPrestamo,
                        prestamo.PendienteDevolucion ? "Si" : "No", 
                        prestamo.Pelicula.Id,
                        prestamo.Pelicula.Titulo,
                        prestamo.Pelicula.Categoria.Categoria,
                        prestamo.Pelicula.Anio,
                        prestamo.Pelicula.Idioma,
                        prestamo.Sucursal.Id,
                        prestamo.Sucursal.Nombre
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
