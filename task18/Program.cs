// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sqare = 1;
// while (sqare <= num)
// {
// System.Console.WriteLine(Math.Pow(sqare, 2));
// sqare++;
// }
for (int i = 1; i <= num; i++)
{
System.Console.Write(Math.Pow(i, 2) + " ");
} 