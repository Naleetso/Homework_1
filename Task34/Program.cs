// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Enter the size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[size];
RandomArray(array);
Console.WriteLine("In this array: ");
PrintArray(array);

for (int x = 0; x < array.Length; x++)
{
    if (array[x] % 2 == 0)
        count++;
}
Console.WriteLine($"There are {count} even numbers");

void RandomArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}