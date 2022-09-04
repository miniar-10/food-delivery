using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Bon_appetit.Views.UserAuthentification
{
    public class SignUpModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]

        [EmailAddress]
        public string EMail { get; set; }
        [BindProperty]

        public string Msg { get; set; }
        [BindProperty]

        public string Adress { get; set; }
        [BindProperty]

        public double PhoneNumber { get; set; }
        public void OnGet()
        {
        }

        //    public IActionResult OnPost()
        //    {
        //        if (Username.Equals("abc") && Password.Equals("123"))
        //        {
        //            HttpContext.Session.SetString("username", Username);
        //            return RedirectToPage("Welcome");
        //        }
        //        else
        //        {
        //            Msg = "Invalid";
        //            return Page();
        //        }
        //    }
        //}
    }
}