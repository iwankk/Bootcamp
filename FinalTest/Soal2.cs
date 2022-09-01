using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Soal2
    {
       public static int Faktorial(int n)
        {
            int hasil = n;
            int a = 1;

            for (int i = 1; i <= n; i++)
            {
                a = a * i;

            }
            Console.WriteLine($"{n}! = {a}");
            
            return hasil;
        }
        
    }
}
