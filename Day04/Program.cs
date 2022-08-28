using Day04;

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
var n1 = new List<int>{ 1,1,2,3,4,1,2,3};
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





//Quiz04.No1();
//Class1.input();
