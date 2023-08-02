// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter coordinates of 2 dots");
Console.Write("X1: ");
int x1_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2_Coordinate = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1_Coordinate, y1_Coordinate, z1_Coordinate, x2_Coordinate, y2_Coordinate, z2_Coordinate);
double distance_Round = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"The distance between two dots is equal to: {distance_Round}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dist;
}