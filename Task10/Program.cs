// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int second = Second_digit(number);

int Second_digit(int num) 
{
    if (num < 100 || num > 999)
    {
        return 0;
    }
    else 
    {
        return num % 100 / 10;
    }
}
if (second == 0) 
{
    Console.WriteLine("Are you stupid? It is said, three-digit");
}
else 
{
    Console.WriteLine($"The second digit is {second}");
}