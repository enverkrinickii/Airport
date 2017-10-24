using Airport.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Transports
{
    abstract class Transport : ISpendable, IAirport
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

        public void AddToList(IAirport airport, List<IAirport> myAirport)
        {
            myAirport.Add(airport);
        }
    }
}
