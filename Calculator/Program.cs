using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Flag to exit program
            bool exit = false;

            // Reference object to the class - Calculate
            Calculate val = new Calculate();


            Console.WriteLine("\nWelcome To Calculator Program");

            while (!exit)
            {
                try
                {
                    Console.WriteLine("\nEnter '+' or '1' for Addition");
                    Console.WriteLine("Enter '-' or '2' for Subtraction");
                    Console.WriteLine("Enter '*' or '3' for Multiplication");
                    Console.WriteLine("Enter '/' or '4' for Division");
                    Console.WriteLine("Enter 'C' or 'c' to Clear Screen");
                    Console.WriteLine("Enter 'E' or 'e' to exit Calculator");

                    // Take user input and convert to character
                    Console.Write("\nWhat do you want to do: ");
                    char read = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();

                    // Check the user input
                    if (read == '+' || read == '1')
                    {
                        Console.WriteLine("Addition");
                        Console.Write("Enter first number: ");
                        val.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Enter second number: ");
                        val.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\nAnswer: {val.add()}");
                    }
                    else if (read == '-' || read == '2')
                    {
                        Console.WriteLine("Subtraction");
                        Console.Write("Enter first number: ");
                        val.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Enter second number: ");
                        val.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\nAnswer: {val.subtract()}");
                    }
                    else if (read == '*' || read == '3')
                    {
                        Console.WriteLine("Multiplication");
                        Console.Write("Enter first number: ");
                        val.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Enter second number: ");
                        val.num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\nAnswer: {val.multiply()}");
                    }
                    else if (read == '/' || read == '4')
                    {
                        Console.WriteLine("Division");
                        Console.Write("Enter first number: ");
                        val.num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Enter second number: ");
                        val.num2 = Convert.ToDouble(Console.ReadLine());

                        // Check for divide by zero (0) situation
                        if (val.num2 == 0.0)
                        {
                            // Display error message
                            Console.WriteLine("\nMath Error: Cannot divide by zero");
                        }
                        else
                        {
                            Console.WriteLine($"\nAnswer: {val.divide()}");
                        }
                    }
                    else if (read == 'C' || read == 'c')
                    {
                        Console.Clear();
                    }
                    else if (read == 'E' || read == 'e')
                    {
                        Console.WriteLine("Exiting Calculator........");
                        // Put exit to be true
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");

                }
            }
        }
    }
}
