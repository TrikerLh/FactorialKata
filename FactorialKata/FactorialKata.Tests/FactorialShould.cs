using FluentAssertions;

namespace FactorialKata.Tests
{
    public class FactorialShould
    {
        [TestCase(0, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        public void Return_factorial(int number, int expected)
        {
            var result = Factorial.Get(number);

            result.Should().Be(expected);
        }
    }
}
