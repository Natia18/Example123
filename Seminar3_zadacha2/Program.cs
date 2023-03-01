// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X1 : ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y1 : ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите Z1 : ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите X2 : ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y2 : ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите Z2 : ");
double z2 = double.Parse(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
  double xc = (x1 - x2) * (x1 - x2);
  double yc = (y1 - y2) * (y1 - y2);
  double zc = (z1 - z2) * (z1 - z2);
  double result = Math.Sqrt(xc + yc + zc);
  return result;  
} 
double res = Distance(x1, y1, z1, x2, y2, z2);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);