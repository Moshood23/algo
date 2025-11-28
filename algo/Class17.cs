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


        public char[] GetUniqueElements(char[]arr1, char[] arr2)
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

}

 

      
