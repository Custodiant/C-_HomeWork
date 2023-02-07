// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12


Console.Clear();
Console.WriteLine("Введите любое число и программа выдаст вам сумму цифр в числе.");
Console.WriteLine("***");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;

Console.WriteLine("---");
Console.Write($"Сумма цифр = ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write(SumMass(num));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("***");
Console.WriteLine("Программа, выполнена!");

int SumMass (int OneNum)
{
    int num = 1;
    int sum = 0;
    while (OneNum>0)               //3456      //345       //34        //3     
    {
        num = OneNum % 10;          //6         //5         //4         //3
        OneNum /= 10;               //345       //34        //3         //0 
        sum += num;                 //0+6 =6    //6+5 =11   //11+4 =15  //15+3 =18
    }
    return sum;
}

