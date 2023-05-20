// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Первый вариант решения задачи 

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция подсчета цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // Функция вывода суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Второй вариант решения задачи

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

// Подсчет количества символов в числе
int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}

// Третий вариант решения задачи

using System;
namespace Example {
class Program {
static void Main() {
Console.Write("Введите число: ");
string number = Console.ReadLine();
ushort sum = 0;
bool point = true;
char symbol;
for (int i = 0; i < number.Length; ++i) {
symbol = number[i];
if (i == 0 && symbol == '-' || symbol == '+') continue;
if (point && symbol == '.') {
point = false;
continue;
}
if (Char.IsDigit(symbol)) sum += Convert.ToUInt16(symbol.ToString());
else break;
}
Console.WriteLine("Сумма цифр = " + sum);
Console.ReadKey();
}
}
}