namespace WebApiTuya.BindingModel
{
    public class Compra
    {
        public long Id {  get; set; }
        public int Id_producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Valor { get; set; }
        public long? Id_factura { get; set; }
    }
}
