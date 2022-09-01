using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Soal04
    {


        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            int c = 1;
    
            for (int i = 2; i < n; i++)
            { 
                c = a + b;
                a = b;
                b = c;
 
            }
            
            Console.WriteLine($"Fibonacci {n} : {c}");
            return a;

        }
    }
}