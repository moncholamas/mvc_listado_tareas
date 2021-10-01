using Microsoft.AspNetCore.Mvc;
using socavon_web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace socavon_web.Controllers
{
    public class TareaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nueva()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Nueva(TareaViewModel nuevaTarea)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Modificar()
        {
            return View();
        }

        public IActionResult Borrar()
        {
            return View();
        }
    }
}
