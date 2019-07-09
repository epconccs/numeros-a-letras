using Microsoft.AspNetCore.Mvc;
using nal.Controllers;
using Newtonsoft.Json;
using Xunit;

namespace nal.Test
{
    public class NalControllerTest
    {

        readonly NalController controller;

        public NalControllerTest()
        {
            controller = new NalController();
        }

        [Fact]
        public void Get_RespuestaOk()
        {
            var respuesta = controller.Get(256);

            Assert.IsType<OkObjectResult>(respuesta);
        }

        [Fact]
        public void Get_Numero_RespuestaLetra()
        {
            var numeroPrueba = new { letras = "DOSCIENTOS CINCUENTA Y SEIS" };

            var respuesta = controller.Get(256) as OkObjectResult;
            
            Assert.Equal(JsonConvert.SerializeObject(numeroPrueba), JsonConvert.SerializeObject(respuesta.Value));
        }

        [Fact]
        public void Get_Numero_RespuestaFueraDeRango()
        {
            var fueraDeRango = new { letras = "Número fuera de rango." };

            var respuesta = controller.Get(12345678901234567) as OkObjectResult;
            
            Assert.Equal(JsonConvert.SerializeObject(fueraDeRango), JsonConvert.SerializeObject(respuesta.Value));
        }

        [Fact]
        public void GetQuery_RespuestaOk()
        {
            var respuesta = controller.GetQuery(256);

            Assert.IsType<OkObjectResult>(respuesta);
        }

        [Fact]
        public void GetQuery_Numero_RespuestaLetra()
        {
            var numeroPrueba = new { letras = "DOSCIENTOS CINCUENTA Y SEIS" };

            var respuesta = controller.GetQuery(256) as OkObjectResult;

            Assert.Equal(JsonConvert.SerializeObject(numeroPrueba), JsonConvert.SerializeObject(respuesta.Value));
        }

    }
}
