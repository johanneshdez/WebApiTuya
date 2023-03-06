using System.Data;
using WebApiTuya.Recursos;

namespace TestTuya.Domain.Service.IRepository
{
    public interface IDataBase
    {
        DataSet ListarTablas(string nombreProcedimiento, List<Parametro>? parametros = null);
        DataTable Listar(string nombreProcedimiento, List<Parametro>? parametros = null);
        bool Ejecutar(string nombreProcedimiento, List<Parametro>? parametros = null);
    }
}
