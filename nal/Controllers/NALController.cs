using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using nal.Classes;

namespace nal.Controllers
{
    [Route("api/[controller]")]
    public class NalController : Controller
    {
        // GET: api/Nal
        public IEnumerable<string> Get()
        {
            return new string[] { "No es un número." };
        }

        // GET api/Nal/256
        [HttpGet("{num}")]
        public string Get(double num)
        {
            return NumerosALetras.ConvertirNumerosALetras(num.ToString());
        }

        // GET api/NAL?num=256
        [HttpGet]
        public string GetQueryString(double num)
        {
            return NumerosALetras.ConvertirNumerosALetras(num.ToString());
        }
    }
}
