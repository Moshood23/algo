using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class12;

        public static string GroupByCommas(int n)
        {
            string s = n.ToString();
            List<string> parts = new List<string>();

            while (s.Length > 3)
            {
                parts.Add(s.Substring(s.Length - 3));
                s = s.Substring(0, s.Length - 3);
            }

            parts.Add(s);
            parts.Reverse();
            return string.Join(",", parts);
}        