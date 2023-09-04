// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Enter the size of array m and n:");
Console.Write("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.Write("Enter the coordinates of an element (line, column), separated by comma: ");
string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if (position[0] <= m
&& position[1] <= n
&& position[0] >= 0
&& position[1] >= 0)
{
    double result = array[position[0] - 1, position[1] - 1];
    Console.Write($"The element of array: {result}");
}
else Console.Write($"There is no such element in the array.");

int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}

string RemovingSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output = output + input[i];
        }
    }
    return output;
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