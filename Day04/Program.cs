using static System.Console;
using System.Globalization;
using Day04.PartOne;
using Day04.PartTwo;

/*List.InitList();

List.InitStack();

List.InitDictionary();

List.InitHashSet();

List.Queue();

// Declare List <T>
var list = new List<string> { "Asep", "Budi", "Charlie" };
var students = List.GetStudent(ref list);

foreach (var item in students) //menampilkan List.list
{
    Console.WriteLine($"{item}");
}

var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
var myNumber = List.GetStudent(ref numbers);
foreach (var item in numbers) //menampilkan List.Numbers
{
    Console.WriteLine($"{item}");
}
*/
// Quiz Day04 No.1
/*var nilai1 = new List<int> { 1, 2, 5, 6, 9 };
var nilai2 = new List<int> { 1, 2, 3, 4 };
Quiz04.Collection(ref nilai1 , ref nilai2);*/

//No. 2
/*var a = new List<string> { "1", "2" , "3" , "4" };
var b = new List<string> { "A", "BB" , "CCC" , "DDDD" };
Quiz04.No2(ref a, ref b);*/

//No. 3
/*var n1 = new List<int>{ 1,1,2,3,4,1,2,3};
var n2 = new List<int>() { 7, 5, 3, 5, 1 };
var n3 = new List<int>() { 1, 1, 1 ,1,1,1 };

var List = Quiz04.Hapus(ref n1);
var List1 = Quiz04.Hapus(ref n2);
var List2 = Quiz04.Hapus(ref n3);


foreach (var item in List)
{
    Console.Write($"{item}");
}
Console.WriteLine();
foreach (var item in List1)
{
    Console.Write($"{item}");
}
Console.WriteLine();
foreach (var item in List2)
{
    Console.Write($"{item}");
}
*/


//Quiz04.No1();
//Class1.input();
// call class empolyee

//create object instant , gunakan operator new
/*Employee emp1 = new Employee();
emp1.EmpId = 1000;
emp1.FirstName = "Iwan";
emp1.LastName1 = "Kartiwan";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 7_000_000;
emp1.City1 = "Ciamis";
emp1.Role = "Programmer";






//create oject employee with parameter constructor
Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(2022, 06, 12), 5_000_000, "", "Sales");
Employee emp3 = new Employee(1002, "Codex", "demy", new DateTime(2022, 06, 12), 5_000_000, "garut", "QA");
Employee emp4 = new Employee(1003, "Ibet", "Racing", new DateTime(2022, 06, 12), 5_000_000, "Cimahi", "Sales");
Employee emp5 = new Employee(1004, "Ubed", "Gapleh", new DateTime(2022, 06, 12), 5_000_000, "Cimahi", "Sales");
*//*empl.firstName = "Code"; //encapsulation menggunakan atribut class
empl.EmpId = 1001;*//*



WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine(emp5.ToString());
WriteLine($"Total employee : {Employee.totalEmployee}");
WriteLine($"total Basic Salary : {Employee.totalBasic.ToString("C",new CultureInfo("Id-ID"))}");

//merubah data salary
emp3.Role = "QA";
emp3.BasicSalary = 9_000_000;
WriteLine("=================LIST EMPLOYEE==========================");
//Create Object Class Programmer
Programmer prog1 = new Programmer(1005, "Gonjales", "Elloco", new DateTime(2022, 06, 12), 5_600_000, "Tegal", 400_000);
QA QA1 = new QA(1006, "Luis", "Milla", new DateTime(2022, 06, 12), 3_800_000, "Bandung", 200_000);
Sales SA1 = new Sales(1007, "Yacob", "Sayuri", new DateTime(2022, 06, 12), 3_500_000, "Palembang", 200_000 , 300_000);
//store to list (mempermudah menampilkan menggunakan list)
List<Employee> listEmps = new List<Employee> { emp1, emp2, emp3, emp4,emp5 , prog1,QA1,SA1 };

foreach (var item in listEmps)
{
    WriteLine(item.ToString());
}

WriteLine($"Total employee : {Employee.totalEmployee}");

/*ReadLine();*/



IEmployee emInf = new EmployeeImpl();
var listOfEmps = emInf.InitDataEmployee();
emInf.ShowList(ref listOfEmps);



ReadLine();