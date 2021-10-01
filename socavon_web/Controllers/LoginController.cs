using Microsoft.AspNetCore.Mvc;
using socavon_web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace socavon_web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel User)
        {
            if (!ModelState.IsValid){
                return View();
            }
            return Redirect("");
        }

        public IActionResult LogUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogUp(LogupViewModel userlogup)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index");
        }
    }


}
