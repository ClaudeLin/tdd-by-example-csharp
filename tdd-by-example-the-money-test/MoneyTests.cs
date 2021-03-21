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


            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [Test]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        [Test]
        public void TestSimpleAddition()
        {
            // Money sum = Money.Dollar(5).Plus(Money.Dollar(5));
            // Assert.AreEqual(Money.Dollar(10),sum);
            Money five=Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank=new Bank();
            Money reduced=bank.Reduce(sum,"USD");
            Assert.AreEqual(Money.Dollar(10),reduced);
        }
    }
}