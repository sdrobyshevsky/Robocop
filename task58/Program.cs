// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Random rnd = new Random(); 
int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}
int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    { 
    Console.WriteLine(" Нельзя перемножить ");
    } 
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

{
    int[,] matrix1 = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
    int[,] matrix2 = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
    PrintMatrix(matrix1);
    Console.WriteLine();
    PrintMatrix(matrix2);
    Console.WriteLine();
    PrintMatrix(DivMatrix(matrix1, matrix2));
    Console.ReadLine();
} 




// System.Console.Write("Введите количество строк первой матрицы: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов первой матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество строк второй матрицы: ");
// int i = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов второй матрицы: ");
// int j = Convert.ToInt32(Console.ReadLine());

// int[,] FirstMatrix = new int[m, n]; 
// int[,] SecondMatrix = new int[i, j];


// // Функция заполнения первого массива рандомными числами от 1 до 9
// void FillFirstMatrix(int[,] FirstMatrix)
// {
//     for (int m = 0; m < FirstMatrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < FirstMatrix.GetLength(1); n++)
//         {
//             FirstMatrix[m, n] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция вывода первого двумерного массива в терминал 
// void PrintFirstMatrix(int[,] FirstMatrix); 
// { 
//     for (int m = 0; m < FirstMatrix.GetLength(0); m++)
//     {
//         for (int n = 0; n < FirstMatrix.GetLength(1); n++)
//         {
//             Console.Write($"{FirstMatrix[m, n]} + \t");  
//         }
//         Console.WriteLine();
//     }
// }

// // Функция заполнения второго массива рандомными числами от 1 до 9
// void FillSecondMatrix(int[,] SecondMatrix)
// {
//     for (int i = 0; i < SecondMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < SecondMatrix.GetLength(1); j++)
//         {
//             SecondMatrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// } 

// // Функция вывода второго двумерного массива в терминал 
// void PrintSecondMatrix(int[,] SecondMatrix);  
// { 
//     for (int i = 0; i < SecondMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < SecondMatrix.GetLength(1); j++)
//         {
//             Console.Write($"{SecondMatrix[i, j]} + \t");  
//         }
//         Console.WriteLine();
//     }
// }

// void FillResultMatrix(int[,] ResultMatrix); 
// if (FirstMatrix.GetLength(0) != SecondMatrix.GetLength(1))
// { 
//     Console.WriteLine(" Нельзя перемножить ");
//     return; 
// }
// for (int i = 0; i < FirstMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < SecondMatrix.GetLength(1); j++)
//     {
//         ResultMatrix[i, j] = 0;
//         for (int k = 0; k < FirstMatrix.GetLength(1); k++)
//         { 
//             ResultMatrix[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
//         }
//     }
//     Console.WriteLine($"Произведение двух матриц = {ResultMatrix}");  
// }   
    
// // Функция ввода
// int PrintResultMatrix(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// FillFirstMatrix(FirstMatrix);
// PrintFirstMatrix(FirstMatrix);
// System.Console.WriteLine();   
 
// FillSecondMatrix(SecondMatrix); 
// PrintSecondMatrix(SecondMatrix);
// System.Console.WriteLine();  

// FillResultMatrix(ResultMatrix);
// PrintResultMatrix(ResultMatrix);
// System.Console.WriteLine(); 
