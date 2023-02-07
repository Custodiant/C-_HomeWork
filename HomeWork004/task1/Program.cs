// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число, и программа возведет его в необходимую вам степень.");
Console.WriteLine("***");

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите, в какую степень вы хотите его взвести?: ");
int degree = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("---");

double step = Math.Pow(num, degree);
Console.Write($"{num} в {degree} степени = ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(step);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.OutputEncoding = System.Text.Encoding.Unicode;
const string superscriptDigits = "\u207B\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";
string strDegree = "txt";
string strDegreeMin = null;
if (degree < 0)
{
    strDegreeMin = "\u207B";
    degree = degree * -1;
}
if (degree == 1)
{
    strDegree = "\u00b9";
}
else if (degree == 2)
{
    strDegree = "\u00b2";
}
else if (degree == 3)
{
    strDegree = "\u00b3";
}
else if (degree == 4)
{
    strDegree = "\u2074";
}
else if (degree == 5)
{
    strDegree = "\u2075";
}
else if (degree == 6)
{
    strDegree = "\u2076";
}
else if (degree == 7)
{
    strDegree = "\u2077";
}
else if (degree == 8)
{
    strDegree = "\u2078";
}
else if (degree == 9)
{
    strDegree = "\u2079";
}
else if (degree == 0)
{
    strDegree = "\u2070";
}


// string NumberToSuperscript(int number)
// {
//     string result = string.Empty;

//     bool isNegative = number < 0;

//     int n = Math.Abs(number);
//     while (n > 0)
//     {
//         result = superscriptDigits[n % 10 + 1] + result;
//         n /= 10;
//     }

//     return isNegative ? superscriptDigits[0] + result : result;
// }

Console.WriteLine("или");
Console.Write($"{num}{strDegreeMin}{strDegree} = ");



Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(step);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("***");
Console.WriteLine("Программа, выполнена!");

