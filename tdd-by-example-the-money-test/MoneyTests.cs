using NUnit.Framework;
using tdd_by_example_the_money;

namespace tdd_by_example_the_money_test
{
    public class MoneyTests
    {
        [Test]
        public void TestMultiplication()
        {
            var five = Money.Dollar(5);
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
            var five = Money.Franc(5);
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
            var five = Money.Dollar(5);
            var sum = five.Plus(five);
            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [Test]
        public void TestPlusReturnSum()
        {
            var five = Money.Dollar(5);
            var result = five.Plus(five);
            var sum = (Sum) result;
            Assert.AreEqual(five, sum.Augend);
            Assert.AreEqual(five, sum.Addend);
        }

        [Test]
        public void TestReduceSum()
        {
            var sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            var bank = new Bank();
            var result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [Test]
        public void TestReduceMoney()
        {
            var bank = new Bank();
            var result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]
        public void TestReduceMoneyDifferentCurrency()
        {
            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            var result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]
        public void TestIdentityRate()
        {
            Assert.AreEqual(1,new Bank().Rate("USD","USD"));
        }
    }
}