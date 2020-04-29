using System.Linq;

namespace csharp.Kata
{
    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            /*
                Use Select LINQ operator as a projection operator to transform the elements of a IQueryable

                First use Where to filter, then Select

                String.Join joins elements in IEnumerable<Object> using the seperator specified as first parameter
            */

            System.Console.WriteLine("Replace with Alphabet Position");
            var result = string.Join (" ", text.ToUpper()
                .Where( _ => char.IsLetter(_))
                .Select( _ => (System.Convert.ToInt32(_) - 64))
                .ToArray()
            );

            return result; 
        }
    }

    /*
        Best Answer :
        return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
    */
}