using System;
using System.Collections.Generic;
using System.Text;


namespace MathLesson
{
    internal class ClsMath
    {

        public double plus(double result, double number)
        {
            double result = result + number;
            return result;
        }




        public double minus(double result, double number)
        {
            var result = n1-n2;
            return result;
        }



        public double divide(double result, double number)
        {
            var result = result / number;
            return result;
        }




        public double multiply(double result, double number)
        {
            var result = result * number;
            return result;
        }




        public double factorial(double result)
        {
            for (int i = 2; i <= result; i++)
            {
                result *= i;
            }
            return result;
        }




        public double sort(double[] result)
        {
            return Array.Sort(result);
        }




        public double percent(double result, double number)
        {
            var mathresult = result % number;
            return mathresult;
        }




        public double squaring(double number)
        {
            var mathresult = result * result;
            return mathresult;
        }




        public double cube(double number)
        {
            var mathresult = number*number*number;
            return mathresult;
        }




        public double square_root(double number)
        {
            var mathresult = Math.Sqrt(number);
            return mathresult;
        }




        public double cube_root(double number)
        {
            var mathresult = Math.Pow(number, 1.0/3.0);
            return mathresult;
        }



        public double sum(double[] numbers)
        {
            double mathresult = numbers[0];
            foreach (var number in numbers)
            {
                mathresult += number;
            }
            return mathresult;
        }




        public double max(double[] numbers)
        {
            var mathresult = numbers[0];
            foreach (var number in numbers)
            {
                if (number > result)
                {
                    mathresult = number;
                }
            }
            return mathresult;
        }



        public double min(double[] numbers)
        {
            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }




        public double count(double[] numbers)
        {
            return numbers.Length;
        }

    }
}