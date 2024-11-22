using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Exercises001
    {
        public static Func<int, int> AddOne {  get; set; } = (x) => x + 1;
        public static Func<int, int> SquareIt = (x) => x * x;
        public static Func<int, int> AddTen = (x) => x + 10;
        public static Predicate<string> GrammarCheck = (str) => str[0] == 'A' && str[^1] == '!';

        public static Func<string, string, int> SumIndices = (str1, str2) =>
        {
            int aIndex = str1.IndexOf('a');
            int eIndex = str2.IndexOf("e");
            return aIndex + eIndex;
        };
    }
}
