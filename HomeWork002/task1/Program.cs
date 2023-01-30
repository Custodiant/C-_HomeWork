//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число и программа покажет вам вторую цифру!");
Console.WriteLine("***");
Console.WriteLine("Ваше число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("---");

int a = num / 100;
int b = num % 10;
int c = (num - a*100 - b) / 10;

//Console.WriteLine($"Первая цифра вашего числа - это {a}");
Console.WriteLine($"Вторая цифра вашего числа - это {c}");
//Console.WriteLine($"Вторая цифра вашего числа - это {b}");

Console.WriteLine("***");
Console.WriteLine("Программа, выполнена");
