using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Interfaces;

namespace Airport.Employee
{
    abstract class AbstractEmployee : IAirport, IComparable
    {
        public string Name { get; private set; }

        public string SecondName { get; private set; }

        public int Age { get; private set; }

        public int Status { get; private set; }

        public int Salary => Status * 1000;

        protected AbstractEmployee(string name, string secondName, int age, int status)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
            Status = status;
        }

        public void AddToList(IAirport airport, List<IAirport> myAirport)
        {
            myAirport.Add(airport);
        }

        public int CompareTo(Object obj)
        {
            if (obj is AbstractEmployee)
            {
                if (this.Status > (AbstractEmployee) obj.Status)
                    return 1;
                if (this.Status < (AbstractEmployee) obj.Status)
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
