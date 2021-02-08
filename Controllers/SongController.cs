using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



//controller for Songs
namespace Assignment2.Controllers
{
    public class SongController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SongController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Method to return Song1 view
        public IActionResult Song1()
        {
            return View();
        }

        //Method to return Song2 view
        public IActionResult Song2()
        {
            return View();
        }

        //Method to return Song3 view
        public IActionResult Song3()
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
