using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace CSharp_KataFooBarQix
{
    class FooBarQixShould
    {
        [Test]
        [Ignore("Remove to enable test")]
        public void Return_number_as_string_when_number_is_regular()
        {
            var result = FooBarQix.Process(1);
            Check.That(result).IsEqualTo("1");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Return_Foo_when_number_is_divisible_by_3()
        {
            var result = FooBarQix.Process(6);
            Check.That(result).IsEqualTo("Foo");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Return_Bar_when_number_is_divisible_by_5()
        {
            var result = FooBarQix.Process(10);
            Check.That(result).IsEqualTo("Bar");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Return_Qix_when_number_is_divisible_by_7()
        {
            var result = FooBarQix.Process(14);
            Check.That(result).IsEqualTo("Qix");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Return_Foo_when_number_contains_a_3()
        {
            var result = FooBarQix.Process(31);
            Check.That(result).IsEqualTo("Foo");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Return_Bar_when_number_contains_a_5()
        {
            var result = FooBarQix.Process(52);
            Check.That(result).IsEqualTo("Bar");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Return_Qix_when_number_contains_a_7()
        {
            var result = FooBarQix.Process(17);
            Check.That(result).IsEqualTo("Qix");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Repeat_Foo_when_number_contains_multiple_3s()
        {
            var result = FooBarQix.Process(313);
            Check.That(result).IsEqualTo("FooFoo");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Repeat_Bar_when_number_contains_multiple_5s()
        {
            var result = FooBarQix.Process(551);
            Check.That(result).IsEqualTo("BarBar");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Repeat_Bar_when_number_contains_multiple_7s()
        {
            var result = FooBarQix.Process(277);
            Check.That(result).IsEqualTo("QixQix");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Write_divisors_before_digits()
        {
            var result = FooBarQix.Process(51);
            Check.That(result).IsEqualTo("FooBar");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Write_digits_from_left_to_right()
        {
            var result = FooBarQix.Process(53);
            Check.That(result).IsEqualTo("BarFoo");
        }

        [Test]
        [Ignore("Remove to enable test")]
        public void Write_divisors_in_ascending_order()
        {
            var result = FooBarQix.Process(210);
            Check.That(result).IsEqualTo("FooBarQix");
        }
    }
}
