using System;
//using pwcProject1;

namespace SimpleCalculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("my First C# program");
            Console.ResetColor();

            bool calculate = true;

            while (calculate)
            {
                Calculator();
                Console.WriteLine("do you want to perform another operation? [Y] or [N]");
                string input = Console.ReadLine();

                if (input == "Y")
                {
                    calculate = true;
                }
                else
                {
                    calculate = false;
                }
            }


        }

        static void Calculator()
        {
            Console.WriteLine("my calculator: enter two numbers and perform an action");
            Console.WriteLine("enter a number");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter an operator [+ , - , / or *]");
            string op = Console.ReadLine();
            Console.WriteLine("enter another number");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            if (op == "+")
            {
                decimal answer = num1 + num2;
                Console.WriteLine("The answer is {0}", answer);
            }
            else if (op == "-")
            {
                decimal answer = num1 - num2;
                Console.WriteLine("The answer is {0}", answer);
            }
            else if (op == "*")
            {
                decimal answer = num1 * num2;
                Console.WriteLine("The answer is {0}", answer);
            }
            else if (op == "/")
            {
                decimal answer = num1 / num2;
                Console.WriteLine("The answer is {0}", answer);
            }
            else
            {
                Console.WriteLine("enter a valid operator");
            }
        }
    }
}
