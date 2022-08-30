using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public List<Employee> InitDataEmployee()
        {
            //throw new NotImplementedException();
            Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(2022, 06, 12), 5_000_000, "", "Sales");
            Employee emp3 = new Employee(1002, "Codex", "demy", new DateTime(2022, 06, 12), 5_000_000, "garut", "QA");
            Employee emp4 = new Employee(1003, "Ibet", "Racing", new DateTime(2022, 06, 12), 5_000_000, "Cimahi", "Sales");
            Employee emp5 = new Employee(1004, "Ubed", "Gapleh", new DateTime(2022, 06, 12), 5_000_000, "Cimahi", "Sales");
            Programmer prog1 = new Programmer(1005, "Gonjales", "Elloco", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 400_000);
            QA QA1 = new QA(1006, "Luis", "Milla", new DateTime(2022, 06, 12), 3_800_000, "Bandung", 200_000);
            Sales SA1 = new Sales(1007, "Yacob", "Sayuri", new DateTime(2022, 06, 12), 3_500_000, "Palembang", 200_000, 300_000);
            
            //Direct return without variable
            return new List<Employee> { emp2, emp3, emp4, emp5, prog1, QA1, SA1 };
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}
