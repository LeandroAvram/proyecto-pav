using System;

namespace Entidades
{
    public class FiltrosHabitacion
    {
        public DateTime FechaEgreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Categoria { get; set; }
        public int Tipo { get; set; }
    }
}