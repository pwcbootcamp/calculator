using System;

namespace CalculatorApp
{
    class Program
    {
        static void want()
        {
            Console.WriteLine("Do you want to try again\ntype 1) Yes  2) No");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l == 1)
            {
                calc();
            }
            else
            {
                Console.Clear();
            }

        }
        static void add()
        {
            Console.WriteLine("enter first number\n");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter first number\n");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal r = a + b;
            Console.WriteLine("Your answer is\n" + r);
        }
        static void minus()
        {
            Console.WriteLine("enter first number\n");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter first number\n");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal r = a - b;
            Console.WriteLine("Your answer is\n" + r);

        }
        static void divide()
        {
            Console.WriteLine("enter first number\n");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter first number\n");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal r = a / b;
            Console.WriteLine("Your answer is\n" + r);

        }
        static void multiply()
        {
            Console.WriteLine("enter first number\n");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter first number\n");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal r = a * b;
            Console.WriteLine("Your answer is\n" + r);

        }
        static void square()
        {
            Console.WriteLine("enter first number\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double r = Math.Pow(a,2);
            Console.WriteLine("Your answer is\n" + r);

        }
        static void squareroot()
        {
            Console.WriteLine("enter first number\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(a);
            Console.WriteLine("Your answer is\n" + r);
     
        }
        static void calc()
        {
            Console.WriteLine("what do you want to do\n 1) additiion 2) Subtraction 3) Division 4) Multiplication 5) Square 6) Squareroot\n");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                add();
                want();
            }
            else if (a == 2)
            {
                minus();
                want();

            }
            else if (a == 3)
            {
                divide();
                want();
            }
            else if (a == 4)
            {
                multiply();
                want();

            }
            else if (a == 5)
            {
                square();
                want();

            }
            else if (a == 6)
            {
                squareroot();
                want();

            }
            else
            {
                Console.WriteLine("Invalid input type");
                want();
            }

        }
        static void Main(string[] args)
        {
            calc();
        }
    }
}
