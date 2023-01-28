// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Давайте посмотрим все положительные четные числа, от 1 до необходимого вам!");
Console.WriteLine("***");

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 2;
Console.WriteLine("---");

if (num < count)
{
    Console.WriteLine("Ваше число вне диапазона!");
}
else
{
    Console.Write("Все четные чила в диапазоне: ");
    while (num > count)
    {
    Console.Write(count + ", ");
    count ++;
    count ++;
    }
    if (count == num)
    {
        Console.WriteLine(num);
    }
    else                        //Эти строки нужны, для визуального оформления и не более!!
    {                           //Эти строки нужны, для визуального оформления и не более!!
        Console.WriteLine();    //Эти строки нужны, для визуального оформления и не более!!
    }                           //Эти строки нужны, для визуального оформления и не более!!
    if (num < count)
    {
        Console.WriteLine("Ваше число вне диапазона!");
    }
}
Console.WriteLine("***");

Console.WriteLine("Программа, выполнена.");