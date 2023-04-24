// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
string number_text = Convert.ToString(number);
if (number_text.Length == 5)
{
    if (number_text[0] == number_text[4] && number_text[1] == number_text[3]) 
    {
    Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
    Console.WriteLine($"{number} -  не палиндром");
    }
} 

if (number_text.Length > 5)
    {
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
    }  

if (number_text.Length < 5)
    {
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
    }  
