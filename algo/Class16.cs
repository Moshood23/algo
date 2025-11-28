using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class16
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                if (x < 0) return false;

                int num = x;
                int reversed = 0;
                while (num > 0)
                {
                    if (reversed > int.MaxValue / 10) return false;

                    reversed = reversed * 10 + (num % 10);
                    num /= 10;
                }

                return reversed == x;

            }
        }
    }
}

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        char[] moshood = x.ToString().ToCharArray();
        Array.Reverse(moshood);
        string reversed = new string(moshood);
        return reversed == x.ToString();
    }
}