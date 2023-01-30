// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Давайте загадаем число от 1 до 999999 и проверим, есть ли в нём третья цифра:");

int num = new Random().Next(1,999999);
Console.WriteLine("***");
Console.WriteLine($"Загаданное число: {num}");
Console.WriteLine("---");
Console.Write("Можете загадать любое ваше число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("***");

if (num < 100)
{
    Console.WriteLine($"В рандомном числе, Третьей цифры НЕТ!");
}
else 
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int a = num % 10;
    Console.WriteLine($"Третья цифра рандомного числа, {a}");
}
Console.WriteLine("---");
if (b < 100)
{
    Console.WriteLine($"В Вашем числе, Третьей цифры НЕТ!");
}
else 
{
    while (b > 1000)
    {
        b = b / 10;
    }
    int c = b % 10;
    Console.WriteLine($"Третья цифра Вашего числа, {c}");
}
Console.WriteLine("***");
Console.WriteLine("Программа, выполнена");