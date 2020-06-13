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
        private readonly ProductsContext _context;

        public Category(ProductsContext context)
        {
            _context = context;
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
            ViewBag.category = "Поло";
            ViewBag.product = _context.Products.Where(x => x.Category == "Поло").OrderBy(x => x.Id).ToList();
            return View("Main");
        }
        
        [Route("category/tshirts")]
        public IActionResult Tshirts()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Футболки";
            ViewBag.product = _context.Products.Where(x => x.Category == "Футболки").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/sweatshirts")]
        public IActionResult Sweatshirts()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Свитшоты";
            ViewBag.product = _context.Products.Where(x => x.Category == "Свитшоты").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/hoodies")]
        public IActionResult Hoodies()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Худи";
            ViewBag.product = _context.Products.Where(x => x.Category == "Худи").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/shirts")]
        public IActionResult Shirts()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Рубашки";
            ViewBag.product = _context.Products.Where(x => x.Category == "Рубашки").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/hats")]
        public IActionResult Hats()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Шапки";
            ViewBag.product = _context.Products.Where(x => x.Category == "Шапки").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/bags")]
        public IActionResult Bags()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Рюкзаки";
            ViewBag.product = _context.Products.Where(x => x.Category == "Рюкзаки").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/souvenirs")]
        public IActionResult Souvenirs()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Сувениры";
            ViewBag.product = _context.Products.Where(x => x.Category == "Сувениры").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/memes")]
        public IActionResult Memes()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "Memes";
            ViewBag.product = _context.Products.Where(x => x.Category == "Memes").OrderBy(x => x.Id).ToList();
            return View("Main");
        }

        [Route("category/faq")]
        public IActionResult FAQ()
        {
            ViewBag.isCategory = true;
            ViewBag.category = "FAQ";
            return View("Main");
        }
    }
}
