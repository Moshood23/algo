using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class19
    {
        public static string HighAndLow(string numbers)
        {
            string[] parts = numbers.Split(' ');
            int max = int.Parse(parts[0]);
            int min = int.Parse(parts[0]);

            foreach (var p in parts)
            {
                int num = int.Parse(p);
                if (num > max) max = num;
                if (num < min) min = num;
            }

            return $"{max} {min}";
        }

    }
}
