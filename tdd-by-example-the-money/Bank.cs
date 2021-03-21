﻿namespace tdd_by_example_the_money
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            if (source is Money) return (Money) source;
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}