/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


void Print3DArray(int[,,] massiv3D)
{
    for (int i = 0; i < massiv3D.GetLength(1); i++)
    {
        for (int j = 0; j < massiv3D.GetLength(1); j++)
        {
            for (int k = 0; k < massiv3D.GetLength(2); k++)
            {
                Console.WriteLine($"{massiv3D[i, j, k]} => индекс:({i},{j},{k}).");
            }
            Console.WriteLine();
        }
    }

}

/* void Get3DArray(int[,,] massiv3D)
{
    for (int i = 0; i < massiv3D.GetLength(1); i++)
    {
        for (int j = 0; j < massiv3D.GetLength(1); j++)
        {
            for (int k = 0; k < massiv3D.GetLength(2); k++)
            {
                massiv3D[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
} */

void CreateArray(int[,,] massiv3D) //не допер как сделать разные цифры, посмотрел семинар
{
    int[] temp = new int[massiv3D.Length]; //перемножение всех значений 3д массива
    int number;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < massiv3D.GetLength(0); x++)
    {
        for (int y = 0; y < massiv3D.GetLength(1); y++)
        {
            for (int z = 0; z < massiv3D.GetLength(2); z++)
            {
                massiv3D[x, y, z] = temp[count];
                count++;
            }
        }
    }

}



Console.Clear();
Console.WriteLine("Создадим 3-х мерный массив");
Console.WriteLine();
Console.WriteLine("Введите первый элемент массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второй элемент массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третий элемент массива: ");
int c = int.Parse(Console.ReadLine()!);

int[,,] massiv = new int[a, b, c];

/* Get3DArray(massiv); */
CreateArray(massiv);
Print3DArray(massiv);