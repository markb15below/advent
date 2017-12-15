using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advent
{
    public class _5NaughtyNice
    {
        public bool IsNice(string input)
        {
            var threeVowels = input.Count(c => "aeiou".Contains(c)) >= 3;

            var foundDouble = false;
            for (var i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1)
                {
                    if (input[i] == input[i + 1])
                    {
                        foundDouble = true;
                        break;
                    }
                }
            }


            var containsNaughtyStrings = input.Contains("ab") || input.Contains("cd") || input.Contains("pq") || input.Contains("xy");

            return threeVowels && foundDouble && !containsNaughtyStrings;
        }
    }
}
