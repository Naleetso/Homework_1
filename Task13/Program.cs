// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int third = Third_digit(number);

int Third_digit(int num) 
{
    while (num > 999)
    {
        num = num / 10;
    }
    if (num < 100)
    {
        return 0;
    }
    else 
    {
        return num % 10;
    }
}
if (third == 0) 
{
    Console.WriteLine("There is no third digit");
}
else 
{
    Console.WriteLine($"The third digit is {third}");
}