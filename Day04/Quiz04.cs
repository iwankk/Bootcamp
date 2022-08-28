using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class Quiz04
    {
        public static List<T> Collection<T>(ref List<T> nilai1, ref List<T> nilai2)
        {
            var Angka = nilai1;
            var Angka2 = nilai2;
            var Hasil = new HashSet<T>(Angka);

            var hasil01 = new HashSet<T>(Angka2);
            hasil01.IntersectWith(Angka);
            Console.Write("Irisan : ");
            foreach (var item in hasil01)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            var hasil02 = new HashSet<T>(Angka2);
            hasil02.UnionWith(Angka);
            Console.Write("Union : ");
            foreach (var item in hasil02)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            var hasil03 = new HashSet<T>(Angka);
            hasil03.ExceptWith(Angka2);
            Console.Write("Except : ");
            foreach (var item in hasil03)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            var hasil04 = new HashSet<T>(Angka2);
            hasil04.SymmetricExceptWith(Angka);
            Console.Write("Symetric : ");
            foreach (var item in hasil04)
            {
                Console.Write($" {item}");
            }

            return Angka;
        }

        public static List<string> No2(ref List<string> a, ref List<string> b)
        {
            var myChar = a;
            var myChar2 = b;
            
            Console.Write("Reverse input a : ");
            Display(reverse(a));
            Console.WriteLine();
            Console.Write("Reverse input b : ");
            Display(reverse(b));

            return myChar2;
        }
        public static List<string> reverse(List<string> rv)
        {
            rv.Reverse();
            return rv;
        }

        public static void Display(List<string> a)
        {
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
        }

        //no4
        public static List<T> Hapus<T>(ref List<T> list)
        {
            var List1 = new List<T>();

            foreach(var item in list)
            {
                List1.Add(item);
            }

            var List2 = List1.Distinct().ToList();

            return List2;
        }





    }
}
