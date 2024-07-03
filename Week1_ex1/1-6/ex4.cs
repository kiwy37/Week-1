using System;
using System.Text;

namespace Week1_ex1;

class ex4
{
    public string CountCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        StringBuilder result = new StringBuilder();
        int count = 0; 
        char currentChar = '\0';

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                if (count > 0)
                {
                    result.Append(currentChar);
                    result.Append(count);
                    count = 0;
                }
                result.Append(' '); 
                continue;
            }

            if (char.IsLetter(input[i]))
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        result.Append(currentChar);
                        result.Append(count);
                    }
                    currentChar = input[i];
                    count = 1; 
                }
            }
        }

        if (count > 0)
        {
            result.Append(currentChar);
            result.Append(count);
        }

        return result.ToString();
    }
}
