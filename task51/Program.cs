// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

void FillMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i, j] = Convert.ToInt32(new Random().Next(-100,1000)) / 100;
}
} 

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} " + "\t");
}
System.Console.WriteLine();
} 
}

System.Console.Write("Введите индекс элемента массива по строке: ");
int i = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс элемента массива по столбцу: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > 0 && i < m && j > 0 && j < n)
{  
Console.WriteLine($"Значение элемента массива = {matrix[i, j]}");
}
else 
{
Console.WriteLine($"{i}{j} -> такого числа в массиве нет");
}  

FillMatrix(matrix);
PrintMatrix(matrix);