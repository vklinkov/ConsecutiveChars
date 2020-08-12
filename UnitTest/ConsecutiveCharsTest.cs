using NUnit.Framework;
using ConsecutiveChars;

namespace ConsecutiveCharsTest
{
    public class ConsecutiveCharsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("aaabbcccccdddde", 1, "abcde")]
        [TestCase("aaabbcccccdddde", 2, "aabbccdde")]
        [TestCase("aaabbcccccdddde", 3, "aaabbcccddde")]
        [TestCase("aaabbcccccdddde", 4, "aaabbccccdddde")]
        [TestCase("", 5, "")]
        [TestCase(null, 1, "")]
        public void RemoveConsecutiveCharsByInputAmount(string input, int limit, string expectedOutput)
        {
            Assert.AreEqual(input.RemoveConsecutiveChars(limit), expectedOutput);
        }
    }
}