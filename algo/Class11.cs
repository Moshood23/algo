using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Class11
    {

public class WhichAreIn
    {
        public static string[] inArray(string[] a1, string[] a2)
        {
            List<string> result = new List<string>(); // to store matching substrings

            // Loop through each word in a1
            foreach (string sub in a1)
            {
                // Check if this word is a substring of any word in a2
                foreach (string word in a2)
                {
                    if (word.Contains(sub))
                    {
                        // If found and not already in the result, add it
                        if (!result.Contains(sub))
                        {
                            result.Add(sub);
                        }
                        break; // stop checking a2 once we found a match
                    }
                }
            }

            // Sort the result alphabetically
            result.Sort();

            // Convert list to array before returning
            return result.ToArray();
        }
    }

}
}


class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < array1.Length; i++)
        {
            string word = array1[i];
            for (int j = 0; j < array2.Length; j++)
            {
                if (array2[j].Contains(word))
                {
                    if (!result.Contains(word))
                    {
                        result.Add(word);
                    }
                    break;
                }
            }
        }

        result.Sort();
        return result.ToArray();
    }
}
