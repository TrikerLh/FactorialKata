using FluentAssertions;

namespace FactorialKata.Tests {
    public class FactorialShould {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Return_1()
        {
            var result = Factorial.Get(0);

            result.Should().Be(1);
        }
    }
}