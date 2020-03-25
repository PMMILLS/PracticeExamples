using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExamples.Examples;

namespace PracticeExamplesTests.TestCases
{
    [TestClass]
    public class CoinChangeTests
    {
        private CoinChange coinChange;
        private int[] coins;
        private int m;

        [TestInitialize]
        public void TestSetup()
        {
            coinChange = new CoinChange();
            coins = new int[]{ 1, 5, 10, 20 };
            m = coins.Length;
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(2, coinChange.minCoins(coins, m, 11));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(2, coinChange.minCoins(coins, m, 30));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(7, coinChange.minCoins(coins, m, 87));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(9, coinChange.minCoins(coins, m, 98));
        }
    }
}
