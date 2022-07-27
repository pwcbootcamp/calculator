class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result = 0;

        Console.Write("Enter first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        char operand = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (operand)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("You have entered wrong operator");
                break;
        }

        Console.WriteLine(num1 + " " + operand + " " + num2 + ": " + result);
        Console.ReadLine();
    }
}