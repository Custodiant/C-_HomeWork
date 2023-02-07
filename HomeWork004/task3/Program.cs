// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.Clear();
Console.WriteLine("Давайте посмотрим массив из 8 элементов.");
Console.WriteLine("***");
Console.WriteLine("Массив");

Console.ForegroundColor = ConsoleColor.Green;
PrintArray(GenerateArray());
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("***");

Console.WriteLine("Программа, выполнена!");



int [] GenerateArray()
{
    int [] SummArray = new int[8];
    for (int count = 0; count <= 7; count++)
    SummArray[count] = new Random().Next (0,9);
    return SummArray;
}
void PrintArray(int[] number)
{
    Console.Write("[");
    for (int count = 0; count <= (number.Length - 2); count++) 
    Console.Write($"{number[count]},");
    Console.WriteLine($"{number[number.Length - 1]}]");
}

