using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Soal01
    {
        public static int Katak()
        {
            int x = 10;
            int k = 30;
            int y = 85;
            int Hasil = x+k;
            for (int i = Hasil; i >= y; i++)
            {
                Hasil = i - y;
            }
            Console.WriteLine($"Katak melompat sebanyak :{Hasil}");
            return Hasil;
        }
    }
}
