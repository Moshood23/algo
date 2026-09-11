using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class17
    {
        public List<int> GetUniqueElements(List<int> list1, List<int> list2)
        {
            var result = list1.Except(list2).ToList();
            result.AddRange(list2.Except(list1));
            return result;
        }


        public char[] GetUniqueElements(char[] arr1, char[] arr2)
        {
            var result = arr1.Except(arr2).ToList();
            result.AddRange(arr1.Except(arr2));
            return result.ToArray();

        }

        public List<char> GetUniqueElements(List<char> list1, List<char> list2)
        {
            var result = list1.Except(list2).ToList();
            result.AddRange(list2.Except(list1));
            return result;
        }

    }
    public class Program17
    {
        public static void Main(string[] args)
        {
            var class17 = new Class17();
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };
            var uniqueInts = class17.GetUniqueElements(list1, list2);
            Console.WriteLine(uniqueInts.ToString());
        }
    }

    public class Program17_2
    {
        public static void Main(string[] args)
        {
            var class17 = new Class17();
            char[] arr1 = new char[] { 'a', 'b', 'c', 'd' };
            char[] arr2 = new char[] { 'c', 'd', 'e', 'f' };
            var uniqueChars = class17.GetUniqueElements(arr1, arr2);
            Console.WriteLine(uniqueChars.ToString());
        }
    }
}
        


 

      
