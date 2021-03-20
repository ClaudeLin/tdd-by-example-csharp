namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(Amount * multiplier);
        }
    }
}