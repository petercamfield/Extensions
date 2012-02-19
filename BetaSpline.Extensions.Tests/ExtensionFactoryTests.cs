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
        public void UsesStringAsInput()
        {
            Assert.That(InputOf("string".Extensions()), Is.EqualTo("string"));
        }

        private static string InputOf(StringExtensions stringExtensions)
        {
            return stringExtensions.Format(new {});
        }
    }
}