using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPruebaTecMonolegal.Models;
using ApiPruebaTecMonolegal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebaTecMonolegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        public FacturaService _facturaService;

        public FacturaController(FacturaService facturaService)
        {
            _facturaService = facturaService;
        }

        [HttpGet]
        public ActionResult<List<Factura>> Get()
        {
            return _facturaService.Get();
        }

        [HttpPut]
        public ActionResult Update(Factura factura)
        {
            _facturaService.Update(factura.Id, factura);
            return Ok();
        }
    }
}
