/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void PrintArray(int[,] someArray)
{
    bool flag = true;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        if (flag)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            flag = !flag;
        }
        else
        {
            Console.ResetColor();
            flag = !flag;
        }
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void SumStroceArray(int[,] tables) // сумма строк с подсчетом миниматьнй строки
{
    int min = 999999999;
    int k = 0;
    for (int i = 0; i < tables.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < tables.GetLength(1); j++)
        {
            sum = sum + tables[i, j];

        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");

        if (min > sum)
        {
            min = sum;
            k = i + 1;
        }
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Минимальная строка {k}: сумма строки = {min}");
    Console.ResetColor();
}

Console.Clear();
Console.WriteLine
($"Выберите размер таблицы");
Console.Write("Количество столбцов:");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Количество строк:");
int stroke = int.Parse(Console.ReadLine()!);

if (column <= 1 || stroke <= 1) // проверка матрицы
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Количество строк или столбцов, не может быть меньше 1!");
    Console.ResetColor();
}
else if (column == stroke) // проверка матрицы на прямоугольность
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"По условию, таблица должна быть прямоугольной!");
    Console.ResetColor();
}
else
{
    Console.Write("Минимальное число: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Максимальное число: ");
    int max = int.Parse(Console.ReadLine()!);
    if (min < max)
    {
        Console.WriteLine();
        int[,] table = GenerateArray(column, stroke, min, max);

        Console.WriteLine("Ваша матрица: ");
        PrintArray(table);
        Console.WriteLine();

        Console.WriteLine("Суммы по строкам: ");
        SumStroceArray(table);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Минимальное число {min}, не может быть больше либо равно максимальному {max}!");
        Console.ResetColor();
    }
}