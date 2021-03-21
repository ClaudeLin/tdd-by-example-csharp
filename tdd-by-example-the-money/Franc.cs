﻿namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public  override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier,_currency);
        }
    }
}