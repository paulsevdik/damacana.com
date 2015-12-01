using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using damacana.com.Models;

namespace damacana.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index()
        {
           Product product1= new Product(){
               
             id = 1,
             Name = "Erikli 19L",
             Price = (decimal)4.90
           };
           Product product2 = new Product()
           {
               
             id = 1,
             Name = "pinar 19L",
             Price = (decimal)5.90
           };
           List<Product> products = new List<Product>();
           products.Add(product1);
           products.Add(product2);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}