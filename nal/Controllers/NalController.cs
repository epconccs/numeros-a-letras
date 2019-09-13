using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using nal.Classes;

namespace nal.Controllers
{
    [Route("api/[controller]")]
    public class NalController : Controller
    {
        // GET api/NAL?num=256
        [HttpGet]
        public ActionResult Get(double num)
        {
            if (!ModelState.IsValid) return BadRequest("No es un número.");

            return Ok(new { letras = NumerosALetras.ConvertirNumerosALetras(num) });
        }
    }
}
