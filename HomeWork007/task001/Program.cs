/* Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

void PrintArray(double[,] tables)
{
    for (int i = 0; i < tables.GetLength(0); i++)
    {
        for (int j = 0; j < tables.GetLength(1); j++)
        {
            Console.Write($"{tables[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
        }
    }
}


Console.Clear();
Console.WriteLine("Введите необходимые размеры таблицы: ");

Console.Write($"высота = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("ширина = ");
int n = int.Parse(Console.ReadLine()!);



double[,] table = new double[m, n];

FillArray(table);
Console.WriteLine();
PrintArray(table);