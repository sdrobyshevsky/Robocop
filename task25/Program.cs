// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// b456 -> 3
// 78 -> 2
// 89126 -> 5

int Counting(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    if (count == 0)
    {
        count++;
    }
    return count;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = A(num);
System.Console.WriteLine($"Кол-во цифр в числе {num} = {count}");

// Второй вариант решения

System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if (int.TryParse(num, out int number))
{
    System.Console.WriteLine(num.Length);
}
else
{
    System.Console.WriteLine("Ошибка: нужно ввести число");
}
