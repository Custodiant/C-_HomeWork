/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void PrintArray(int[,] tables)
{
    for (int i = 0; i < tables.GetLength(0); i++)
    {
        for (int j = 0; j < tables.GetLength(1); j++)
        {
            tables[i, j] = new Random().Next(1, 10);
            Console.Write($"{tables[i, j]} ");
        }
        Console.WriteLine();
    }
}

double Average(int[,] tables)
{
    double AVR = 0;
    double Summ = 0;

    for (int j = 0; j < tables.GetLength(1); j++)
    {
        for (int i = 0; i < tables.GetLength(0); i++)
        {
            Summ = Summ + tables[i, j];
        }

        AVR = Summ / tables.GetLength(0);
        AVR = Math.Round(AVR, 1);
        Console.Write($"сумма {j + 1} столбца  = {Summ} ,");
        Console.Write($"Среднее из столбца = {AVR} ");
        Console.WriteLine();
        Summ = 0;
    }
    return AVR;

}

Console.Clear();

Console.WriteLine
($"Выберите размер таблицы.");
Console.Write("Количество строк:");
int stroke = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов:");
int column = int.Parse(Console.ReadLine()!);


int[,] table = new int[stroke, column];

PrintArray(table);
Console.WriteLine();
Average(table);
