using Adoptame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiPrimerApp1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public IActionResult Nosotros()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.message = "Registra una mascota para dar en adopcion";

            return View();
        }
        [HttpPost]
        public IActionResult Privacy(Mascota mascota)
        {
            ViewBag.message = "Gracias por registrar a:" + mascota.Nombre;

            return View();
        }
        public IActionResult Adoptar()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
