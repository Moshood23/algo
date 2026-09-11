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

    internal class Program19
    {
        public static void Main(string[] args)
        {
            string input = "1 2 3 4 5";
            string result = Class19.HighAndLow(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {result}");
        }
    }

    internal class Program19_2
    {
        public static void Main(string[] args)
        {
            string input = "1 2 3 4 5";
            string result = Class19.HighAndLow(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {result}");
        }
    }

    public class Program19_3
    {
        public static void Main(string[] args)
        {
            string input = "1 2 3 4 5";
            string result = Class19.HighAndLow(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {result}");
        }
    }

    public class Program19_4
    {
        public static void Main(string[] args)
        {
            string input = "1 2 3 4 5";
            string result = Class19.HighAndLow(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {result}");
        }
    }

    internal class Program19_5
    {
        public static void Main(string[] args)
        {
            string input = "1 2 3 4 5";
            string result = Class19.HighAndLow(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {result}");
        }
    }
}
