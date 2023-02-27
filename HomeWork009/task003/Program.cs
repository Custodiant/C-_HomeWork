/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */



int FuncsAkkerman(int num, int num2)
{
    if (num == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return FuncsAkkerman(num - 1, 1);
    }
    else
    {
        return FuncsAkkerman(num - 1, FuncsAkkerman(num, num2 - 1));
    }
}

Console.Clear();
Console.WriteLine("Введите 1 натуральное число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2 натуральное число:");
int number2 = int.Parse(Console.ReadLine()!);

if (number >= 0 && number2 >= 0)
{
    Console.WriteLine("Вычисление:");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(FuncsAkkerman(number, number2));
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Одно, или оба из чисел, меньше нуля!");
    Console.ResetColor();
}
