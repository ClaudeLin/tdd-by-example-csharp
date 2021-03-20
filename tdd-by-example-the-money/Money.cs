namespace tdd_by_example_the_money
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object? obj)
        {
            return Amount == ((Dollar) obj).Amount;
        }
    }
}