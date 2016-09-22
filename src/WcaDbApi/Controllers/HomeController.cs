using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WcaDbApi.Models;

namespace WcaDbApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly WCADBContext _context;
        public HomeController(WCADBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var comp = (_context.Competitions.Take(10).FirstOrDefault());
            return View(comp);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
