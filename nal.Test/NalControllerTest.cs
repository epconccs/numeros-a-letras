using Microsoft.AspNetCore.Mvc;
using nal.Controllers;
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
            var resultado = controller.Get(256);

            Assert.IsType<OkObjectResult>(resultado);
        }

    }
}
