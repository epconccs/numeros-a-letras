using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using nal.Classes;

namespace nal.Controllers
{
    [Route("api/[controller]")]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public class NalController : Controller
    {        
        /// <summary>
        ///  Convierte un número de hasta 16 dígitos a letra.
        /// </summary>
        [HttpGet]
        public ActionResult Get(double num)
        {
            if (!ModelState.IsValid) return BadRequest("No es un número.");

            return Ok(new { letras = NumerosALetras.ConvertirNumerosALetras(num) });
        }
    }
}
