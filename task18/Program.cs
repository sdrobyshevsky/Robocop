// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 2 варианта решения задачи:   

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество цифр числа: ");
// int countnumber = Convert.ToInt32(Console.ReadLine());

// if (countnumber == 3)  
//    {
//    Console.WriteLine("Третья цифра:" + number % 10);
//    } 

// if (countnumber > 3)  
//    {
//    Console.WriteLine("Третья цифра:" + (number / (int)Math.Pow(10, countnumber - 3) % 10)); 
//    }

// if (countnumber < 3)
//    {
//    Console.WriteLine("Третьей цифры нет");    
//    } 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length > 2)
{
    Console.WriteLine($"Третья цифра числа - {number_text[2]}");
}
else
{
   Console.WriteLine("Третьей цифры нет!");
} 