using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Soal03
    {
        public static int Sum(int n)
        {
            int hasil = n;
            int b = 0;
            for (int i = 0; i <= n; i++)
            {
                b = b + i;
            }
            Console.WriteLine($"Sum {n} = {b}");
            return hasil;        
        }
        
    }
}
