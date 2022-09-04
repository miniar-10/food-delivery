using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bon_appetit.Controllers
{
    public class UserAuthentificationController : Controller
    {
        public UserAuthentificationController()
        {

        }
        public IActionResult Loginn()
        {
            return View();
        }
    }
}
