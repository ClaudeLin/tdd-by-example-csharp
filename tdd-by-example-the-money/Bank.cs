namespace tdd_by_example_the_money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            Sum sum = (Sum)source;

            return Reduce(to, sum);
        }

        private Money Reduce(string to, Sum sum)
        {
            int amount = sum.Augend._amount + sum.Addend._amount;
            return new Money(amount, to);
        }
    }
}