using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Employee
{
    [Serializable]
    class Accountant : AbstractEmployee 
    {
        public Accountant(string name, string secondName, int age, int status) 
            : base(name, secondName, age, status)
        {
            base.Status = 4;
        }

        public override string ToString()
        {
            return $"Имя: {this.Name}, Фамилия: {this.SecondName}, Возраст: {this.Age}, Должность: Бухгалтер, Зарплата: {this.Salary}$";
        }
    }
}
