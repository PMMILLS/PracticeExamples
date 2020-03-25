using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExamples.Examples;

namespace PracticeExamplesTests.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        Palindrome palindrome;

        [TestInitialize]
        public void TestSetup()
        {
            palindrome = new Palindrome();
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(palindrome.isPalindrome("LEVEL"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsFalse(palindrome.isPalindrome("LEVEP"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsTrue(palindrome.isPalindrome("LEL"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsTrue(palindrome.isPalindrome("LEl"));
        }
    }
}
