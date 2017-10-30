using System;
using System.Collections.Generic;
using Airport.Employee;
using Airport.Interfaces;
using Airport.Transports;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Airport.MyAirport
{
    class MyAirPort : IAirport
    {
        List<AbstractTransport> MyTransports = new List<AbstractTransport>();
        List<AbstractEmployee> MyEmployees = new List<AbstractEmployee>();

        BinaryFormatter formatter = new BinaryFormatter();

        public void AddTransport(AbstractTransport transport)
        {
            MyTransports.Add(transport);
        }

        public void AddEmployee(AbstractEmployee employee)
        {
            MyEmployees.Add(employee);
        }

        public int GetGeneralMaxPassengerCount()
        {
            int sum = 0;
            foreach (var transport in MyTransports)
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
            foreach (var transport in MyTransports)
            {
                if (transport is CargoPlane)
                {
                    sum += (transport as CargoPlane).MaxLoad;
                }
            }
            return sum;
        }

        private void PrintTransports(List<AbstractTransport> transports)
        {
            foreach (var transport in transports)
            {
                Console.WriteLine(transport.ToString());
            }
        }

        private void PrintEmployees(List<AbstractEmployee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        public void SortTransports()
        {
            MyTransports.Sort();
        }

        public void FindPlane(int min, int max)
        {
            bool isExist = false;
            foreach (var transport in MyTransports)
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

        public void SerializeEmpoyee()
        {
            using (FileStream fs = new FileStream("employees.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, MyEmployees);
            }
        }

        public void SerializeTransport()
        {
            using (FileStream fs = new FileStream("transports.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, MyTransports);
            }
        }

        public void DeserializeEmployee()
        {
            using (FileStream fs = new FileStream("employees.bin", FileMode.OpenOrCreate))
            {
                List<AbstractEmployee> employees = (List<AbstractEmployee>)formatter.Deserialize(fs);

                PrintEmployees(employees);
            }
        }

        public void DeserializeTransports()
        {
            using (FileStream fs = new FileStream("transports.bin", FileMode.OpenOrCreate))
            {
                List<AbstractTransport> transports = (List<AbstractTransport>)formatter.Deserialize(fs);

                PrintTransports(transports);
            }
        }
    }
}
