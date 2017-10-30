using System;

namespace Airport.Employee
{
    [Serializable]
    public abstract class AbstractEmployee : IComparable<AbstractEmployee>
    {
        public string Name { get; private set; }

        public string SecondName { get; private set; }

        public int Age { get; private set; }

        public int Status { get; set; }

        public int Salary => Status * 1000;

        protected AbstractEmployee(string name, string secondName, int age, int status)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
            Status = status;
        }

        public int CompareTo(AbstractEmployee obj)
        {
            if (obj is AbstractEmployee)
            {
                if (this.Status > obj.Status)
                    return 1;
                if (this.Status < obj.Status)
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
