﻿using System;

namespace Airport.Employee
{
    [Serializable]
    class Security : AbstractEmployee
    {
        public Security(string name, string secondName, int age, int status) 
            : base(name, secondName, age, status)
        {
            base.Status = 5;
        }

        public override string ToString()
        {
            return $"Имя: {this.Name}, Фамилия: {this.SecondName}, Возраст: {this.Age}, Должность: Охрана, Зарплата: {this.Salary}$";
        }
    }
}
