using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestTuya.Domain.Entities;
using TestTuya.Domain.Service.Interface;

namespace WebApiTuya.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private readonly IFacturasService _service;

        public FacturasController(
            IFacturasService service
        )
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("ListaProductos")]
        [ProducesResponseType(typeof(List<BindingModel.Producto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> ListaProductos() 
        {
            return Ok( await _service.GetProductos());
        }

        [HttpPost("GenerarFactura")]
        [ProducesResponseType(typeof(BindingModel.Factura), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Ingresarfactura(List<Compra> compras) 
        {
            return Ok( await _service.SetFactura(compras));
        }
    }
}
