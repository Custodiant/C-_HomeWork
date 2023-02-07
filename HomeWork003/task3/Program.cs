//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Давайте построим таблицу кубов всех чисел, от 1 до любого вашего числа.");
Console.WriteLine("***");
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("---");

int count = 1;
int qCount = 1;
while (count < num)
{
    qCount = count*count*count;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{qCount}, ");
    Console.ForegroundColor = ConsoleColor.White;
    count++;
}
qCount = count*count*count;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"{qCount}. ");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine();
Console.WriteLine("***");
Console.WriteLine("Программа, выполнена!");