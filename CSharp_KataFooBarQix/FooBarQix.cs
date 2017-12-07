using System.Collections.Generic;
using System.Linq;

namespace CSharp_KataFooBarQix
{
    public static class FooBarQix
    {
        private static readonly Dictionary<int, string> MagicNumbers =
            new Dictionary<int, string>
            {
                [3] = "Foo",
                [5] = "Bar",
                [7] = "Qix"
            };

        public static string Process(int number)
        {
            string result = null;

            foreach (var divisor in MagicNumbers.Keys)
            {
                if (number.IsDivisibleBy(divisor))
                {
                    result += MagicNumbers[divisor];
                }
            }

            foreach (var digit in GetDigits(number))
            {
                if (MagicNumbers.ContainsKey(digit))
                {
                    result += MagicNumbers[digit];
                }
            }

            return result ?? number.ToString();
        }

        private static IEnumerable<int> GetDigits(int number)
        {
            return number.ToString().Select(digitChar => digitChar - '0');
        }

        private static bool IsDivisibleBy(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
