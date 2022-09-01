using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Soal05
    {
        public static void TampilFibonacci()
        {

            int a = 1;
            int b = 1; 
            int c = 1;

            Console.Write("Masukan bilangan fibonacci = ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < j; i++)
            {
                Console.Write( c + " ");
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine($"Fibonacci {j} : {c}");
        }
    }
}

