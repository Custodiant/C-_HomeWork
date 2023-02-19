/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */ //В примере некорректно согласно описанию. Нама требуются положительные числа, а не более 1

void UserNumbers(double[] collection)
{
    int lenght = collection.Length;
    for (int index = 0; index < lenght; index++)
    {
        collection[index] = double.Parse(Console.ReadLine()!);
    }
}

void PrintUserNumbers(double[] collection2)
{
    int count = collection2.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection2[position]} ");
    }
}

void EvenArray(double[] collection3)
{
    double counter = collection3.Length;
    double evenSum = 0;
    for (int even = 0; even < counter; even++)
    {
        if (collection3[even] > 0)
        {
            evenSum++;
        }
    }
    Console.Write($"{evenSum}.");
}

Console.Clear();


Console.WriteLine($"Введите, сколько чисел вы хотите проверить: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];

Console.WriteLine($"Введите любые числа: ");
UserNumbers(array);
Console.WriteLine($"Ваши числа: ");
PrintUserNumbers(array);
Console.WriteLine();
Console.WriteLine($"Количество положительных: ");
EvenArray(array);
Console.WriteLine();
