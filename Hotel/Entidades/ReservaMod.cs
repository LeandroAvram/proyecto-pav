using System;

namespace Entidades
{
    public class ReservaMod
    {
        public int id_tipo_reserva { get; set;}
        public int id_habitacion { get; set;}
        public int id_usuario { get; set;}
        public int id_cliente { get; set;}
        public int id_estado_reserva { get; set;}
        public DateTime fecha_ingreso { get; set;}
        public DateTime fecha_egreso { get; set;}
        public int cant_persona { get; set;}
    }
}