using CoffeeHouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace CoffeeHouse.Controllers
{
    public class HomeController : Controller
    {
        //public static MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=N@te0924");

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
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

        [HttpGet]
        public IActionResult seeform()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult customerresponse(NUser usr)
        //{
        //    if (usr.firstname == null)
        //    {
        //        return Content("You must enter a first name to register!");
        //    }
        //    if (usr.lastname == null)
        //    {
        //        return Content("You must enter a last name to register!");
        //    }
        //    return View(usr);
        //}

        [HttpPost]
        public IActionResult AddInfo(Customer cust)
        {

            Customer.AllInfo.Add(cust);
            return View();
            //return View(cust);
            //return RedirectToAction("AddInfo");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
