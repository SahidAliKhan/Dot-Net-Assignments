using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingPS.Tests
{
    [TestFixture]
    public class SetUp_TearDown_Test
    {
        int s;
        //compulsory/first in the sequence
        [SetUp]
        [Test]
        public void Add()
        {
            int x = 10;
            int y = 20;
            s = x+y;
            Console.WriteLine(s);
            Assert.AreEqual(s, 30);
        }
        [Test]
        public void subtract()
        {
            int p = s - 10;
            Console.WriteLine(p);
            Assert.AreEqual(p, 20);
        }
        [Test]
        [TearDown]
        //Last in the sequence of execution
        public void Multiply()
        {
            int x = 100;
            int y = 20;
            int result = x * y;
            Console.WriteLine(result);
            Assert.AreEqual(result, 2000);
        }
    } 
}
