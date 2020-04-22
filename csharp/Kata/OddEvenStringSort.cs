using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp.Kata
{
    /*
    Given a string S. You have to return another string such that even-indexed and odd-indexed characters of S are grouped and groups are space-separated (see sample below)

    Note: 
    0 is considered to be an even index. 
    All input strings are valid with no spaces
    input: 'CodeWars'
    output 'CdWr oeas'
*/
    public static class OddEvenStringSort
    {
        public static string SortMyString(string s)
        {
            string result;

            result = new String(s
            .Where((chr, idx) => (idx % 2) == 0)
            .Concat(new List<char> { ' ' })
            .Concat(
                s
                .Where((chr, idx) => idx % 2 != 0)
                )
                .ToArray()


            );


            return result;
        }
    }
}