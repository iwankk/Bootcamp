using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] numbers = new int[] { 98, 99, 200, 95, 97, 93, 80, 2022 };
            
            // sum from index 98 - 2022
            var sum = numbers.Sum(x => x++);
            Console.WriteLine($"sum : {sum}");
            // cari nilai min dalam array numbers
            var min = numbers.Min();
            Console.WriteLine($"Min : {min}");
            //mencari nilai max dalam array numbers
            var max = numbers.Max();
            Console.WriteLine($"Max : {max}");

            var duplicatest = numbers.Distinct();
            foreach (var item in duplicatest)
            {
                Console.WriteLine(item);
            }
        }

    }
}
