using BusinessLogicLayerLibrary;
using System.Collections.Generic;
using DataAccessLayerLibrary;
namespace HelperLibrary
{
    public class Employee_Helper
    {
        Employee_DAL dal = null;
        public Employee_Helper()
        {
            dal = new Employee_DAL();
        }
        public bool AddEmployee(Employee_BAL employee)
        {
            return dal.InsertEmployee(employee);
        }
        public bool EditEmployee(Employee_BAL employee)
        {
            return dal.UpdateEmployee(employee);
        }
        public bool RemvoeEmployee(int employee_id)
        {
            return dal.DeleteEmployee(employee_id);
        }
        public Employee_BAL SearchEmployee(int empid)
        {
            return dal.FindEmployee(empid);
        }
        public void SearchEmployee(int empid, out Employee_BAL empdata)
        {

            dal.FindEmployee(empid, out empdata);
        }
        public int countEmployees()
        {
            return dal.EmployeeCount();

        }
        public List<Employee_BAL> ShowEmployeeList()
        {
            return dal.EmployeeList();
        }
    }
}
