// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.Write("Введите сторону a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите сторону b: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите сторону c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
System.Console.WriteLine("Треугольник существует");
else
System.Console.WriteLine("Треугольник не существует");
  