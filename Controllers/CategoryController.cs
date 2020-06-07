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
    public class Category : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Category(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Main()
        {
            ViewBag.isCategory = false;
            return View();
        }

        [Route("Category/Polo")]
        public IActionResult Polo()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }
        
        [Route("category/tshirts")]
        public IActionResult Tshirts()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/sweatshirts")]
        public IActionResult Sweatshirts()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/hoodies")]
        public IActionResult Hoodies()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/shirts")]
        public IActionResult Shirts()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/hats")]
        public IActionResult Hats()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/bags")]
        public IActionResult Bags()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/souvenirs")]
        public IActionResult Souvenirs()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/memes")]
        public IActionResult Memes()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }

        [Route("category/faq")]
        public IActionResult FAQ()
        {
            ViewBag.isCategory = true;
            return View("Main");
        }
    }
}
