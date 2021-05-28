using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using CoffeeHouse.Models;
using Dapper;

namespace CoffeeHouse.Controllers
{
    public class ProductController : Controller
    {

        //Shows all of the categories
        public IActionResult Index()
        {
            List<String> cats = DAL.ReadAllCategories();
            return View(cats);

        }



        //This method needs to see id in the parameter otherwise the IAction result will be null.
        //This is just how it works.
        public IActionResult Detail(string id)
        {

           
            List<Product> prods = DAL.ReadProductsInCategory(id);
            return View(prods);

        }
    }
}
