namespace TestTuya.Domain.Entities
{
    public class Factura
    {
        public string Estado { get; set; }
        public long IDFactura { get; set; }
        public int CantidadProductos { get; set; }
        public decimal ValorNeto { get; set; }
    }
}
