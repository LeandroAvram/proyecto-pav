namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Estado { get; set; }
    }
}