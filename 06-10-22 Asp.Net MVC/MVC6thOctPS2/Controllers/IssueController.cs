using MVC6thOctPS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOctPS2.Controllers
{
    public class IssueController : Controller
    {
        // GET: Issue
        public ActionResult Index()
        {
            List<IssueClass> list = new List<IssueClass>();
            list.Add(new IssueClass { IssueID = 1, IssuedBookName = "Java" });
            list.Add(new IssueClass { IssueID = 2, IssuedBookName = "C#" });
            list.Add(new IssueClass { IssueID = 3, IssuedBookName = "Python" });
            TempData["List"] = list;
            return View();
        }
    }
}