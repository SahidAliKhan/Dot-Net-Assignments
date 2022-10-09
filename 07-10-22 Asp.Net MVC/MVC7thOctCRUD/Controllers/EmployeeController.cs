using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperLibrary;
using BusinessLogicLayerLibrary;
using MVC7thOctCRUD.Models;

namespace MVC7thOctCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        Employee_Helper helper = null;
        public EmployeeController()
        {
            helper = new Employee_Helper();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var emplist = helper.ShowEmployeeList();
            List<EmpModel> modelsList = new List<EmpModel>();
            foreach (var item in emplist)
            {
                modelsList.Add(new EmpModel { EmployeeID = item.EmployeeID, FirstName = item.FirstName, LastName = item.LastName,Title = item.Title, BirthDate = item.BirthDate });
            }
            return View(modelsList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var data = helper.SearchEmployee(id);
            EmpModel emp = new EmpModel();
            emp.EmployeeID = id;
            emp.FirstName = data.FirstName;
            emp.LastName = data.LastName;
            emp.Title = data.Title;
            emp.BirthDate = data.BirthDate;
            
            return View(emp);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                Employee_BAL bal = new Employee_BAL();
                bal.EmployeeID = Convert.ToInt32(Request["EmployeeID"]);
                bal.FirstName = Request["FirstName"].ToString();
                bal.LastName = Request["LastName"].ToString();
                bal.Title = Request["Title"].ToString();
                bal.BirthDate = Convert.ToDateTime(Request["BirthDate"]);
                bool ans = helper.AddEmployee(bal);
                if (ans)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.exMsg = ex.Message;
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var emp = helper.SearchEmployee(id);
            EmpModel model = new EmpModel();
            model.EmployeeID = id;
            model.FirstName = emp.FirstName;
            model.LastName = emp.LastName;
            model.Title = emp.Title;
            model.BirthDate = emp.BirthDate;
            return View(model);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var emp = helper.SearchEmployee(id);
                emp.EmployeeID = Convert.ToInt32(Request["EmployeeID"]);
                emp.FirstName = Request["FirstName"].ToString();
                emp.LastName = Request["LastName"].ToString();
                emp.BirthDate = Convert.ToDateTime(Request["BirthDate"]);
                emp.Title = Request["Title"].ToString();
                bool ans = helper.EditEmployee(emp);


                if (ans)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = helper.SearchEmployee(id);
            EmpModel model = new EmpModel();
            model.EmployeeID = id;
            model.FirstName = emp.FirstName;
            model.LastName = emp.LastName;
            model.Title = emp.Title;
            model.BirthDate = emp.BirthDate;
            return View(model);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var dataFound = helper.SearchEmployee(id);
                if (dataFound != null)
                {
                    bool ans = helper.RemvoeEmployee(id);
                    if (ans)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
