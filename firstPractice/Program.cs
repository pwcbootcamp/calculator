﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int x = 5;
//int y = 6;
//double z = 5.0;
//decimal a = 7.6m;

//DateTime today = DateTime.Now;
//string Color = "paint";
//char Freqs = 'h';
//char we = 'z';
//DateTime myBirthDay = Convert.ToDateTime("07/17/2022");


//Console.WriteLine("Its my birthday today " + myBirthDay);

////////////////////////////////////
//string one = "1. Water";
//string two = "2. Soft Drink";
//string three = "3. Alchol";
//string four = "4. You do not have what I like";

//Console.WriteLine("Here is our food menu ");
//string[] menu = {one, two, three, four };
//for (int i = 0; i< menu.Length; i++)
//{
//    Console.WriteLine(menu[i]);
//    Console.WriteLine($" The numbers are {menu[i]}");
//}

//; string foodMenu = "What do you want to drink ? ";
//Console.WriteLine(foodMenu);
//int feeling;
//feeling= Convert.ToInt32(Console.ReadLine());

//if (feeling == 1)
//{
//    Console.WriteLine(one);
//}else if (feeling == 2)
//{
//    Console.WriteLine(two);
//}
//else if (feeling == 3)
//{
//    Console.WriteLine(three);
//}
//else if (feeling == 4)
//{
//    Console.WriteLine(four);
//}
//else
//        {
//    Console.WriteLine("There's nothing like that in the menu");
//}

//switch (feeling)
//{

//}
//int[] numbers = { 1, 2, 3, 4, 5, 6 };
//int pee = 0;
//while (pee < 6)
//{
//    Console.WriteLine(menu.Length);
//    pee++;
//}


//using firstPractice;
//Person p = new Person();
//p.Name = "John";
//p.Age = 13;
//p.Talk();


string add = "add";
string subtract = "subtract";
string multiply = "multiply";
string divide = "divide";
string modulo = "modulo";

string[] operations = { add, subtract, multiply, divide, modulo };
string quest = "please tell us your name?";
Console.WriteLine(quest);
string name;
name = Console.ReadLine();
Console.WriteLine($"dear {name} please select the operation you want to perform");
for (int i = 0; i < operations.Length; i++)
{
    Console.WriteLine(operations[i]);
}
string ops;
ops = Console.ReadLine();
string number = "select a number";
Console.WriteLine(number);
string num1;
num1 = Console.ReadLine();
string number2 = "select another number";
Console.WriteLine(number2);
string num2;
num2 = Console.ReadLine();

if(ops == "add" || num1 ==null || num2==null)
{
   int sum= Convert.ToInt32(num1)+ Convert.ToInt32(num2);
    Console.WriteLine($"The sum of the numbers is {sum}");
}
else if(ops == "subtract") {
    int sub = Convert.ToInt32(num1) - Convert.ToInt32(num2);
    Console.WriteLine($"The subtraction of the numbers is {sub}");
}
else if (ops == "multiply")
{
    int op = Convert.ToInt32(num1) * Convert.ToInt32(num2);
    Console.WriteLine($"The product of the numbers is {op}");
}
else if (ops == "divide")
{
    int div = Convert.ToInt32(num1) / Convert.ToInt32(num2);
    Console.WriteLine($"The division of the numbers is {div}");
}
else if (ops == "modulo")
{
    int div = Convert.ToInt32(num1) % Convert.ToInt32(num2);
    Console.WriteLine($"The division of the numbers is {div}");
}
else
{
    Console.WriteLine("You selected an invalid operation");
}





