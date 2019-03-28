using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using nal.Config;
using nal.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace nal.Test
{
    public class HomeControllerTest
    {        
        readonly HomeController controller;
        readonly AppSettings settings;

        public HomeControllerTest()
        {
            settings = new AppSettings();
            settings.RepoUrl = "https://github.com/epconccs/nal";
            IOptions<AppSettings> options = Options.Create<AppSettings>(settings);
            controller = new HomeController(options);
        }

        [Fact]
        public void Get_Redireccion()
        {
            var respuesta = controller.Get();

            Assert.IsType<RedirectResult>(respuesta);
        }

        [Fact]
        public void Get_Redireccion_Repo()
        {
            var respuesta = controller.Get();

            Assert.Equal(((RedirectResult)respuesta).Url, settings.RepoUrl);
        }

    }
}
