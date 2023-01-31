// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Выберите любой день и мы проверим:");
Console.WriteLine("Выпадает ли он на выходной!");
Console.WriteLine("***");

string a = "Понедельник";
string b = "Вторник";
string c = "Среда";
string d = "Четверг";
string e = "Пятница";
string f = "Суббота";
string g = "Воскресенье";
int count = 1; //Вывод количества недель для введеного числа. (БОНУС)

Console.WriteLine("Отсчет начнется с понедельника:");
Console.WriteLine($"Будние дни: 1 - {a}, 2 - {b}, 3- {c}, 4 - {d}, 5 - {e}.");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Выходные дни: 6 - {f}, 7 - {g}.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("---");

Console.Write("Введите Любое число: "); // Если нужно ограничить, измените описание
int num = int.Parse(Console.ReadLine());
Console.WriteLine("---");

if (num < 1)
{
    Console.WriteLine("Такого дня недели нет!");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Подсчет недель невозможен");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    while (num > 7) // Если нет необходимости искать среди всех недель, можно убрать. И ограничить ввод в 28 строке!
    {
        num = num -7;
        count++;
    }
    if (num <= 5)
    {
        Console.WriteLine("Вы выбрали  будний день."); //{num}, это
        if (num == 1)
        {
            Console.Write(a);
        }
        if (num == 2)
        {
            Console.Write(b);
        }
        if (num == 3)
        {
            Console.Write(c);
        }
        if (num == 4)
        {
            Console.Write(d);
        }
        if (num == 5)
        {
            Console.Write(e);
        }
    }
    else
    {
        if (num <=7)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Это выходной день!"); //{num}
            if (num == 6)
            {
            Console.Write(f);
            }
            if (num == 7)
            {
            Console.Write(g);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        // else
        // {
        //     Console.WriteLine("В неделе всего 7 дней! Вы ввели неверное число.");  //Данное условие, для вывода данных ограничивающих ввод всего одной недели!!!
        // }
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Ваше число принадлежит {count} неделе");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("***");
Console.WriteLine("Программа, выполнена!");