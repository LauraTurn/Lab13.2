using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace CoffeeHouse.Models
{
    public class DAL
    {
        public static IDbConnection db;

        //Add CRUD operations.


        //This operation reads all of the categories
        public static List<String> ReadAllCategories()
        {

            return db.Query<String>($"select distinct category from product;").ToList();

            //return db.GetAll<Category>().ToList();
            //return db.Query<Product>($"select distinct category from product order by category").ToList();
        }

        
        //This reads a single cagetory
        public static List<Product> ReadOneCategory(string category)
        {

            return db.Query<Product>($"select category from product where category = '{category}';").ToList();
            //return db.Get<Category>(id);
        }

        //This lists the product in the category
        public static List<Product> ReadProductsInCategory(string category)
        {
            //category = "Coffee";
            List<Product> test = db.Query<Product>($"select * from product where category = '{category}'").ToList();
            //List<Product> AllProducts = db.GetAll<Product>().ToList();
            return test;

            //return db.Query<Product>($"select * from product where category = '{category}';").ToList();
        }
            
    }


}


        ////
        ///List<Product> cats = db.Query<Product>($"select distinct category from product order by category").ToList();
        //return cats;
        /// 
        /// 
        /// Reads all of the products in each category
        //public static List<Product> ReadAllProduct(string category)
        //{
        //    List<Product> cats = db.Query<Product>($"select * from product where category ='{category}' order by product").ToList();
        //    return cats;
        //}

        //public static Product GetSingleProduct(int id)
        //{
        //    return db.Get<Product>(id);
        //}


    

