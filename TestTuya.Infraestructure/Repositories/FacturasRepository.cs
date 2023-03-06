using System.Data;
using TestTuya.Domain.Entities;
using TestTuya.Domain.Service.IRepository;
using WebApiTuya.Recursos;

namespace TestTuya.Domain.Service.Repository
{
    public class FacturasRepository : IFacturasRepository
    {
        private readonly IConvertDataTable _convert;
        public FacturasRepository(IConvertDataTable convertDataTable) 
        {
            _convert = convertDataTable;
        }

        public void deleteError(long id_factura)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@id_factura",id_factura.ToString())
            };
            DataBase.Ejecutar("eliminar_error_compra", parametros);
        }

        public async Task<List<Producto>> GetAll()
        {
            DataTable dt = DataBase.Listar("[lista_producto]");
            return _convert.Convert<Producto>(dt);
        }

        public async Task<bool> SetCompra(Compra compra)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@id_producto",compra.Id_producto.ToString()),
                new Parametro("@cantidad",compra.Cantidad.ToString()),
                new Parametro("@valor",compra.Valor.ToString()),
                new Parametro("@id_factura",compra.Id_factura.ToString())
            };
            return DataBase.Ejecutar("insertar_compra", parametros);
        }

        public long SiguienteFactura()
        {
            DataTable dt = DataBase.Listar("[traer_siguiente_factura]");
            return long.Parse(dt.Rows[0]["siguiente"].ToString());
        }
    }
}
