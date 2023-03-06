namespace WebApiTuya.BindingModel
{
    public class Producto
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public long Disponible { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
    }
}
