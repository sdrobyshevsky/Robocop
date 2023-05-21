// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];
Random rand = new Random(); // Random - является типом переменной
// int(Random) a(rand) = 8(new Random());// double string bool - всё является типом
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(0, 2);
// Console.Write($"{arr[i]} ");
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');