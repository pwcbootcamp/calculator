int result;

    func();
    do
    {
        Console.Write("Enter 1 to perform a new operation or 2 to stop ");
        result = Convert.ToInt32(Console.ReadLine());
          func();
    } while (result != 2);



void func()
{
    Console.Write("Enter a number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Operator: ");
    string op = Console.ReadLine();

    Console.Write("Enter another number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    if (op == "+")
    {
        double answer = num1 + num2;
        Console.WriteLine($"Answer: {answer}");
    }

    else if (op == "-")
    {
        double answer = num1 - num2;
        Console.WriteLine($"Answer: {answer}");
    }

    else if (op == "*")
    {
        double answer = num1 * num2;
        Console.WriteLine($"Answer: {answer}");
    }

    else if (op == "/")
    {
        if (num2 == 0.0)
        {
            Console.WriteLine("ERROR: Zero Division Error");
        }

        else
        {
            double answer = num1 / num2;
            Console.WriteLine($"Answer: {answer}");
        }
    }

    else
    {
        Console.WriteLine("ERROR: Invalid Operator");
    }
}
