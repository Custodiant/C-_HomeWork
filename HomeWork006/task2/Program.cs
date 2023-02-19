/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void IntersectionPoint(double a1, double a2, double c1, double c2)
{
    if (a1 * c2 == a2 * c1)
    {
        Console.WriteLine($"Прямые совпадают и имеют бесконечное количество решений.");
    }
    else if (a1 == a2)
    {
        Console.WriteLine($"Прямые паралельны друг другу и не имеют точек пересечения.");
    }
    else
    {
        double x = (c2 - c1) / (a1 - a2);
        Console.Write($"Точка пересечения ({x}; ");
        double y = a2 * x + c2;
        Console.WriteLine($"{y})");
    }
}


Console.Clear();

Console.Write($"Введите первую точку, первого отрезка, k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write($"Введите вторую точку, первого отрезка, b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write($"Введите первую точку, первого отрезка, k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write($"Введите вторую точку, первого отрезка, b2: ");
double b2 = double.Parse(Console.ReadLine()!);


IntersectionPoint(k1, k2, b1, b2);
