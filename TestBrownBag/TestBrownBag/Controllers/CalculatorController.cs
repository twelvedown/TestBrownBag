using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestBrownBag.Service;

namespace TestBrownBag.Controllers
{
    public class CalculatorController : ApiController
    {

        [HttpGet]
        public int Add(int value1, int value2)
        {
            var calculator = new Calculator();
            calculator.FirstNumber = value1;
            calculator.SecondNumber = value2;
            return calculator.Add();
        }

        [HttpGet]
        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        [HttpGet]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        [HttpGet]
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }


        [HttpGet]
        public string Get()
        {
            return "default";
        }

    }
}
