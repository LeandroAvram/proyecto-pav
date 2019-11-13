using System;

namespace Entidades
{
    public class ReservaDatos
    {
        public int id_reserva { get; set;}
        public int nro_habitacion { get; set;}
        public string nombreCompleto { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public string estadoReserva { get; set; }
        public int cantPersonas { get; set; }
        public decimal monto { get; set; }
    }
}