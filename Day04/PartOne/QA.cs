﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class QA : Employee
    {
        private decimal makan = 0M;
        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.makan = makan;
            Role = "QA";
            TotalSalary = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Uang Makan = {this.makan.ToString("C", new CultureInfo("Id-ID"))} | Total Salary : {TotalSalary.ToString("C", new CultureInfo("Id-ID"))}";
        }
    }
}
