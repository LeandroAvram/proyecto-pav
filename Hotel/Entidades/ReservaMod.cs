namespace Entidades
{
    public class ReservaMod
    {
        public int id_estado_habitacion { get; set;}
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}