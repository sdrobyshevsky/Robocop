// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// A = 5; B = 7 -> max = 7
// A = 2; B = 10 -> max = 10
// A = -9; B = -3 -> max = -3

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:B:");
int numberB = Convert.ToInt32(Console.ReadLine()); 
if (numberA > numberB) 
{
Console.Write("Первое число" + numberA + "больше чем второе" + numberB); 
} 
else
{
Console.Write("Второе число" + numberB + "больше чем первое" + numberA);
} 