using Microsoft.AspNetCore.Mvc;
using System;

namespace SistemaWebMisRecetas1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Sistema de recetas.";

  

            return View();

        }
    }
}
