namespace tdd_by_example_the_money
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return Amount == money.Amount && GetType().Equals(money.GetType());
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}