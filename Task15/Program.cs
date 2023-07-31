// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number referring to day of week: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend (int num)
{
    return num == 6 || num == 7;
}

bool result = Weekend(number);

if (number > 7 || number < 1)
{
    Console.WriteLine("It is not a day of week");
}
else
{
    Console.WriteLine(result ? "This is a weekend" : "This is a weekday");
}