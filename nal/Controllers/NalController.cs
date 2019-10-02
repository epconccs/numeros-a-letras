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
        ///  Convierte un número a letra.
        /// </summary>
        /// <param name="num">Número de hasta 16 dígitos y 2 decimales.</param> 
        [HttpGet]
        public ActionResult Get(double num)
        {
            if (!ModelState.IsValid) return BadRequest("No es un número.");

            return Ok(new { letras = NumerosALetras.ConvertirNumerosALetras(num) });
        }
    }
}
