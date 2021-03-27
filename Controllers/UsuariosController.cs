using Microsoft.AspNetCore.Mvc;

namespace usuarios.Controllers 
{
    // [Route("/Users")] // cambia la ruta del controller : Usuarios/ -> Users/
    // [Route("[controller]/[action]")]
    public class UsuariosController : Controller 
    {
        // [HttpGet]
        // [Route("/Name/Oso")] // especifica una ruta personalizada para esta accion
        // [Route("/Name/Chita/{data}")] // especifica una ruta personalizada para esta accion
        // [Route("[controller]/[action]/{data}")]
        // [HttpGet("[controller]/[action]/{name}/{age:int}")]
        public IActionResult Index(string name, int age)
        {
            // var url = Url.Action("Action", "Controller");
            // var url = Url.Action("MetodoRedirect", "Usuarios");
            var url = Url.RouteUrl("Redirect", new { name = "Isabel", age = 24 });

            // ViewData["id"] = $"{data} - {age}";
            // string datos = $"{name} - {age}";
            // return View("Index", datos);

            // return Content(url);
            return Redirect(url);
        }

        // Action Index sobrecargado
        // public IActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet("[controller]/[action]", Name = "Redirect")]
        public IActionResult MetodoRedirect(string name, int age)
        {
            string data = $"Name: {name}, Age: {age}";

            return View("Index", data);
        }

        public string ErrorPage(int code)
        {
            return $"Error {code}";
        }

    }

}
