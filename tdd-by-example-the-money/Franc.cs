namespace tdd_by_example_the_money
{
    public class Franc
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object? obj)
        {
            return _amount == ((Franc) obj)._amount;
        }
    }
}