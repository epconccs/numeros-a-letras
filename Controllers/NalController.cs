using Microsoft.AspNetCore.Mvc;
using nal.Classes;

namespace numeros_a_letras_api.Controllers;

[ApiController]
[Route("[controller]")]
public class NalController : ControllerBase
{
    [HttpGet]
        public ActionResult Get(double num)
        {
            if (!ModelState.IsValid) return BadRequest("No es un número.");

            return Ok(new { letras = NumerosALetras.ConvertirNumerosALetras(num) });
        }
}
