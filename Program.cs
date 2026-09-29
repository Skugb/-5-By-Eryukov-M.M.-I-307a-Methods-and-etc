using System;
using System.Collections.Generic;
using System.Text;

namespace MathLesson
{
    internal class ClsMath
    {
        public double sum(int[] numbers)
        {
            double result = numbers[0];
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        public double max(int[] numbers)
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
        public double min(int[] numbers)
        {
            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }
        public double count(int[] numbers)
        {
            return numbers.Length;
        }
    }
}