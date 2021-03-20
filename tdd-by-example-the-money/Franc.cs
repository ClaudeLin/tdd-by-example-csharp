﻿namespace tdd_by_example_the_money
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override string Currency()
        {
            return "CHF";
        }
    }
}