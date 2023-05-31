// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + "\t  ");
Console.WriteLine();
}

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a >= 0 && a < m && b >= 0 && b < n)
Console.WriteLine($"Значение элемента массива = {matrix[a, b]}");
else
{
Console.WriteLine($"{a}{b} -> такого числа в массиве нет");
}

  
// System.Console.Write("Введите индекс элемента массива по строке: ");
// int i = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите индекс элемента массива по столбцу: ");
// int j = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[3, 4]; 

// void FillMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// matrix[i, j] = Convert.ToInt32(new Random().Next(1000,10000)) / 100;
// }
// } 

// void PrintMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// System.Console.Write($"{matrix[i, j]} " + "\t");
// }
// System.Console.WriteLine();
// } 
// }

// if (i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1))
// {  
// Console.WriteLine($"Значение элемента массива = {matrix[i, j]}");
// }
// else 
// {
// Console.WriteLine($"{i}{j} -> такого числа в массиве нет");
// }  

// FillMatrix(matrix);
// PrintMatrix(matrix);