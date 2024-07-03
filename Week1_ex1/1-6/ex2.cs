using System;
using System.Collections.Generic;

namespace Week1_ex1;

class ex2
{
    public bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 26)
        {
            return false;
        }

        HashSet<char> letters = new HashSet<char>();

        var inputLower = input.ToLower();

        foreach (char c in inputLower)
        {
            if (char.IsLetter(c))
            {
                letters.Add(c);

                if (letters.Count == 26)
                {
                    return true; 
                }
            }
        }

        return letters.Count == 26;
    }
}
