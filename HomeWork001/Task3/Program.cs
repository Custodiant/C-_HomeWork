// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Проверим чило на чётность?");
Console.WriteLine("***");

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("---");

if (num %2 == 0)
{
    Console.WriteLine("Число " + num + " ,является чётным! ");
}
else
{
    Console.WriteLine("Не чётное!");
}
Console.WriteLine("***");

Console.WriteLine("Программа, выполнена.");