// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Are you stupid? It is said, three-digit");
}
else 
{
    int second = number % 100 / 10;
    Console.WriteLine($"The second digit is {second}");
}
