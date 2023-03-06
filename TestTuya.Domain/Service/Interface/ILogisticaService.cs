namespace TestTuya.Domain.Service.Interface
{
    public interface ILogisticaService
    {
        Task<String> GetVerificarPedido(long id_factura);
    }
}
