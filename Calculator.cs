using MathLesson;
using System;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.Clear();
    Console.Write("Calculator \n 1.Plus (+) \n 2.Minus(-) \n 3. Divide (/) \n 4. Multiply (*) \n 5. Factorial (n!) \n 6. Sort (n1 -> n2) \n 7. Percent (%) \n 8. Squaring(n^2) \n 9. Cube (n^3) \n 10. Square Root(n^-2) \n 11. Cube Root(n^-3) \n 12. Sum \n 13. Max \n 14. Min \n 15. Count \n Exit - for exit");

    Console.Write("First num: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Error: not a number!");
        continue;
    }

    Console.Write("Operation (+, -, *, /, F, %. ^2, ^3, ^-2, ^-3, Sort, Sum, Mim, Max, Count): ");
    string operation = Console.ReadLine();

    Console.Write("Second num: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Error: not a number!");
        continue;
    }

    double result = 0;

    switch (operation)
    {   

        case "+": /* Plus */
            result = num1 + num2;
            continue;




        case "-": /* Minus */
            result = num1 - num2;
            continue;




        case "/": /* Divide */
            result = num1 / num2;
            continue;




        case "*": /* Multiply */
            result = num1 * num2;
            continue;




        case "F": /* Factorial */
            for (int i = 2; i <= num1; i++)
            {
                result *= i;
            }
            continue;


        case "%": /* Percent */
            double number = Convert.ToInt32(Console.ReadLine());
            result = result % number;
            continue;




        case "^2": /* Squaring */
            result = result * result;
            continue;

        case "^3": /* Cube */
            result = result * result * result;
            continue;




        case "^-2": /* Square Root */;
            result = Math.Sqrt(result);
            continue;




        case "^-3": /* Cube Root */
            result = Math.Pow(result, 1.0 / 3.0);
            continue;

        /* Working with array */

        case "Sort": /* Sort */
            ClsMath math = new ClsMath();
            var arraylength = int.Parse(Console.ReadLine());
            double[] numbers = new double[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            continue;

        case "Sum": /* Sum */
            ClsMath math = new ClsMath();
            var arraylength = int.Parse(Console.ReadLine());
            double[] numbers = new double[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            ClsMath math = new ClsMath();
            double sumResult = math.sum(numbers);
            Console.WriteLine($"Sum: {sumResult}");
            continue;


        case "Max": /* Max */
            ClsMath math = new ClsMath();
            var arraylength = int.Parse(Console.ReadLine());
            double[] numbers = new double[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            ClsMath math = new ClsMath();
            double maxResult = math.min(numbers);
            Console.WriteLine($"Min: {maxResult}");
            continue;


        case "Min": /* Min */
            ClsMath math = new ClsMath();
            var arraylength = int.Parse(Console.ReadLine());
            double[] numbers = new double[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            ClsMath math = new ClsMath();
            double minResult = math.min(numbers);
            Console.WriteLine($"Min: {minResult}");
            continue;




        case "Count": /* Count */
            ClsMath math = new ClsMath();
            var arraylength = int.Parse(Console.ReadLine());
            double[] numbers = new double[arraylength];

            for (int i = 0; i < arraylength; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            ClsMath math = new ClsMath();
            double countResult = math.count(numbers);
            Console.WriteLine($"Count: {countResult}");
            continue;


        case "exit":
            break;    
    }
}