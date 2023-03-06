using TestTuya.Domain.Entities;
using TestTuya.Domain.Service.Interface;
using TestTuya.Domain.Service.IRepository;

namespace TestTuya.Domain.Service
{
    public class FacturasService : IFacturasService
    {
        private readonly IFacturasRepository _repository;
        public FacturasService( IFacturasRepository repository) 
        {
            _repository = repository;
        }

        public async Task<List<Producto>> GetProductos()
        {
            return await _repository.GetAll();
        }

        public async Task<Factura> SetFactura(List<Compra> compras)
        {
            var asignaIdFactura = _repository.SiguienteFactura();
            bool respuesta = true;
            foreach (var compra in compras)
            {
                compra.Id_factura = asignaIdFactura;
                respuesta = await _repository.SetCompra(compra);
                if(!respuesta) { break; }
            }
            var estado = "";
            if (respuesta) 
            {
                estado = "Factura Generada!";
            }
            else
            {
                estado = "Error en Factura!";
                _repository.deleteError(asignaIdFactura);
            }
            var valorNeto = compras.Sum(x => x.Valor);
            var CantidadFactura = compras.Sum(x => x.Cantidad);
            return new Factura() 
            { 
                Estado = estado,
                IDFactura = asignaIdFactura,
                CantidadProductos = CantidadFactura,
                ValorNeto = valorNeto
            };
        }
    }
}
