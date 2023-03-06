using System.Net;
using System;
using TestTuya.ServicioLogistica.Contracts;

namespace TestTuya.ServicioLogistica.Adapter
{
    public class LogisticaAdapter : ILogisticaAdapter
    {
        public LogisticaAdapter() { }

        public async Task<int> PedidoEnviado(long id_factura)
        {
            WebClient wc = new WebClient();
            string HTMLSource = wc.DownloadString("http://google.com");
            if (HTMLSource != null)
                return 1;
            else
                return 0;

        }
    }
}
