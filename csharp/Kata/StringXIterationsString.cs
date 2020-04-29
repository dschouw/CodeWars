using System;
using System.Linq;

namespace csharp.Kata
{
    public static class StringXIterationsString
    {

        /*
            My first attempt below using Linq and a few Funcs

            Passes the sample tests, but times out when running actual tests.

            !!Puzzle does not string length may exceeed 2 million and iteration count may exceed a billion!!

        */
        public static string StringFunc(string s, long x)
        {
            var watch = new System.Diagnostics.Stopwatch();

            System.Console.WriteLine("String X Iterations -> String");

            watch.Start();

            string result = s;

            System.Func<string, int, string> ReverseFromPosition = (originalString, startPos) =>
            {
                return String.Join("",
                originalString.Substring(0, startPos).Concat(
                originalString.Substring(startPos).Reverse()));

            };

            Func<string, string> ReverseString = (str) =>
            {
                string res = str;
                for (int i = 0; i < s.Length; i++)
                {
                    res = ReverseFromPosition(res, i);
                }
                return res;
            };

            while (x-- > 0)
            {
                result = ReverseString(result);
            }
            watch.Stop();

            System.Console.WriteLine($"Execution time for Linq Reverse {watch.ElapsedMilliseconds} ms");
            return result;

        }

        /*
            This string "String" converted results in "gSntir"

            Relationship : Letter at outer edges swopped, working in

            for int = 0 to length of string

            new string = oldstring[lastchar] + oldstring[firstchar] + oldstring[secondlast] + oldstring[second] + oldstring[thirdlast] + oldstring[third]
        */

        public static string ReverseString(string s, float x)
        {

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            int length = s.Length;

            Func<string, char[]> ReverseStringToCharArr = (str) => {
                char[] array = new char[str.Length];
                for (int i = 0, j = length - 1, l = 0; i < j; i++, j--, l++)
                {
                    array[l] = str[j];
                    array[++l] = str[i];
                }

                return array;
            };

            string reverse = s;

            while (x-- > 0) {
                reverse = new String(ReverseStringToCharArr(reverse));
            }

            watch.Stop();

            System.Console.WriteLine($"Elapsed time for ReverseString with array {watch.ElapsedMilliseconds}");
            return reverse;
        }
    }
}