using NUnit.Framework;
using tdd_by_example_the_money;

namespace tdd_by_example_the_money_test
{
    public class MoneyTests
    {
        [Test]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));

            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));

            Assert.IsFalse(new Franc(5).Equals(Money.Dollar(5)));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            var five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }
    }
}