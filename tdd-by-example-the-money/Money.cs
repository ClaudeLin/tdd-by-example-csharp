namespace tdd_by_example_the_money
{
    public class Money
    {
        protected int Amount;
        protected string _currency;


        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public Money Times(int multiplier)
        {
            return null;
        }

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return Amount == money.Amount && GetType().Equals(money.GetType());
        }


        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return _currency;
        }
    }
}