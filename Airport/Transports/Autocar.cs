namespace Airport.Transports
{
    class Autocar : Transport
    {
        public int MaxBaggage { get; private set; }

        public Autocar(string mark, string model, int issueYear, int consumption, int weight, int maxBaggage) 
            : base(mark, model, issueYear, consumption, weight)
        {
            MaxBaggage = maxBaggage;
        }
    }
}
