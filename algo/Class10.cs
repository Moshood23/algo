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
}
