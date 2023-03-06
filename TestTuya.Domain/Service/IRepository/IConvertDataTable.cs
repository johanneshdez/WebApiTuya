using System.Data;

namespace TestTuya.Domain.Service.IRepository
{
    public interface IConvertDataTable
    {
        List<T> Convert<T>(DataTable dt);
    }
}
