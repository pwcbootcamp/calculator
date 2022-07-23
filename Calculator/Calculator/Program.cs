Console.WriteLine("\n      Welcome To CalCulatorPedia\n\n A calculator that performs simple arithemetic calculations like:\n\n   1. Multiplication(*)\n" +
    "   2. Division(/)\n   3. Addition(+)\n   4. Subtraction(-).\n\n");
Console.WriteLine("Please Enter Your First Number");
var firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Please Enter The Operator");
var Operator = Console.ReadLine();
Console.WriteLine("Please Enter Your Second Number");
var secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine(firstNumber);

switch (Operator)
{
    case "x":
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case "*":
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case "-":
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case "+":
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case "/":
        Console.WriteLine(firstNumber / secondNumber);
        break;
    default:
        Console.WriteLine("No Operator passed");
        break;
}