using Airport.Interfaces;
using System;

namespace Airport.Transports
{
    [Serializable]
    public abstract class AbstractTransport : IComparable<AbstractTransport>
    {
        public string Mark { get; private set; }

        public string Model { get; private set; }

        public int IssueYear { get; private set; }

        public int Consumption { get; private set; }

        public int Weight { get; private set; }
        
        public AbstractTransport(string mark, string model, int issueYear, int consumption, int weight)
        {
            Mark = mark;
            Model = model;
            IssueYear = issueYear;
            Consumption = consumption;
            Weight = weight;
        }

        public int CompareTo(AbstractTransport obj)
        {
            if (obj is AbstractTransport)
            {
                if (this.Consumption > obj.Consumption)
                    return 1;
                if (this.Consumption < obj.Consumption)
                    return -1;
                else return 0;
            }
            else
            {
                throw new Exception("Wrong object type");
            }
        }

    }
}
