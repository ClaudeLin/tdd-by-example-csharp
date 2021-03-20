﻿namespace tdd_by_example_the_money
{
    public abstract class Money
    {
        protected int Amount;
        protected string _currency;

        public abstract Money Times(int multiplier);

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return Amount == money.Amount && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }

        public string Currency()
        {
            return _currency;
        }
    }
}