using MVC6thOctPS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOctPS2.Controllers
{
    public class MemberClassController : Controller
    {
        // GET: MemberClass
        public ActionResult Index()
        {
            List<MemberClass> list = new List<MemberClass>();
            list.Add(new MemberClass { MemberID = 1, MemberName= "Sahid"});
            list.Add(new MemberClass { MemberID = 2, MemberName = "Ramy" });
            list.Add(new MemberClass { MemberID = 3, MemberName = "David" });
            ViewBag.List = list;
            return View();
        }
    }
}