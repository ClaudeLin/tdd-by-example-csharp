namespace tdd_by_example_the_money
{
    public class Money : IExpression
    {
        public readonly int Amount;
        private readonly string _currency;


        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return Amount == money.Amount && _currency.Equals(money._currency);
        }

        public override string ToString()
        {
            return Amount + " " + _currency;
        }

        public Money Reduce(string to)
        {
            var rate=_currency.Equals("CHF") && to.Equals("USD") ? 2 : 1;
            return new Money(Amount / rate, to);
        }

        public static Money Dollar(int amount)
        {
            return new(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new(amount, "CHF");
        }

        public string Currency()
        {
            return _currency;
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }
    }
}