namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculator
            Console.Write("Enter a number ");
            double num1; // var that will hold the converted string 

            /* parse the Console.ReadLine input and convert the input string to a double
             * if the user enters a value that is not a number, continue to request for a valid input
             * when a valid input is entered the input string is then converted to a double and the output
             * is assigned to var num1
             */
            while (!Double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Not a valid number ");
                Console.Write("Enter a valid number ");
            }
            Console.Write("Enter an operator( valid operators are: +, -, *, / ) ");
            string op = Console.ReadLine(); // read operator input

            Console.Write("Enter a number ");
            double num2; // var that will hold the converted string 

            /* parse the Console.ReadLine input and convert the input string to a double
             * if the user enters a value that is not a number, continue to request for a valid input
             * when a valid input is entered the input string is then converted to a double and the output
             * is assigned to var num2
             */
            while (!Double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Not a valid number ");
                Console.Write("Enter a valid number ");
            }

            // perform an arithemetic operation on the 2 inputs entered based on the operation that the user selects
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;

                default:
                    Console.WriteLine("not a valid operator");
                    break;
            }
        }
    }
}