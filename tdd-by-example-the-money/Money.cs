namespace tdd_by_example_the_money
{
    public abstract class Money
    {
        protected int Amount;

        public abstract Money Times(int multiplier);
        
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