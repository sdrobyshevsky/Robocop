// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number < 0)
{
number = -number;
}
int lastNumber = 0;
if (number > 99 && number < 1000)
{
lastNumber = number % 10;
Console.Write($"Последняя цифра числа {number} равнa {lastNumber}");
Console.Write($"Последняя цифра числа {number} равнa {number % 10}");
}
else
{
Console.Write("Число не трехзначное");
} 