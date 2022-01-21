using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Context;
using System.Linq;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppWebContext _context;

        public HomeController(AppWebContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var p = _context.Clientes.ToList();
            return View(p);
        }

        public IActionResult Privacy()
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
