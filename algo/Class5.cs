using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class5
    {
        public static void IfElseFunc(object value, Action ifTrue, Action ifFalse)
            {
            if (Convert.ToBoolean(value))
            {
                ifTrue();
            }
            else
            {
                ifFalse();
            }
        }
    }
}
