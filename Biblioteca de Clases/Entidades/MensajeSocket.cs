using System;

/*  
 *                      Universidad Estatal a Distancia
 *  Proyecto 2. Desarrollo de la videoteca de la Universidad Estatal a Distancia.
 *  Clase: Mensaje Socket.
 *  Estudiante: Kendall Andrey Calderón Burgos.
 *  Fecha: 5 de julio de 2024.
 *  Segundo Cuatrimestre.
 */

namespace Entidades
{
    //Define una clase genérica serializable para mensajes de socket.
    [Serializable]
    public class MensajeSocket<T>
    {
        //Propiedad para almacenar el nombre del método asociado al mensaje.
        public string Metodo { get; set; }

        //Propiedad para almacenar la entidad asociada al mensaje, de tipo genérico.
        public T Entidad { get; set; }

        //Propiedad para almacenar un mensaje adicional.
        public string Mensaje { get; set; }
    }
}
