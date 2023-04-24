// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
if (day == 1)
{
Console.WriteLine("Понедельник,это невыходной день");
}
if (day == 2)
{
Console.WriteLine("Вторник, это невыходной день");
}
if (day == 3)
{
Console.WriteLine("Среда, это невыходной день");
}
if (day == 4)
{
Console.WriteLine("Четверг, это невыходной день");
}
if (day == 5)
{
Console.WriteLine("Пятница, это невыходной день");
}
if (day == 6)
{
Console.WriteLine("Суббота, это выходной день");
}
if (day == 7)
{
Console.WriteLine("Воскресенье, это выходной день");
}
} 
else
{
Console.WriteLine("Это не день недели");
}  