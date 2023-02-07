// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();

Console.WriteLine("Является ли ваше число палиндромом?");
Console.WriteLine("***");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = num;
int num_rev = 0;
int b = 0;

while (num > 0)
{
    b = num % 10;
    num = num / 10;
    num_rev = b + (num_rev * 10);
}

Console.WriteLine("--");
Console.WriteLine($"Перевернутое значение = {num_rev}");
Console.WriteLine("--");

if (num_rev == num1)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ваше число - ПАЛИНДРОМ!");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ваше число - НЕ палиндром!");
    Console.ForegroundColor = ConsoleColor.White;    
}
Console.WriteLine("***");
Console.WriteLine("Программа, выполнена!");