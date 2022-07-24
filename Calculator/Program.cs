using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

        link1:
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("        PWC CALCULATOR");
            Console.WriteLine("-----------------------------------");



            Console.WriteLine("Please choose type of calculator");
            Console.WriteLine("Press 1 for ADDITION " + "\n" +
                   "Press 2 for SUBTRACTION " + "\n" +
                   "Press 3 for MULTIPLICATON " + "\n" +
                   "");

            string z = Console.ReadLine();

            if (z == "1")
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("        ADDITION CALCULATOR");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\n");
                int x;
                Console.WriteLine("enter your first value");
                x = Convert.ToInt32(Console.ReadLine());

                int y;
                Console.WriteLine("enter your second value");
                y = Convert.ToInt32(Console.ReadLine());

                int c = x + y;

                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("        ADDITION CALCULATOR");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(x.ToString() + "+" + y.ToString() + " = " + c);

                Console.WriteLine("Press Y to use the calculator again");
                string Ag = Console.ReadLine();

                if (Ag == "Y" || Ag == "y")
                {
                    Console.Clear();
                    goto link1;
                }


            }

            //subtraction




            if (z == "2")
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("       SUBTRACTION CALCULATOR");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\n");
                int x;
                Console.WriteLine("enter your first value");
                x = Convert.ToInt32(Console.ReadLine());

                int y;
                Console.WriteLine("enter your second value");
                y = Convert.ToInt32(Console.ReadLine());

                int c = x - y;

                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("        SUBTRACTION CALCULATOR");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(x.ToString() + " - " + y.ToString() + " = " + c);

                Console.WriteLine("Press Y to use the calculator again");
                string Ag = Console.ReadLine();

                if (Ag == "Y" || Ag == "y")
                {
                    Console.Clear();
                    goto link1;
                }


            }


            //multiplication


            if (z == "3")
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("        MULTIPLICATION CALCULATOR");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\n");
                int x;
                Console.WriteLine("enter your first value");
                x = Convert.ToInt32(Console.ReadLine());

                int y;
                Console.WriteLine("enter your second value");
                y = Convert.ToInt32(Console.ReadLine());

                int c = x * y;

                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("           MULTIPLICATION CALCULATOR");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(x.ToString() + " X " + y.ToString() + " = " + c);

                Console.WriteLine("Press Y to use the calculator again");
                string Ag = Console.ReadLine();

                if (Ag == "Y" || Ag == "y")
                {
                    Console.Clear();
                    goto link1;
                }


            }



















        }
    }
}
