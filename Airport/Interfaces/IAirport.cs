using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Employee;
using Airport.Transports;

namespace Airport.Interfaces
{
    interface IAirport
    {
        void AddTransport(AbstractTransport transport);
        void AddEmployee(AbstractEmployee employee);
        int GetGeneralMaxPassengerCount();
        int getGeneralMaxLoad();
        void PrintTransports();
        void PrintEmployees();
        void SortTransports();
        void FindPlane(int min, int max);
    }
}
