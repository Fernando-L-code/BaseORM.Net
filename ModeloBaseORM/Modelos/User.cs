namespace Kiosko_Facturacion.Modelos
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
