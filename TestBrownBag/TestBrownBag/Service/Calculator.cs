﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBrownBag.Service
{
    public class Calculator
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }
    }
}