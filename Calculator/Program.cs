// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the first number");

int firstValue = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number");

int secondValue = int.Parse(Console.ReadLine());

Console.WriteLine("What operation will you like to perfom \n " +
    "1. addition \n" +
    "2. multiplication \n " +
    "3. Division \n " +
    "4. Subtraction");

string operation = Console.ReadLine();

Console.WriteLine("You have choosen operation " + operation);
int result;

if (operation == "1")
{
    
    result = firstValue + secondValue;
    Console.WriteLine("the result to your  addition operation with first value as " + firstValue + " and second value as " + secondValue + " is "  + result);
}
else if (operation == "2")
{
    result = firstValue * secondValue;
    Console.WriteLine("the result to your multiplication operation with first value as " + firstValue + " and second value as " + secondValue + " is " + result);
}
else if (operation == "3")
{
    result = firstValue / secondValue;
    Console.WriteLine("the result to your division operation with first value as " + firstValue + " and second value as " + secondValue + " is " + result);
}
else if (operation == "4")
{
    result = secondValue - firstValue;
    Console.WriteLine("the result to your subtraction operation with first value as " + firstValue + " and second value as " + secondValue + " is " + result);
}

