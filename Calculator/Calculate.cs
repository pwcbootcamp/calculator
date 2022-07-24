using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        // First Number
        public double num1 { get; set; }

        // Second number
        public double num2 { get; set; }

        // Addition
        public double add()
        {
            return num1 + num2;
        }

        // Subtraction
        public double subtract()
        {
            return num1 - num2;
        }

        // Multiplication
        public double multiply()
        {
            return num1 * num2;
        }

        // Division
        public double divide()
        {
            return num1 / num2;
        }
    }
}
