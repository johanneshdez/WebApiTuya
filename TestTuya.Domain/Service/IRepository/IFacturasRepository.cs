using TestTuya.Domain.Entities;

namespace TestTuya.Domain.Service.IRepository
{
    public interface IFacturasRepository
    {
        Task<List<Producto>> GetAll();
        Task<bool> SetCompra(Compra compra);
        long SiguienteFactura();
        void deleteError(long id_factura);
    }
}
