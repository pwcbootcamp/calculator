// See https://aka.ms/new-console-template for more information

string operation;
int result;
do
{
    start_up_fxn();
    operation = Console.ReadLine();
    Console.WriteLine("First input");
    int first_operand = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Second input");
    int second_operand = Convert.ToInt32(Console.ReadLine());
    result = 0;
    switch (operation)
    {
        case "1":
            {
                result = Addition(first_operand, second_operand);
                break;
            }
        case "2":
            {
                result = Subtraction(first_operand, second_operand);
                break;
            }
        case "3":
            {
                result = Multiplication(first_operand, second_operand);
                break;
            }
        case "4":
            {
                result = Division(first_operand, second_operand);
                break;
            }
        case "5":
            {
                result = Modulo(first_operand, second_operand);
                break;
            }
        case "exit":
            {
                break;
            }
        default:
            Console.WriteLine("Wrong action!! try again");
            break;
    }
    Console.WriteLine("The result is {0}", result);
    // Console.ReadKey();
} while (operation != "exit");

// Start up function
void start_up_fxn()
{
    Console.WriteLine("This is a Calculator App\n"
    + "Select an operator or type exit to exit the app");
    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Subtraction");
    Console.WriteLine("Press 3 for Multiplication");
    Console.WriteLine("Press 4 for Division");
    Console.WriteLine("Press 5 for Modulo\n");
}
//Addition  
int Addition(int input_1, int input_2)
{
    return input_1 + input_2;
}
//Substraction  
int Subtraction(int input_1, int input_2)
{
    return input_1 + input_2;
}
//Multiplication  
int Multiplication(int input_1, int input_2)
{
    return input_1 + input_2;
}
//Division  
int Division(int input_1, int input_2)
{
    return input_1 + input_2;
}

//Modulo
int Modulo(int input_1, int input_2)
{
    return input_1 % input_2;
}