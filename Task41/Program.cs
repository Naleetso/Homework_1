// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Main(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            cnt++;
        }
    }
    return cnt;
}

Console.Write("Enter integers separated with spaces: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = Main(array);
Console.WriteLine($"Number of integers above 0: {count}");