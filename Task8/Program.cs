// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int odd_number = 1;

if (number < 0)
{
    odd_number = -1;
    while (odd_number >= number) {
        if (odd_number % 2 == 0) 
        {
            Console.Write($"{odd_number} ");
        }
    odd_number--;
} 
} 
else 
{
    while (odd_number <= number) {
        if (odd_number % 2 == 0) 
        {
            Console.Write($"{odd_number} ");
        }
    odd_number++;
}
}
