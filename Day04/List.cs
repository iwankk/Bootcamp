using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class List
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "j");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write($"{item}");
            }

            //remove element for list
            alfabet.Remove("X");
            alfabet.RemoveRange(4, 6);
            alfabet.RemoveAll(v => v == "X");

            //Clear 
            alfabet.Clear();

            // declare list int
            var numbers = new List<int> { 2, 5, 7, 11, 13, 17, 19 };
            numbers.Add(23);
            numbers.Remove(13);
            numbers.RemoveAll(v => v == 7);



            //find numbers
            var a = numbers.Find(e => e < 10);
            var b = numbers.FindLast(e => e < 10);
            var c = numbers.FindAll(e => e <= 10);

            //find element
            var d = numbers.FindIndex(e => e < 10);
            var e = numbers.FindLastIndex(e => e <= 11);
            var f = numbers.IndexOf(13);
            var g = numbers.BinarySearch(11);

            Console.WriteLine();
        }
        //Last in firstout
        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3 });
            numbers.Push(23); // u/ menambahkan element
            numbers.Push(7);

            //remove pop
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();

        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1,"C#"},
                {2,"Java" },
                {3, "Python" },
        };

            //add element 
            pl2.Add(4, "Golang");
            //pl2.Add(4, "SQL");
            pl2.TryAdd(4, "sql");

            pl2[4] = "SQL"; // merubah data nama contoh dari sql menjadi SQL


            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key }. {item.Value}");
            }
            Console.WriteLine();

        }

        // Hanya menyimpan Store Unique element / Value
        public static void InitHashSet()
        {
            HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5, 8 };
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(8);

            var hs1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var r1 = new HashSet<int>(hs1);

            var result1 = new HashSet<int>(hs1); // inner join hasil = 1,2 / nilai angka yg sama di hs1 dan hs2
            result1.IntersectWith(hs2);

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2); // union = 1,2,3,4,5,6,9 seluruh gabungan hs1 dan hs 2 pake union

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2); //except = 5,6,9

            var result4 = new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2); //3,4,5,6,9

            // convert hashset to list
            var myNumber = result4.ToList();

            Console.WriteLine();

        }
        public static void Queue()
        {
            var queue = new Queue<string>();
            {
                queue.Enqueue("Asep");
                queue.Enqueue("Budi");
                queue.Enqueue("Charlie");

                foreach (var item in queue)
                {
                    Console.Write($"{item} ");
                }

                string served = queue.Dequeue();
                Console.WriteLine($"Served : {served}");
            }
        }
        //Return List<T>
        public static List<T> GetStudent<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }

            return myList;
        }
    }
}
