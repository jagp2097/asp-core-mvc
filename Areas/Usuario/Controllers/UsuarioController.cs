using Microsoft.AspNetCore.Mvc;

namespace usuarios.Areas.Usuario.Controllers 
{
    [Area("Usuario")]
    public class UsuarioController : Controller
    {
        public IActionResult Usuarios()
        {
            return View();
        }
    }
}