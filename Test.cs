using MathLesson;
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Enter Count of Element");
var arraylength = int.Parse(Console.ReadLine());
int[] array = new int[arraylength];
for (int i = 0; i < arraylength; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

ClsMath math = new ClsMath();
double sumResult = math.sum(array);
Console.WriteLine($"Sum: {sumResult}");

double maxResult = math.max(array);
Console.WriteLine($"Max: {maxResult}");

double minResult = math.min(array);
Console.WriteLine($"Min: {minResult}");

double countResult =  math.count(array);
Console.WriteLine($"Count: {countResult}");