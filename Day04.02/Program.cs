using static System.Console;

using System.Globalization;
using Day004.PartTwo;


IEmployee emInf = new EmployeeImpl();
var listOfEmps = emInf.InitDataEmployee();
emInf.ShowList(ref listOfEmps);
WriteLine("============Gaji=============");
var total = emInf.GetTotal(ref listOfEmps);
WriteLine($"Total Salary : { total}");
WriteLine("============Salary=============");
var emps = emInf.FindEmployeeById(listOfEmps, 1003);
WriteLine($"ketemu {emps}");

WriteLine("============Salary=============");
var empsRange = emInf.FindSalaryRange(listOfEmps, 4_000_000, 5_000_000);
emInf.ShowList(ref empsRange);

ReadLine();