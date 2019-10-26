
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public int Id_habitacion { get; set; }
        public int nro_habitacion { get; set; }
        public int precio { get; set; }
        public TipoHabitacion tipoHab { get; set; }
        public Cathabitacion catHab { get; set; }
        public Estadohabit estadoHab { get; set; }

    }
}
