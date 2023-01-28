// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Пример:
    //2, 3, 7 -> 7
    //44 5 78 -> 78
    //22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите три числа, и я покажу наибольшее из них!");
Console.WriteLine("***");

Console.Write("Введите первое чило: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе чило: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье чило: ");
int num3 = int.Parse(Console.ReadLine());

int max = 0;

// if (max < num1)
// {
//     max = num1;
// }
// if (max < num2)          /// Данный код не работает в отрицательном диапазоне
// {
//     max = num2;
// }
// if (max < num3)
// {
//     max = num3;
// }

if (num1 > num2)
{
    if (num1 > num3)
    {
        max = num1;
    }
    else
    {
        max = num3;
    }
}
else
{
    if (num2 > num3)
    {
        max = num2;
    }
    else
    {
        max = num3;
    }
}


Console.WriteLine("***");
Console.WriteLine("Наибольшее число: " + max);