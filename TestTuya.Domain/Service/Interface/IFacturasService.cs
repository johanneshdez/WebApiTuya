using TestTuya.Domain.Entities;

namespace TestTuya.Domain.Service.Interface
{
    public interface IFacturasService
    {
        Task<List<Producto>> GetProductos();
        Task<Factura> SetFactura(List<Compra> compras);
    }
}
