using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<True_Dive_Deep.Models.Account> _signInManager;

        public LoginModel(SignInManager<True_Dive_Deep.Models.Account> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string? Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string? Password { get; set; }
            public bool RememberMe { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "forkert kode.");
                }
            }
            return Page();
        }
    }
}