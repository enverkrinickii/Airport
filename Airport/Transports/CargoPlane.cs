using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Transports
{
    class CargoPlane : Transport
    {
        public int MaxLoad { get; private set; }

        public CargoPlane(string mark, string model, int issueYear, int consumption, int weight, int maxLoad) 
            : base(mark, model, issueYear, consumption, weight)
        {
            MaxLoad = maxLoad;
        }

    }
}
