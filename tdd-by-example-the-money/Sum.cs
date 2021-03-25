namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public readonly IExpression Augend;
        public readonly IExpression Addend;

        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank,to).Amount + Addend.Reduce(bank,to).Amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this,Addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }
    }
}