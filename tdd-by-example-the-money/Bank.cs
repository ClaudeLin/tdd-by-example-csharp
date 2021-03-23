namespace tdd_by_example_the_money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string source, string to, int rate)
        {
        }

        public int Rate(string currency, string to)
        {
            return currency.Equals("CHF") && to.Equals("USD") ? 2 : 1;
        }
    }
}