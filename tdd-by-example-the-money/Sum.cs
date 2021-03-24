namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public readonly IExpression Augend;
        public readonly IExpression Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank,to).Amount + Addend.Reduce(bank,to).Amount;
            return new Money(amount, to);
        }
    }
}