// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine($"Enter the size of array: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int sum = RandomArray(size, -99, 100);
Console.WriteLine($"");
Console.WriteLine($"Sum of numbers on odd positions: {sum}");

int RandomArray(int numbers, int min, int max)
  {
    int[] randomNumber = new int[size];
    int sumNumbers = 0;
    Console.Write("In this array: ");
    for (int i = 0; i < randomNumber.Length; i++ )
    {
      randomNumber[i] = new Random().Next(min, max);
      Console.Write($"{randomNumber[i]} ");
      if (i % 2 == 1)
      {
        sumNumbers = sumNumbers + randomNumber[i];
      }
    }
  return sumNumbers;
  }