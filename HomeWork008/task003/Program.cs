/* Задача 58: Задайте две матрицы.
 Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] MultiplicationArray(int[,] firstMatrix, int[,] secondMatrix, int a, int b)
{
    int[,] resultMatrix = new int[a, b];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
            /* Console.Write($"{resultMatrix} "); */
        }
        /*  Console.WriteLine(); */
    }
    return resultMatrix;
}

Console.Clear();
Console.WriteLine
($"Выберите размер матриц");
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
        int[,] table2 = GenerateArray(column, stroke, min, max);

        Console.WriteLine("Ваша 1 матрица: ");
        PrintArray(table);
        Console.WriteLine();

        Console.WriteLine("Ваша 2 матрица: ");
        PrintArray(table2);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Результирующая матрица: ");
        PrintArray(MultiplicationArray(table, table2, column, stroke));
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Минимальное число {min}, не может быть больше либо равно максимальному {max}!");
        Console.ResetColor();
    }
}