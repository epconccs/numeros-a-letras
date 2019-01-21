using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nal.Classes;

namespace nal.Controllers
{
    [Route("api/[controller]")]
    public class NALController : Controller
    {
        // GET: api/NAL
        public IEnumerable<string> Get()
        {
            return new string[] { "No es un número." };
        }

        // GET api/NAL/256
        [HttpGet("{num}")]
        public string Get(double num)
        {
            return ClsNumerosALetras.ConvertirNumerosALetras(num.ToString());
        }
    }
}
