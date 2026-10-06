/*using MathLesson;
using TestConsole;
using System;
using System.Diagnostics.Eventing.Reader;
Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{

    Console.Write("Enter Count of Element: ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Ошибка! Это не целое число. Повторите ввод: ");
    }

    var arraylength = int.Parse(Console.ReadLine());
    double[] numbers = new double[arraylength];

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


    Console.WriteLine("Continue? (y/n)");
    string input = Console.ReadLine();
    if (input?.ToLower() == "n")
    {
        break;
    }
    else if (input?.ToLower() == "y")
    {
        continue;
    }
}*/