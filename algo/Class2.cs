using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo;

internal class Class2
{
    public static bool IsProductOdd (int a, int b, int c )
    {
      return ((a * b * c) %2 == 0);
        }
       
    }

internal class Class2Extensions
{
    public static bool IsProductOdd(this int a, int b, int c)
    {
        return Class2.IsProductOdd(a, b, c);
    }

}

internal class Program2
{
    public static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int c = 7;
        bool isProductOdd = Class2.IsProductOdd(a, b, c);
        Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
    }
}

internal class Program2Extensions
{
    public static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int c = 7;
        bool isProductOdd = a.IsProductOdd(b, c);
        Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
    }
}

internal class Program2Extensions2
{
    public static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int c = 7;
        bool isProductOdd = Class2Extensions.IsProductOdd(a, b, c);
        Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
    }
}

internal class Program2Extensions3
{
    public static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int c = 7;
        bool isProductOdd = Class2Extensions.IsProductOdd(a, b, c);
        Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
    }

    internal class Program2Extensions4
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            bool isProductOdd = Class2Extensions.IsProductOdd(a, b, c);
            Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
        }
    }

    internal class Program2Extensions5
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            bool isProductOdd = Class2Extensions.IsProductOdd(a, b, c);
            Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
        }
    }

    internal class Program2Extensions6
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            bool isProductOdd = Class2Extensions.IsProductOdd(a, b, c);
            Console.WriteLine($"Is the product of {a}, {b}, and {c} odd? {isProductOdd}");
        }
    }
}





