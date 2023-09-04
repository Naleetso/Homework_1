// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Enter the size of array m and n:");
Console.Write("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.Write("Arithmetic mean of:");
Console.WriteLine("");
ArithmeticMean(array);

void ArithmeticMean(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < m; j++)
        {
            arithmeticMean = arithmeticMean + array[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / m, 1);
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