using MVC6thOctPS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOctPS2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<BookClass> list = new List<BookClass>();
            list.Add(new BookClass { BookID = 1, BookName = "Java" });
            list.Add(new BookClass { BookID = 2, BookName = "C#" });
            list.Add(new BookClass { BookID = 3, BookName = "Python" });
            ViewData["List"] = list;
            return View();
        }
    }
}