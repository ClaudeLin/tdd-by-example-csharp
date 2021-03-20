namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        private string _currency;

        public Franc(int amount)
        {
            Amount = amount;
            _currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override string Currency()
        {
            return _currency;
        }
    }
}