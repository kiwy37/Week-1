using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1_ex1
{
    class ex6
    {
        public List<string> GetNamesContainingLetter(List<string> names, char letter)
        {
            return names.Where(name => name.Contains(letter))
                        .OrderBy(name => name)
                        .ToList();
        }

        public List<string> GetNamesWithMinLength(List<string> names, int minLength)
        {
            return names.Where(name => name.Length >= minLength).ToList();
        }

        public List<string> GetShortestNames(List<string> names)
        {
            if (names == null || names.Count == 0)
            {
                return new List<string>(); 
            }

            List<string> shortestNames = new List<string>();
            int minLength = int.MaxValue; 

            foreach (var name in names)
            {
                int nameLength = name.Length;
                if (nameLength < minLength)
                {
                    shortestNames.Clear();
                    shortestNames.Add(name);
                    minLength = nameLength;
                }
                else if (nameLength == minLength)
                {
                    shortestNames.Add(name);
                }
            }

            return shortestNames;
        }

        public List<string> GetLongestNames(List<string> names)
        {
            if (names == null || names.Count == 0)
            {
                return new List<string>(); 
            }

            List<string> longestNames = new List<string>();
            int maxLength = 0;

            foreach (var name in names)
            {
                int nameLength = name.Length;
                if (nameLength > maxLength)
                {
                    longestNames.Clear();
                    longestNames.Add(name);
                    maxLength = nameLength;
                }
                else if (nameLength == maxLength)
                {
                    longestNames.Add(name);
                }
            }

            return longestNames;
        }

        public int GetNameCount(List<string> names, string targetName)
        {
            return names.Count(name => name.Equals(targetName));
        }
    }
}