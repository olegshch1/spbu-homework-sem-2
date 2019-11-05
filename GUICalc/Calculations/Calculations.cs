﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculations
    {
        public string operSymbol = "";
        public double result = 0;
        public double operand = 0;

        public double Calculate(double current)
        {
            switch (operSymbol)
            {
                case "+":
                    result = operand + current;
                    break;

                case "-":
                    result = operand - current;
                    break;

                case "*":
                    result = operand * current;
                    break;

                case "/":
                    result = operand / current;
                    break;
                case "=":
                    result = operand;
                    break;
            }
            operand = result;
            return result;
        }
    }
}
