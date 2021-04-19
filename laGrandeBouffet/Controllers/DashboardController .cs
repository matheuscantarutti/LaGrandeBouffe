using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using La_Grande_Bouffe.Models;
using Microsoft.AspNetCore.Authorization;

namespace La_Grande_Bouffe.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DashboardController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TermoDeUso()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Section1()
        {
            return View();
        }

        public IActionResult Section2()
        {
            return View();
        }

        public IActionResult Section3()
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
