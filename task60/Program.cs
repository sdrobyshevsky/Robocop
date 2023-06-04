// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 4;
int[,] array = new int[m, m];
FillArraySpiral(array, m); 
PrintArray(array); 

//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int m)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < m * m; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < m - 1);
        for (k = 0; k < m - 1; k++) array[i++, j] = value++;
        for (k = 0; k < m - 1; k++) array[i, j--] = value++;
        for (k = 0; k < m - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        m = m < 2 ? 0 : m - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}