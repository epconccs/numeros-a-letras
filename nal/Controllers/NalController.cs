using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using nal.Classes;

namespace nal.Controllers
{
    [Route("api/[controller]")]
    public class NalController : Controller
    {
        // GET api/Nal/256
        [HttpGet("{num}")]
        public ActionResult Get(string num)
        {
            return Ok(new { letras = NumerosALetras.ConvertirNumerosALetras(num) });
        }

        // GET api/NAL?num=256
        [HttpGet]
        public ActionResult GetQuery(string num)
        {
            return Ok(new { letras = NumerosALetras.ConvertirNumerosALetras(num) });
        }
    }
}
