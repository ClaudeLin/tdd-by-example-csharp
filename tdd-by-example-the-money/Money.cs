namespace tdd_by_example_the_money
{
    public class Money:IExpression
    {
        private readonly int _amount;
        private readonly string _currency;


        private Money(int amount, string currency)
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
            return new Money(_amount + addend._amount,addend._currency);
        }
    }
}