namespace Entidades
{
    public class TipoHabitacion
    {
        public int id_tipo_habitacion { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public TipoHabitacion()
        {

        }

        public override string ToString()
        {
            return nombre;
        }
    }
}