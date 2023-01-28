//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Пример: a = 5; b = 7 -> max = 7
        //a = 2 b = 10 -> max = 10
        //a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Давайте сравним два числа и выведем на экран большее и меньшее!");
Console.WriteLine("***");

Console.Write("Введите первое чило: ");
int num1 = int.Parse(Console.ReadLine());


Console.Write("Введите второе чило: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("---");

if (num1 > num2)
{
    Console.WriteLine("Первое число является максимальным: " + num1);
    Console.WriteLine("Второе число является минимальным: " + num2);
    Console.WriteLine("---");
    Console.WriteLine("Наибольшее число: " + num1);
    Console.WriteLine("***");
}
else
{
    Console.WriteLine("Второе число является максимальным: " + num2);
    Console.WriteLine("Первое число является минимальным: " + num1);
    Console.WriteLine("---");
    Console.WriteLine("Наибольшее число: " + num2);
    Console.WriteLine("***");
}
Console.WriteLine("Программа выполнена.");
