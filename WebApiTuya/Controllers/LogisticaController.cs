using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestTuya.Domain.Service.Interface;

namespace WebApiTuya.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LogisticaController : Controller
    {
        private readonly ILogisticaService _service;

        public LogisticaController(ILogisticaService service)
        {
            _service = service;
        }

        [HttpPost("VerificarPedido")]
        [ProducesResponseType(typeof(String), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> VerificarPedido(long id_factura)
        {
            return Ok(await _service.GetVerificarPedido(id_factura)); ;
        }
    }
}
