using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTuya.ServicioLogistica.Contracts
{
    public interface ILogisticaAdapter
    {
        Task<int> PedidoEnviado(long id_factura);
    }
}
