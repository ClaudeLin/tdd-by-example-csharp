using NUnit.Framework;

namespace tdd_by_example_the_money_test
{
    public class MoneyTests
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }
    }

    public class Dollar
    {
        public int Amount=10;

        public Dollar(int amount)
        {
        }

        public void Times(int multiplier)
        {
        }
    }
}