using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class6
    {
        public static int Add(int a, int b)
        {
            return a + b;

        }

        public static int Multiply(int a, int b)
        {
            return a * b;

        }


        public static int Divide(int a, int b)
        {
            return a % b;


        }

        public static char GetFirstChar(string str)
        {
            char firstChar = str[0];
            return firstChar;

        }

        public static string FirstTwoToUpper(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return str.Substring(0, 2).ToUpper() + str.Substring(2);



        }

        public static List<int> GetTwoNumber(List<int> numbers)
        {
            var myNum = numbers.ToString();
            List<int> result = [myNum[0], myNum[1]];
            return result;
        }
       
    }
    public class Program6
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int sum = Class6.Add(a, b);
            Console.WriteLine($"Sum of {a} and {b} is: {sum}");
            int product = Class6.Multiply(a, b);
            Console.WriteLine($"Product of {a} and {b} is: {product}");
            int remainder = Class6.Divide(a, b);
            Console.WriteLine($"Remainder of {a} divided by {b} is: {remainder}");
            string str = "hello";
            char firstChar = Class6.GetFirstChar(str);
            Console.WriteLine($"First character of '{str}' is: {firstChar}");
            string upperStr = Class6.FirstTwoToUpper(str);
            Console.WriteLine($"String with first two characters in uppercase: {upperStr}");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> twoNumbers = Class6.GetTwoNumber(numbers);
            Console.WriteLine($"First two numbers from the list: {string.Join(", ", twoNumbers)}");
        }
    }

}




