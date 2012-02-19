using NUnit.Framework;

namespace BetaSpline.Extensions.Tests
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void StringFormattedWithNoPropertiesIsNotUpdated()
        {
            var result =
                new StringExtensions("A string with a {MatchingProperty}").Format(new {});
            Assert.That(result, Is.EqualTo("A string with a {MatchingProperty}"));
        }

        [Test]
        public void StringFormattedWithMatchingPropertyIsUpdatedWithReplacedValue()
        {
            var result =
                new StringExtensions("A string with a {MatchingProperty}").Format(new { MatchingProperty = "replaced value" });
            Assert.That(result, Is.EqualTo("A string with a replaced value"));
        }

        [Test]
        public void StringFormattedWithMatchingPropertyIsUpdatedWithDifferentValue()
        {
            var result = 
                new StringExtensions("A string with a {MatchingProperty}").Format(new { MatchingProperty = "different value" });
            Assert.That(result, Is.EqualTo("A string with a different value"));
        }

        [Test]
        public void StringFormattedWithAnotherPropertyIsUpdatedWithReplacedValue()
        {
            var result = 
                new StringExtensions("A string with a {AnotherProperty}") .Format(new {AnotherProperty = "replaced value"});
            Assert.That(result, Is.EqualTo("A string with a replaced value"));
        }

        [Test]
        public void StringFormattedWithTwoPropertiesIsUpdatedWithPropertyValues()
        {
            var result = 
                new StringExtensions("A {Thing} with a {MatchingProperty}").Format(new { Thing = "string", MatchingProperty = "replaced value" });
            Assert.That(result, Is.EqualTo("A string with a replaced value"));
        }
    }
}
