using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Employee;
using Airport.Interfaces;
using Airport.Transports;

namespace Airport.MyAirport
{
    class MyAirPort : IAirport
    {
        List<AbstractTransport> myTransports = new List<AbstractTransport>();
        List<AbstractEmployee> myEmployees = new List<AbstractEmployee>();

        public void AddTransport(AbstractTransport transport)
        {
            myTransports.Add(transport);
        }

        public void AddEmployee(AbstractEmployee employee)
        {
            myEmployees.Add(employee);
        }

        public int GetGeneralMaxPassengerCount()
        {
            int sum = 0;
            foreach (var transport in myTransports)
            {
                if (transport is PassengerPlane)
                {
                    sum += (transport as PassengerPlane).MaxPassengerCount;
                }
            }
            return sum;
        }

        public int getGeneralMaxLoad()
        {
            int sum = 0;
            foreach (var transport in myTransports)
            {
                if (transport is CargoPlane)
                {
                    sum += (transport as CargoPlane).MaxLoad;
                }
            }
            return sum;
        }

        public void PrintTransports()
        {
            foreach (var transport in myTransports)
            {
                Console.WriteLine(transport.ToString());
            }
        }

        public void PrintEmployees()
        {
            foreach (var employee in myEmployees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        public void SortTransports()
        {
            myTransports.Sort();
        }

        public void FindPlane(int min, int max)
        {
            bool isExist = false;
            foreach (var transport in myTransports)
            {
                if (transport.Consumption >= min && transport.Consumption <= max)
                {
                    isExist = true;
                    Console.WriteLine(transport.Mark + " " + transport.Model);
                }

            }
            if (!isExist)
            {
                Console.WriteLine("Самолетов по заданным критериям не найдено!");
            }
        }
    }
}
