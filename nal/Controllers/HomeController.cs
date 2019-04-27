using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using nal.Config;

namespace nal.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("/")]
    public class HomeController : Controller
    {

        private readonly IOptions<AppSettings> settings;

        public HomeController(IOptions<AppSettings> settings)
        {
            this.settings = settings;
        }

        // Redirección a proyecto en GitHub
        [HttpGet]
        public IActionResult Get()
        {
            return Redirect(settings.Value.RepoUrl);
        }
    }
}
