using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCRUDApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About ASP.NET Snippets:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Us:";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
