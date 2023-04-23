// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void QuatersFind(int x, int y) 
{
if (x > 0 && y > 0)
{
Console.Write("Точка лежит в первой четверти");
}
else if (x < 0 && y > 0)
{
Console.Write("Точка лежит во второй четверти");
}
else if (x < 0 && y < 0)
{
Console.Write("Точка лежит в третьей четверти");
}
else 
{
Console.Write("Точка лежит в четвертой четверти");
}
}

string QuatersFindWhithReturn(int x, int y)
{
string result = " ";
if (x > 0 && y > 0)
{
result = "Точка лежит в первой четверти";
}
else if (x < 0 && y > 0)
{
result = "Точка лежит во второй четверти";
}
else if (x < 0 && y < 0)
{
result = "Точка лежит в третьей четверти";
}
else
{
result = "Точка лежит в четвертой четверти";
}
return result;
}

Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
QuatersFind(x, y);
Console.WriteLine();
string quater = QuatersFindWhithReturn(x, y);
Console.WriteLine(quater);

