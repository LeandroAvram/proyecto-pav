namespace Entidades
{
    public class Cathabitacion
    {
        public int id_cat_habitacion { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return nombre;
        }


        public Cathabitacion()
            {
            }
    }
}