namespace tdd_by_example_the_money
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Money Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}