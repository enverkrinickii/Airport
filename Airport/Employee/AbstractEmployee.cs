using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Employee
{
    abstract class AbstractEmployee
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
    }
}
