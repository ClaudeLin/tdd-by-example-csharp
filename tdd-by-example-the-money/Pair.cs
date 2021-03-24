namespace tdd_by_example_the_money
{
    public class Pair
    {
        private string from;
        private string to;

        public Pair(string from,string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object? obj)
        {
            var pair = (Pair) obj;
            return from.Equals(pair.from) && to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}