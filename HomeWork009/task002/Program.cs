/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int NumSorted(int num, int num2, int sum = 0)
{
    if (num != num2)
    {
        if (num < num2)
        {
            Console.Write($"{num}, ");
            NumSorted(num + 1, num2, sum + num);
        }
        else                            // Работа с отрицательными значениями
        {
            Console.Write($"{num}, ");
            NumSorted(num - 1, num2, sum + num);
        }
    }
    else
    {
        Console.WriteLine($"{num2}.");
        sum = sum + num2;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($" Сумма интервала = {sum}.");
        Console.ResetColor();
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите 1 натуральное число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 натуральное число:");
int number2 = int.Parse(Console.ReadLine()!);


Console.WriteLine("Все натуральные числа в диапазоне:");

NumSorted(number, number2);
