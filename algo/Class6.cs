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

}




