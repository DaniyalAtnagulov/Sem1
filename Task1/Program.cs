// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter the first number");
double number1=double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
double number2=double.Parse(Console.ReadLine());
if (number1>number2)
Console.WriteLine ("The larger number is " +number1+" the lesser nuber is "+number2);
if (number2>number1)
Console.WriteLine ("The larger number is " +number2+"the lesser number is "+number1);
if (number2==number1)
Console.WriteLine ("The numbers are equal");
