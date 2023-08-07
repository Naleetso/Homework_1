// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = NumberLength (number);
NumberSum (number, length);

int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

void NumberSum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.Write($"The sum of digits in {number} is equal to {sum}");
}
