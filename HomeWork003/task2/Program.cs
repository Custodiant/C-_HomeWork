// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты двух точек в 3D пространстве (X, Y, Z),");
Console.WriteLine("и программа найдёт расстояние между ними.");
Console.WriteLine("***");
Console.Write("Введите координаты первой точки: ");
Console.WriteLine();
Console.Write("X = ");
int x1 = int.Parse(Console.ReadLine()!)!;
Console.Write("Y = ");
int y1 = int.Parse(Console.ReadLine()!)!;
Console.Write("Z = ");
int z1 = int.Parse(Console.ReadLine()!)!;

Console.WriteLine();
Console.Write("Введите координаты второй точки: ");
Console.WriteLine();
Console.Write("X = ");
int x2 = int.Parse(Console.ReadLine()!)!;
Console.Write("Y = ");
int y2 = int.Parse(Console.ReadLine()!)!;
Console.Write("Z = ");
int z2 = int.Parse(Console.ReadLine()!)!;

Console.WriteLine();
Console.Write($"Первая точка находится в координатах = ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"(X:{x1}, Y:{y1}, Z:{z1}).");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.Write($"Вторая точка находится в координатах = ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"(X:{x2}, Y:{y2}, Z:{z2}).");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("---");


double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.Write("Расстояние между двумя точками в пространстве = ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(distance);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("***");
Console.WriteLine("Программа, выполнена!");