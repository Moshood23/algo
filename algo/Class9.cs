using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class9
    {
    }
        
       namespace Solution
    {
        public class TwiceAsOldSolution
        {
            public static int TwiceAsOld(int dadYears, int sonYears)
            {
                int result = dadYears - (sonYears * 2);
                return Math.Abs(result);
            }
        }
    }
}

