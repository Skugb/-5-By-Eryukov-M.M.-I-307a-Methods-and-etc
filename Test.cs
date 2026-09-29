using MathLesson;
using TestConsole;
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Enter Count of Element: ");
var arraylength = int.Parse(Console.ReadLine());
int[] numbers = new int[arraylength];
for (int i = 0; i < arraylength; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

ClsMath math = new ClsMath();
double sumResult = math.sum(numbers);
Console.WriteLine($"Sum: {sumResult}");

double maxResult = math.max(numbers);
Console.WriteLine($"Max: {maxResult}");

double minResult = math.min(numbers);
Console.WriteLine($"Min: {minResult}");

double countResult =  math.count(numbers);
Console.WriteLine($"Count: {countResult}");