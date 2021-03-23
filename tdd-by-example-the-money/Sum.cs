namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public readonly Money Augend;
        public readonly Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}