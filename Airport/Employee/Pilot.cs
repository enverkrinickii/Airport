﻿using System;

namespace Airport.Employee
{
    [Serializable]
    class Pilot : AbstractEmployee
    {
        public Pilot(string name, string secondName, int age, int status) 
            : base(name, secondName, age, status)
        {
            base.Status = 7;
        }

        public override string ToString()
        {
            return $"Имя: {this.Name}, Фамилия: {this.SecondName}, Возраст: {this.Age}, Должность: Пилот, Зарплата: {this.Salary}$";
        }
    }
}
