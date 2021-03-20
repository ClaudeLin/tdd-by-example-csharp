namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }
    }
}