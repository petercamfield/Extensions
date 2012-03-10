using System.Collections.Generic;
using NUnit.Framework;

namespace BetaSpline.Extensions.Tests
{
    [TestFixture]
    public class IntegerExtensionTests
    {
        private IList<int> invocations;

        [SetUp]
        public void BeforeEveryTest()
        {
            invocations = new List<int>();
        }

        [Test]
        public void LoopsOnce()
        {
            new IntegerExtensions(1).Times(RecordInvocation);
            Assert.That(invocations, Has.Count.EqualTo(1));
        }

        [Test]
        public void LoopsTwice()
        {
            new IntegerExtensions(2).Times(RecordInvocation);
            Assert.That(invocations, Has.Count.EqualTo(2));
        }

        [Test]
        public void LoopsOnceWithIndex()
        {
            new IntegerExtensions(1).Times(RecordInvocationWithIndex);
            Assert.That(invocations, Is.EqualTo(new List<int> {0}));
        }

        [Test]
        public void LoopsTwiceWithIndex()
        {
            new IntegerExtensions(2).Times(RecordInvocationWithIndex);
            Assert.That(invocations, Is.EqualTo(new List<int> {0, 1}));
        }

        private void RecordInvocation()
        {
            RecordInvocationWithIndex(0);
        }

        private void RecordInvocationWithIndex(int index)
        {
            invocations.Add(index);
        }
    }
}