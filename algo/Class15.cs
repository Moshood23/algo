using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class15
    {
        public static bool IsProductOdd(int a, int b, int c)
        {
            return ((a * b * c) % 2 == 0);
        }


        public static int IsProductEven(int a, int b, int c)
        {
            return (a * b * c) % 2;
        }

        public static int Bigger(int num1, int num2)
        {
            List<int> list = new List<int>();
            list.Add(num1);
            list.Add(num2);
            int[] result = list.ToArray();
            return result.Min();
        }
    }
        public class House
    {
        public static int GetIndex(string name, char myChar)
        {
            return name.IndexOf(myChar);
        }
    }
}