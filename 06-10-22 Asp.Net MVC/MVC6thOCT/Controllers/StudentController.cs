using MVC6thOCT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOCT.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<string> strs = new List<string>();
            ViewBag.msg = "Hi There";
            strs.Add("Hello");
            strs.Add("Welcome");
            strs.Add("Greetings!!");
            strs.Add("Good morning");
            ViewBag.msg = "Here is the list of students";
            ViewBag.strList = strs;
            List<CustModel> custList = new List<CustModel>();
            custList.Add(new CustModel { Custid = 1, Custname = "Ajay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });

            custList.Add(new CustModel { Custid = 2, Custname = "Vijay", City = "Pune", RegistrationDate = new DateTime(2022, 04, 05) });
            custList.Add(new CustModel { Custid = 3, Custname = "Sujay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });
            ViewBag.customers = custList;


            return View();
        }
        public ActionResult RegisteredStudents()
        {
            List<CustModel> custList = new List<CustModel>();
            custList.Add(new CustModel { Custid = 1, Custname = "Ajay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });

            custList.Add(new CustModel { Custid = 2, Custname = "Vijay", City = "Pune", RegistrationDate = new DateTime(2022, 04, 05) });
            custList.Add(new CustModel { Custid = 3, Custname = "Sujay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });
            ViewData["mycustList"] = custList;

            return View();
        }

        public ActionResult PassData()
        {
            List<CustModel> custList = new List<CustModel>();
            custList.Add(new CustModel { Custid = 1, Custname = "Ajay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });

            custList.Add(new CustModel { Custid = 2, Custname = "Vijay", City = "Pune", RegistrationDate = new DateTime(2022, 04, 05) });
            custList.Add(new CustModel { Custid = 3, Custname = "Sujay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });
            TempData["mycustdata"] = custList;
            return RedirectToAction("GetList");
        }
        static List<StudModel> list = new List<StudModel>();

        static StudentController()
        {

        }
        public ActionResult CreateStudent()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(StudModel model)
        {
            list.Add(model);

            return View();
        }




        public ActionResult GetList()
        {
            //ViewBag.mybag = TempData["mycustdata"];
            TempData["mybag"] = TempData["mycustdata"];

            return View();
        }
    }
}