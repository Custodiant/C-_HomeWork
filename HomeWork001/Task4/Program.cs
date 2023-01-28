// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Давайте посмотрим все четные числа, от 0 до необходимого вам!");
Console.WriteLine("***");

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 2;
int count2 = -2;
Console.WriteLine("---");

if (num < count)
{
    if (num > count2)
    {
        Console.WriteLine("В диапазоне от 0 до вашего числа - нет четных чисел!");
    }
    else
    {
        Console.WriteLine("Все четные числа - отрицательные.");
        Console.WriteLine("---");
        Console.Write("Числа в диапазоне: ");
        while (num < count2)
        {
            Console.Write(count2 + ", ");
            count2 --;
            count2 --;
        }
        if (count2 == num)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine();
        }
    }    
}

else
{
    Console.WriteLine("Все четные числа - положительные."); 
    Console.WriteLine("---");
    Console.Write("Числа в диапазоне: ");
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
}
Console.WriteLine("***");

Console.WriteLine("Программа, выполнена.");