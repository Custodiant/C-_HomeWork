//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[4];

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-100, 101);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

void SumNotEvenArray(int[] collect)
{
    int count = collect.Length;
    int SumCount = 0;
    for (int i = 0; i < count; i++)
    {
        if (i % 2 != 0)
        {
            SumCount = SumCount + collect[i];
        }
    }
    Console.Write($"Сумма значений из нечетных индексов = ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(SumCount);
    Console.ForegroundColor = ConsoleColor.White;
}


FillArray(array);
Console.Write("Наш рандомный массив: ");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(array);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
SumNotEvenArray(array);