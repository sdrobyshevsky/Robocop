// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[m, n];

// Заполнение массива рандомными числами от -100 до 99
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

if (m < matrix.GetLength(0) && n <= matrix.GetLength(1)) 
{
Console.WriteLine(matrix[m, n]);
}
else 
{
Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
}

// Функция ввода 
FillArray(matrix);
PrintArray(matrix);