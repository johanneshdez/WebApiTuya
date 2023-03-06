using TestTuya.Domain.Service.Interface;
using TestTuya.ServicioLogistica.Contracts;

namespace TestTuya.Domain.Service
{
    public class LogisticaService : ILogisticaService
    {
        private readonly ILogisticaAdapter _serviceLogistica;

        public LogisticaService(ILogisticaAdapter serviceLogistica)
        {
            _serviceLogistica = serviceLogistica;
        }

        public async Task<string> GetVerificarPedido(long id_factura)
        {
            var Respuesta = "";
            if (await _serviceLogistica.PedidoEnviado(id_factura) == 1)
                Respuesta = "Se realizó el proceso de pedido enviado de forma correcta!";
            else
                Respuesta = "No se realizó el pedido enviado de forma correcta!";
            return Respuesta;
        }
    }
}
