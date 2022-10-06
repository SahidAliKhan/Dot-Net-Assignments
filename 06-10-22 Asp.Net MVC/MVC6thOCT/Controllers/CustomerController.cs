using MVC6thOCT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6thOCT.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static List<CustModel> custList = new List<CustModel>();
        static CustomerController()
        {
            custList.Add(new CustModel { Custid = 1, Custname = "Ajay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });

            custList.Add(new CustModel { Custid = 2, Custname = "Vijay", City = "Pune", RegistrationDate = new DateTime(2022, 04, 05) });
            custList.Add(new CustModel { Custid = 3, Custname = "Sujay", City = "Pune", RegistrationDate = new DateTime(2022, 01, 04) });

        }
        public ActionResult Index()
        {
            return View(custList);
        }
        public ActionResult Details(int id)
        {
            CustModel foundData = custList.Find(customer => customer.Custid == id);
            return View(foundData);
        }
        public ActionResult AddOrderDetails(int id)
        {
            CustModel foundData = custList.Find(customer => customer.Custid == id);
            return RedirectToAction("NowEditOrderDetails", new { id = foundData.Custid });
        }


        public ActionResult Delete(int id)
        {
            CustModel foundData = custList.Find(customer => customer.Custid == id);
            return View(foundData);
        }

        [HttpPost]
        public ActionResult Delete(int id, CustModel cust)
        {
            CustModel foundData = custList.Find(customer => customer.Custid == id);
            custList.Remove(foundData);
            return View(foundData);
        }
        public ActionResult NowEditOrderDetails(int id)
        {
            CustModel foundData = custList.Find(customer => customer.Custid == id);


            return View(foundData);
        }

        [HttpPost]

        public ActionResult NowEditOrderDetails(int id, CustModel m)
        {
            CustModel foundData = custList.Find(customer => customer.Custid == id);
            custList.Remove(foundData);
            custList.Add(m);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(CustModel model)
        {
            custList.Add(model);
            return RedirectToAction("Index");
        }



    }
}