﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMatrix(double[,] matrix)
{
for (double i = 0; i < matrix.GetLength(0); i++)
{
for (double j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = i + j;
}
} 
}

void PrintMatrix(double[,] matrix)
{
for (double i = 0; i < matrix.GetLength(0); i++)
{
for (double j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} " + "\t");
}
System.Console.WriteLine();
}
}

System.Console.Write("Введите количество строк массива: ");
double m = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
double n = Convert.ToDouble(Console.ReadLine());
double[,] matrix = new double[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
