using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day004.PartTwo
{
    internal class Sales : Employee
    {
        private decimal bonus, commission;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal bonus, decimal commission) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.bonus = bonus;
            this.commission = commission;
            Role = "Sales";
            TotalSalary = basicSalary + bonus + commission;
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commission { get => commission; set => commission = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Uang Bonus = {this.bonus.ToString("C", new CultureInfo("Id-ID"))} | Uang Commission {this.commission.ToString("C", new CultureInfo("Id-ID"))} | Total Salary {this.TotalSalary.ToString("C", new CultureInfo("Id-ID"))}";
        }
    }
}
