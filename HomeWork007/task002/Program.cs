/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> по такому индексу нет элемента. */

void PrintArray(int[,] tables)
{

    for (int i = 0; i < tables.GetLength(0); i++)
    {
        for (int j = 0; j < tables.GetLength(1); j++)
        {
            tables[i, j] = new Random().Next(-10, 11);
            Console.Write($"{tables[i, j]} ");
        }
        Console.WriteLine();
    }

}

void CheckArray(int[,] tables)
{
    Console.WriteLine();
    Console.Write("Индекс строки: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Индекс столбца: ");
    int b = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.Write($"Индекс: [{a},{b}], значение: ");

    if ((tables.GetLength(0) > a) & (tables.GetLength(1) > b))
    {
        for (int i = 0; i < tables.GetLength(0); i++)
        {
            for (int j = 0; j < tables.GetLength(1); j++)
            {
                if (i == a && j == b)
                {
                    Console.WriteLine($"{tables[a, b]} ");
                    break;
                }
            }

        }
    }
    else
    {
        Console.WriteLine($"по такому индексу, нет элемента");
    }

}

Console.Clear();

Console.WriteLine
($"Выберете позиции в таблице, для проверки, существует ли ячейка, если да, то что в ней находится");

int[,] table = new int[5, 4];

PrintArray(table);
CheckArray(table);





