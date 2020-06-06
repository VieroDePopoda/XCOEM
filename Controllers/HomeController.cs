using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XCOEM.Models;

namespace XCOEM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult tshirts()
        {
            return View();
        }

        public IActionResult sweatshirts()
        {
            return View();
        }

        public IActionResult faq()
        {
            return View();
        }

        public IActionResult hats()
        {
            return View();
        }

        public IActionResult hoodies()
        {
            return View();
        }

        public IActionResult memes()
        {
            return View();
        }

        public IActionResult polo()
        {
            return View();
        }

        public IActionResult shirts()
        {
            return View();
        }

        public IActionResult souvenirs()
        {
            return View();
        }

        public IActionResult bags()
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
