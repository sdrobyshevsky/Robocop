// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int digit1 = number / 100;
int digit2 = number / 10 - (number / 100 * 10); 

int result = number / 10 - (digit1 * 10);   
Console.WriteLine(result); 
