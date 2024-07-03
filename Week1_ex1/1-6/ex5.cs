using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1_ex1;

class ex5
{
    public HashSet<int> GenerateRandomNumbers(int count, int min, int max)
    {
        Random rand = new Random();
        HashSet<int> numbers = new HashSet<int>();

        while (numbers.Count < count)
        {
            numbers.Add(rand.Next(min, max + 1));
        }

        return numbers;
    }
}