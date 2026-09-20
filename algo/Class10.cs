using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class10
    {
        class AverageSolution
        {
            public static double FindAverage(double[] array)
            {
                if (array.Length == 0)
                    return 0;

                double sum = 0;
                foreach (double num in array)
                {
                    sum += num;
                }

                return sum / array.Length;

            }
        }
    }
}

         

class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        if (array.Length == 0) return 0;
        return array.Average();
    }

    class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1, 2, 3, 4, 5 };
            double average = AverageSolution.FindAverage(numbers);
            Console.WriteLine($"The average of the array is: {average}");
        }
    }

    class Program2
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1, 2, 3, 4, 5 };
            double average = AverageSolution.FindAverage(numbers);
            Console.WriteLine($"The average of the array is: {average}");
        }
    }
}
