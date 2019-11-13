using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        public int Id_reserva { get; set; }
        public TipoReserva id_TipoReser { get; set; }
        public Habitacion id_habitacion { get; set; }
        public Usuario id_usuario { get; set; }
        public EstadoReserva id_estado { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_egreso { get; set; }
        public int cliente { get; set; }

        public int cantPersonas { get; set; }


    }
}
