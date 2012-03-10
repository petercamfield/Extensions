using NUnit.Framework;

namespace BetaSpline.Extensions.Tests
{
    [TestFixture]
    public class ExtensionFactoryTests
    {
        [Test]
        public void ReturnsStringExtensions()
        {
            Assert.That("string".Extensions(), Is.TypeOf<StringExtensions>());
        }

        [Test]
        public void UsesString()
        {
            var input = "string".Extensions().Format(new {});
            Assert.That(input, Is.EqualTo("string"));
        }

        [Test]
        public void ReturnsIntegerExtensions()
        {
            Assert.That(0.Extensions(), Is.TypeOf<IntegerExtensions>());
        }

        [Test]
        public void UsesInteger()
        {
            var i=0;
            1.Extensions().Times(() => i++);
            Assert.That(i, Is.EqualTo(1));
        }
    }
}