﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Transports
{
    class CargoPlane : AbstractTransport
    {
        public int MaxLoad { get; private set; }

        public CargoPlane(string mark, string model, int issueYear, int consumption, int weight, int maxLoad)
            : base(mark, model, issueYear, consumption, weight)
        {
            MaxLoad = maxLoad;
        }

        public override string ToString()
        {
            return $"Марка: {this.Mark}, Модель: {this.Model}, Год выпуска: {this.IssueYear}, Расход топлива на 1000км: {this.Consumption}, Масса(т): {this.Weight}, Грузоподъемность: {this.MaxLoad}";
        }
    }
}
