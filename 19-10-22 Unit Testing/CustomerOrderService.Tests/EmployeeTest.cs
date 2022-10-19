using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class EmployeeTest
    {
        [TestCase]
        public void CheckAge()
        {
            Employee e = new Employee();
            e.EmployeeID = 11;
            e.EmployeeName = "Ramy";
            e.Age = 60;
            bool ans = e.IsSenior();
            //Assert.That(ans == true);
            Assert.IsTrue(ans);
        }

        [TestCase(16, ExpectedResult = false)]
        [TestCase(60, ExpectedResult = true)]
        [TestCase(36, ExpectedResult = false)]
        [TestCase(76, ExpectedResult = true)]
        public bool CheckAge(int age)
        {
            Employee e = new Employee();
            e.EmployeeID = 15;
            e.EmployeeName = "Ram";
            e.Age = age;
            bool ans = e.IsSenior();
            //Assert.IsTrue(ans);
            return ans;
        }
    }
}
