// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Enter the size of array x and y:");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[x, y];
CreateArray(array);
WriteArray(array);

Console.Write("Arithmetic mean of:");
Console.WriteLine("");
ArithmeticMean(array);

void ArithmeticMean(int[,] arr)
{
    for (int i = 0; i < y; i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < x; j++)
        {
            arithmeticMean = arithmeticMean + array[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / x, 1);
        Console.WriteLine($"{i + 1} column: {arithmeticMean}");
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}