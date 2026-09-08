using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class20
    {
        public static string IntToBinary(int number)
        {
            return Convert.ToString(number, 2);

        }

    }

    public static class Class20Extensions
    {
        public static string ToBinary(this int number)
        {
            return Class20.IntToBinary(number);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 42;
            string binaryRepresentation = number.ToBinary();
            Console.WriteLine($"The binary representation of {number} is {binaryRepresentation}");
        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            int number = 42;
            string binaryRepresentation = Class20.IntToBinary(number);
            Console.WriteLine($"The binary representation of {number} is {binaryRepresentation}");
        }
    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            int number = 42;
            string binaryRepresentation = Class20.IntToBinary(number);
            Console.WriteLine($"The binary representation of {number} is {binaryRepresentation}");
        }
    }

    public class program3
    {
        public static void Main(string[] args)
        {
            int number = 42;
            string binaryRepresentation = Class20.IntToBinary(number);
            Console.WriteLine($"The binary representation of {number} is {binaryRepresentation}");
        }
    }

    public class Program4
    {
        public static void Main(string[] args)
        {
            int number = 42;
            string binaryRepresentation = Class20.IntToBinary(number);
            Console.WriteLine($"The binary representation of {number} is {binaryRepresentation}");
        }
    }
}


    

 