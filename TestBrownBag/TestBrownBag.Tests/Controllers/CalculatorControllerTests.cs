using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBrownBag.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBrownBag.Controllers.Tests
{
    [TestClass()]
    public class CalculatorControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var controller = new CalculatorController();
            var add = controller.Add(1, 2);
            Assert.AreEqual(add, 3);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var controller = new CalculatorController();
            var add = controller.Substract(5,2);
            Assert.AreEqual(add, 3);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }
    }
}