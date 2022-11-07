﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.AdapterPattern
{
    public class SalaryCalculator
    {
        public double CalcSalary(Employee emp) => emp.BasicSalary * 1.5;
    }
}
