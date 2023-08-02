// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrome(int num)
{
    int first = num / 10000;
    int second = num / 1000 % 10;
    int fourth = num % 100 / 10;
    int fifth = num % 10;
    return first == fifth && second == fourth;
}
bool result = Palindrome(number);

if (number < 10000 || number > 99999)
{
    Console.WriteLine("It is not a 5-digit number");
}
else
{
    Console.WriteLine(result ? "This is a palindrome":"This is not a palindrome");
}