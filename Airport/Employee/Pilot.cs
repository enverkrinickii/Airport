﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Employee
{
    class Pilot : AbstractEmployee
    {
        public Pilot(string name, string secondName, int age, int status) 
            : base(name, secondName, age, status)
        {
            status = 9;
        }
    }
}