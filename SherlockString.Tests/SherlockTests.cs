namespace SherlockString.Tests
{
    public class SherlockTests
    {
        private Sherlock _sherlock;

        [SetUp]
        public void Setup()
        {
            _sherlock = new Sherlock();
        }

        [TestCase("abcdefghhgfedeecba")]
        [TestCase("aabbcd")]
        [TestCase("aabbccddeefghi")]
        [TestCase("aabbbccddeefghi")]
        [TestCase("aaaaaabbbbbbbx")]
        public void TestsExpectingFalse(string input)
        {
            var returnString = _sherlock.SherlockChecker(input);
            Assert.That(returnString, Is.EqualTo("NO"));
        }

        [TestCase("abcdefghhgfedecba")]
        [TestCase("aaaaaabbbbbbb")]
        public void TestsExpectingTrue(string input)
        {
            var returnString = _sherlock.SherlockChecker(input);
            Assert.That(returnString, Is.EqualTo("YES"));
        }
    }
}