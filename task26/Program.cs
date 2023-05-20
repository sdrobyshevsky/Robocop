// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Multiply(int number)
{
    int mult = 1;
    for (int i = 2; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int mult = Multiply(num);
System.Console.WriteLine($"Сумма от 1 до {num} = {mult}");