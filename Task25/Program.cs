// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of power: ");
int power = Convert.ToInt32(Console.ReadLine());

ToDegree(number, power);

void ToDegree(int num, int pow)
{
    int index = 1;
    int sum = num;
    if (pow < 0)
    {
        pow = pow * -1;
    }
    while (index < pow)
    {
        sum = sum * num;
        index++;
    }
    Console.WriteLine($"The {num} in power of {pow} is equal to {sum}");
}
