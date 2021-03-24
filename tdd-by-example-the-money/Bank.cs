using System.Collections;

namespace tdd_by_example_the_money
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            return (int) this.rates[new Pair(from, to)];
        }
    }
}