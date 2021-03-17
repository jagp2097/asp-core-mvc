using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace usuarios.Areas.Usuario.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet(string data)
        {
            Message = data;
        }
    }
}