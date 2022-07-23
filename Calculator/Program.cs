using System;

class Program
{
    public static void Main(string[] args)
    {
        //Call calculator Method
        Calculator();

        //Calculator Method; uses add, subtract, divide and multiply methods, all defined below
        static void Calculator()
        {
            Console.WriteLine("What operation would you like to perform? (add, subtract, multiply, divide)");
            var operation = Console.ReadLine();
            Console.WriteLine("Enter first number:");
            var num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var num2 = float.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Console.WriteLine(Add(num1, num2));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(num1, num2));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(num1, num2));
                    break;
                case "divide":
                    Console.WriteLine(Divide(num1, num2));
                    break;
                default:
                    Console.WriteLine("Please Enter a valid operation");
                    break;
            }

            Console.WriteLine("Do you want to perform another operation? (y/n)");
            var again = Console.ReadLine();
            if (again == "y")
                Calculator();

        }

        //Addition method
        static string Add(float a, float b)
        {
            var answer = a + b;
            return a.ToString() + " + " + b.ToString() + " = " + answer.ToString();
        }

        //Subtraction Method
        static string Subtract(float a, float b)
        {
            var answer = a - b;
            return a.ToString() + " - " + b.ToString() + " = " + answer.ToString();
        }

        //Multiplication Method
        static string Multiply(float a, float b)
        {
            var answer = a * b;
            return a.ToString() + " * " + b.ToString() + " = " + answer.ToString();
        }

        //Division Method
        static string Divide(float a, float b)
        {
            var answer = a / b;
            return a.ToString() + " / " + b.ToString() + " = " + answer.ToString();
        }
    }
}
