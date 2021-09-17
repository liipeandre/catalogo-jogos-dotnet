using System.ComponentModel;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoJogos.Controllers
{
    [ApiController]
    [Route("/")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Main()
        {
            return View("~/views/main.cshtml");
        }
    }
}