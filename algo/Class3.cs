using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class3
    {
        public static char GetCharAtIndex(string name, int num)
        {
            if (num >= name.Length || num < 0)
            {
             return 'A';

            }
            else
            {
             return name[num];
             
            }
            
             
            

           
        }

    }
}
