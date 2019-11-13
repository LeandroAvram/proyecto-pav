using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoReserva
    {
        public int id_estado_reserva { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public EstadoReserva()
        {
        }
    }
}
