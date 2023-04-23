// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distantion2D(double x1, double y1, double x2, double y2)
{
return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
}

System.Console.WriteLine("Введите координату x точки A");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки A");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки B");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
double y2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Distantion2D(x1, y1, x2, y2));