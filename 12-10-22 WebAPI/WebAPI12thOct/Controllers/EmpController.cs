using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI12thOct.Models;
using BusinessLogicLayerLibrary;
using HelperLibrary;

namespace WebAPI12thOct.Controllers
{
    public class EmpController : ApiController
    {
        // GET api/<controller>
        Employee_Helper helper = null;
        public EmpController()
        {
            helper = new Employee_Helper();
        }
        //[Route("EmployeeDetails")]
        public List<EmpModel> GetEmpList()
        {
            List<Employee_BAL> empbal = new List<Employee_BAL>();
            empbal = helper.ShowEmployeeList();
            List<EmpModel> emps = new List<EmpModel>();
            foreach (var item in empbal)
            {
                //Employees emp = new Employees();
                emps.Add(new EmpModel
                {
                    EmployeeID = item.EmployeeID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BirthDate = item.BirthDate,
                    Title = item.Title
                });
            }
            return emps;
        }

        // GET api/<controller>/5
        //[Route("EmployeeDetailsByID/{id}")]
        public EmpModel GetEmpListByID(int id)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal = helper.SearchEmployee(id);
            EmpModel emp = new EmpModel();
            emp.EmployeeID = empbal.EmployeeID;
            emp.FirstName = empbal.FirstName;
            emp.LastName = empbal.LastName;
            emp.Title = empbal.Title;
            emp.BirthDate = empbal.BirthDate;
            return emp;
        }

        // POST api/<controller>
        //[Route("AddEmployee")]
        public HttpResponseMessage Post([FromBody] EmpModel empdata)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal.EmployeeID = empdata.EmployeeID;
            empbal.FirstName = empdata.FirstName;
            empbal.LastName = empdata.LastName;
            empbal.Title = empdata.Title;
            empbal.BirthDate = empdata.BirthDate;


            bool ans = helper.AddEmployee(empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // PUT api/<controller>/5
        //[Route("UpdateEmployee")]
        public HttpResponseMessage Put(int id, [FromBody] EmpModel empdata)
        {
            Employee_BAL empbal = new Employee_BAL();
            empbal.EmployeeID = empdata.EmployeeID;
            empbal.FirstName = empdata.FirstName;
            empbal.LastName = empdata.LastName;
            empbal.Title = empdata.Title;
            empbal.BirthDate = empdata.BirthDate;

            bool ans = helper.EditEmployee( empbal);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE api/<controller>/5
        //[Route("DeleteEmployee")]
        public HttpResponseMessage Delete(int id)
        {
            bool ans = helper.RemvoeEmployee(id);
            if (ans)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
    }
}