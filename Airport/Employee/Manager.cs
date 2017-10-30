using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Employee
{
    [Serializable]
    class Manager : AbstractEmployee
    {
        public Manager(string name, string secondName, int age, int status) 
            : base(name, secondName, age, status)
        {
            base.Status = 8;
        }

        public override string ToString()
        {
            return $"Имя: {this.Name}, Фамилия: {this.SecondName}, Возраст: {this.Age}, Должность: Администратор, Зарплата: {this.Salary}$";
        }
    }
}
