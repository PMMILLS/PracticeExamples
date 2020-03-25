using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExamples.Examples;

namespace PracticeExamplesTests.TestCases
{
    [TestClass]
    public class BalancedBracketsTests
    {
        BalancedBrackets balancedBrackets;

        [TestInitialize]
        public void TestSetup()
        {
            balancedBrackets = new BalancedBrackets();
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue(balancedBrackets.isBalanced("{[()]}"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsTrue(balancedBrackets.isBalanced("{}[]"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsFalse(balancedBrackets.isBalanced("{[)}"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsFalse(balancedBrackets.isBalanced("{}[)"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsFalse(balancedBrackets.isBalanced(""));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsFalse(balancedBrackets.isBalanced("{(})"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsFalse(balancedBrackets.isBalanced("{)}"));
        }
        
        [TestMethod]
        public void Test8()
        {
            Assert.IsFalse(balancedBrackets.isBalanced("((())"));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsFalse(balancedBrackets.isBalanced(")("));
        }
    }
}
