namespace tdd_by_example_the_money
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}