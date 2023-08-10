// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Enter the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
FillArray(number);
Console.WriteLine("In this array: ");
PrintArray(number);

double min = number[0];
double max = number[0];

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
    {
        max = number[a];
    }
    if (number[a] < min)
    {
        min = number[a];
    }
}

Console.WriteLine($"The maximum value is equal to {max} | The minimum value is equal to {min}");
Console.WriteLine($"The difference between them is equal to {max - min}");

void FillArray(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100, 10000)) / 100;
    }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}