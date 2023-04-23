// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater == 1)
{
Console.WriteLine("x > 0 y > 0");
}
if (quater == 2)
{
Console.WriteLine("x < 0 y > 0");
}
if (quater == 3)
{
Console.WriteLine("x < 0 y < 0");
}
if (quater == 4)
{
Console.WriteLine("x > 0 y < 0");
}
