// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) 
{
    Console.Write($"{number1} is bigger and {number2} is smaller");
}
else
{
    Console.Write($"{number2} is bigger and {number1} is smaller");
}