using Airport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Transports
{
    abstract class Transport : ISpendable, IComparable<Transport>
    {
        public string Mark { get; private set; }

        public string Model { get; private set; }

        public int IssueYear { get; private set; }

        public int Consumption { get; private set; }

        public int Weight { get; private set; }
        
        public Transport(string mark, string model, int issueYear, int consumption, int weight)
        {
            Mark = mark;
            Model = model;
            IssueYear = issueYear;
            Consumption = consumption;
            Weight = weight;
        }

        public double GetConsumption()
        {
            return Consumption * Weight / 365;
        }

        public int CompareTo(Transport obj)
        {
            if (obj is Transport)
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

        public override string ToString()
        {
            return $"";
        }
    }
}
