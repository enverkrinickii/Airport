using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Transports
{
    class PassengerPlane : Transport
    {
        public int MaxPassengerCount { get; private set; }

        public PassengerPlane(string mark, string model, int issueYear, int consumption, int weight, int maxPassengerCount) 
            : base(mark, model, issueYear, consumption, weight)
        {
            MaxPassengerCount = maxPassengerCount;
        }
    }
}
