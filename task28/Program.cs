// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Первый вариант решения задачи

// int numberA = ReadInt("Введите число A: ");
// int numberB = ReadInt("Введите число B: ");
// ToDegree(numberA, numberB);

// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Второй вариант решения задачи 

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// if (b<1)
// Console.Write("Число B должно быть натуральным\n");
// else
// {
// while (b!=0)
// {
// c = c * a;
// b = b - 1;
// }
// Console.Write($"Число A в натуральной степени B равно {c}");
// }

// Третий вариант решения задачи 
 
int main()
{
    int a, b;
    cin >> a >> b;
  
    const int maxsize = 500000;
    int mas[maxsize];
    mas[1] = 1;
 
    int c = 0, len = 1;
    for(int i = 1; i <= b; ++i)
    {
        for(int j = 1; j <= len; ++j)
            mas[j] = mas[j] * a + c;
            c = mas[j] / 10;
            mas[j] = mas[j] % 10;
 
        while(c > 0)
            len++;
            mas[len] = c % 10;
            c /= 10;
    }
 
    while(mas[len] == 0 && len > 1) len--;
 
    for(int i = len; i >= 1; i--) cout << mas[i];
 
    return 0;
}