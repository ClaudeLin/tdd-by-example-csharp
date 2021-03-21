namespace tdd_by_example_the_money
{
    public class Money:IExpression
    {
        public readonly int _amount;
        private readonly string _currency;


        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return _amount == money._amount && _currency.Equals(money._currency);
        }

        public override string ToString()
        {
            return _amount + " " + _currency;
        }

        public Money Reduce(string to)
        {
            return this;
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