// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter numbers");
double number1=double.Parse(Console.ReadLine());
double number2=double.Parse(Console.ReadLine());
double number3=double.Parse(Console.ReadLine());
double max;
max=number1;
if (max<number2) max=number2;
if (max<number3)  max=number3;
Console.WriteLine("The largest number is "+max); 

