using System;
using System.Collections.Generic;

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

            foreach (var digitChar in number.ToString())
            {
                var digit = digitChar - '0';
                if (MagicNumbers.ContainsKey(digit))
                {
                    result += MagicNumbers[digit];
                }
            }

            return result ?? number.ToString();
        }

        private static bool IsDivisibleBy(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
