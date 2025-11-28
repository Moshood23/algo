using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class18
    {
        public static string ListOfCharacter(List<char> list)
        {
            //return new string(list.ToString());
            return string.Join(", ", list.ToArray());
        }



    }
}
