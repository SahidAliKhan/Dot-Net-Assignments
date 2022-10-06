using MVC6thOctPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOctPS.Controllers
{
    public class ProductController : Controller
    {
        static List<ProductModel> prodlist = new List<ProductModel>();
        static ProductController()
        {
            prodlist.Add(new ProductModel { Prodid = 1, ProdName = "ParleG", MfgDate = new DateTime(2021,10,06)});
            prodlist.Add(new ProductModel { Prodid = 2, ProdName = "0reo", MfgDate = new DateTime(2022, 08, 17) });
            prodlist.Add(new ProductModel { Prodid = 3, ProdName = "Butter", MfgDate = new DateTime(2021, 12, 22) });
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(prodlist);
        }
        public ActionResult SearchProduct(int id)
        {
            ProductModel foundData = prodlist.Find(product=>product.Prodid == id);
            return View(foundData);
        }
    }
}