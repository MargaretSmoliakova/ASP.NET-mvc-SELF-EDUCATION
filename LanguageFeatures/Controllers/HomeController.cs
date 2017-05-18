using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            //create a new Product object
            Product myProduct = new Product();

            //set the property value
            myProduct.Name = "Margo";

            //get the property
            string productName = myProduct.Name;

            //generate the view
            return View("Result", (object)String.Format("Product name: {0}", productName));
        }

        public ViewResult CreateProduct()
        {
            //// create a new Product object
            //Product myProduct = new Product();

            ////set the property values
            //myProduct.ProductID = 100;
            //myProduct.Name = "Margo :)";
            //myProduct.Description = "a boat for one person";
            //myProduct.Price = 275M;
            //myProduct.Category = "Watersports";

            //return View("Result", (object)String.Format("Category: {0}", myProduct.Category));

            // create and populate a new Product object
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Margo",
                Description = "blablabla",
                Price = 275M,
                Category = "Watersport"
            };

            return View("Result", (object)String.Format("Category: {0}", myProduct.Category));

        }

        public ViewResult UseExtension()
        {
            //create and populate ShoppingCart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product { Name = "MiMiMiMI", Price = 275M},
                    new Product { Name = "Lifejacket", Price = 1000M}
                }
            };

            // get the total value of the products in the cart
            decimal cartTotal = cart.TotalPrices();

            return View("Result", (object)String.Format("Total: {0:c}", cartTotal));
        }
    }
}