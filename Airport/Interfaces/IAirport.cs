using System;
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
        //void PrintTransports();
        //void PrintEmployees();
        void SortTransports();
        void FindPlane(int min, int max);
        void SerializeEmpoyee();
        void SerializeTransport();
        void DeserializeEmployee();
        void DeserializeTransports();
    }
}
