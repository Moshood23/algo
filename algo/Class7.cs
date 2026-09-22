using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class7
    {
    }
}


public class Kata
{
    public static bool IsAnagram(string a, string b)
    {
        char[] firstchar = a.ToLower().ToArray();
        char[] secondchar = b.ToLower().ToArray();
        Array.Sort(firstchar);
        Array.Sort(secondchar);
        string Ade = new string(firstchar);
        string Adee = new string(secondchar);
        if (Ade == Adee)
        {
            return true;
        }
        else return false;

    }

    public static bool IsAnagram2(string a, string b)
    {
        char[] firstchar = a.ToLower().ToArray();
        char[] secondchar = b.ToLower().ToArray();
        Array.Sort(firstchar);
        Array.Sort(secondchar);
        string Ade = new string(firstchar);
        string Adee = new string(secondchar);
        return Ade == Adee;
    }   

    public static bool IsAnagram3(string a, string b)
    {
        return String.Concat(a.ToLower().OrderBy(c => c)) == String.Concat(b.ToLower().OrderBy(c => c));
    }   
}