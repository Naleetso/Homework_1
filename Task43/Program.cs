// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = a1 * x + b1, y = a2 * x + b2; значения b1, a1, b2 и a2 задаются пользователем.
// b1 = 2, a1 = 5, b2 = 4, a2 = 9 -> (-0,5; -0,5)

void FindIntersection(double c1, double d1, double c2, double d2)
{
    var x = -(d1 - d2) / (c1 - c2);
    var y = c1 * x + d1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"Intersection of the two lines at point: ({x} ; {y})");
}

Console.WriteLine("Enter the coordinates of two straight lines:");
Console.Write("Enter a1: ");
var a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a2: ");
var a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

FindIntersection(a1, b1, a2, b2);