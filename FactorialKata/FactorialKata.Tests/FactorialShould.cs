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

        [Test]
        public void Return_2() {
            var result = Factorial.Get(2);

            result.Should().Be(2);
        }

        [Test]
        public void Return_6() {
            var result = Factorial.Get(3);

            result.Should().Be(6);
        }
    }
}