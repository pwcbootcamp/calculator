Console.WriteLine("Input first number");
var firstNum = Console.ReadLine();
Console.WriteLine("Enter operator (+,-,/,*)");
var operatorType = Console.ReadLine();
Console.WriteLine("Input second Number");
var secondNum = Console.ReadLine();
double resultFirstNum;
double resultSecondNum;
double result;
if (double.TryParse(firstNum, out resultFirstNum) && double.TryParse(secondNum, out resultSecondNum))
{
    switch (operatorType)
    {
        case "+":
            result = resultFirstNum + resultSecondNum;
            Console.WriteLine(result);
            break;
        case "-":
            result = resultFirstNum - resultSecondNum;
            Console.WriteLine(result);
            break;
        case "*":
            result = resultFirstNum * resultSecondNum;
            Console.WriteLine(result);
            break;
        case "/":
            result = resultFirstNum / resultSecondNum;
            Console.WriteLine(result);
            break;
        default:
            Console.WriteLine("Invalid operator please try again!");
            break;
    };
}
else
{
    Console.WriteLine("Failure: You have added a wrong input!");
}

