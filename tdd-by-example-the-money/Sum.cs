namespace tdd_by_example_the_money
{
    public class Sum : IExpression
    {
        public Money Augend;
        public Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(string to)
        {
            var amount = Augend._amount + Addend._amount;
            return new Money(amount, to);
        }
    }
}