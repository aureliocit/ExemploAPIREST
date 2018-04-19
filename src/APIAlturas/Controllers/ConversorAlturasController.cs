using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alturas;

namespace APIAlturas.Controllers
{
    [Route("api/[controller]")]
    public class ConversorAlturasController : Controller
    {
        [HttpGet("PesMetros/{pes}")]
        public Object Get(double pes)
        {
            var conversor = new ConversorAlturas();
            return new {
                alturaPes = pes,
                alturaMetros = conversor.PesParaMetros(pes)
            };
        }
    }
}
