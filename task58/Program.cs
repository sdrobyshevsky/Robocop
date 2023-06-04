// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] FirstMatrix = new int[m, n]; 
int[,] SecondMatrix = new int[m, n];
int[,] ResultMatrix = new int[m, n];

// Функция заполнения первого массива рандомными числами от 1 до 9
void FillFirstMatrix(int[,] FirstMatrix)
{
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            FirstMatrix[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция заполнения второго массива рандомными числами от 1 до 9
void FillSecondMatrix(int[,] SecondMatrix)
{
    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            SecondMatrix[i, j] = new Random().Next(1, 10);
        }
    }
} 

// Функция вывода первого двумерного массива в терминал 
void PrintFirstMatrix(int[,] FirstMatrix); 
{ 
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            Console.Write($"{FirstMatrix[i, j]} + \t");  
        }
        Console.WriteLine();
    }
}

// Функция вывода второго двумерного массива в терминал 
void PrintSecondMatrix(int[,] SecondMatrix);  
{ 
    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
        {
            Console.Write($"{SecondMatrix[i, j]} + \t");  
        }
        Console.WriteLine();
    }
}

void PrintResultMatrix(ResultMatrix);
if (FirstMatrix.GetLength(0) != SecondMatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return; 
}
for (int i = 0; i < FirstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
    {
        ResultMatrix[i, j] = 0;
        for (int k = 0; k < FirstMatrix.GetLength(1); k++)
        { 
            ResultMatrix[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
        }
    }
    Console.WriteLine($"Произведение двух матриц = {ResultMatrix}");  
}   
    
FillFirstMatrix(FirstMatrix);
PrintFirstMatrix(FirstMatrix);
System.Console.WriteLine();   
 
FillSecondMatrix(SecondMatrix); 
PrintSecondMatrix(SecondMatrix);
System.Console.WriteLine();  

PrintResultMatrix(ResultMatrix);
System.Console.WriteLine(); 