using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace usuarios.Areas.Usuario.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<IdentityUser> _userManager;
        public RegisterModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "El email es obligatorio")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string email { get; set; }

            [Required(ErrorMessage = "La contraseña es obligatoria")]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
            public string password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Confirmar contraseña")]
            [Compare("password", ErrorMessage = "El password no hace match")]
            public string confirmPassword { get; set; }

            public string ErrorMessage { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var userList = _userManager.Users.Where(user => user.Email.Equals(Input.email)).ToList();

                if (userList.Count.Equals(0))
                {
                    IdentityUser user = new IdentityUser();
                    user.UserName = Input.email;
                    user.Email = Input.email;

                    var result = await _userManager.CreateAsync(user, Input.password);

                    if (result.Succeeded)
                    {
                        return Page();
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            Input = new InputModel
                            {
                                ErrorMessage = error.Description
                            };
                        }

                        return Page();
                    }

                }
                else
                {
                    Input = new InputModel 
                    {
                        ErrorMessage = $"El {Input.email} ya esta registrado",
                    };
                    // lanza un error a la interdaz ("campo (etiqueta span del campo) ", "mensaje")
                    // ModelState.AddModelError("Input.email", "Se ha generado un error en el servidor");
                }
            }
            // var data = Input; // informacion del form
            // return Page();
            return Page();
        }

    }
}