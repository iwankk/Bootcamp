using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    internal class Soal07
    {
        public static string IsAnagram(string name1, string name2)
        {
            var name12 = name1;
            var name13 = name2;

            char[] name1Array = name1.ToLower().ToCharArray();
            char[] name2Array = name2.ToLower().ToCharArray();

            if (name12.Length != name13.Length && name12.Length != name13.Length)
            {
                Console.WriteLine($"{name12} | {name13} | False");
            }
            else if(name12.Length == name13.Length && name12.Length == name13.Length)
            {
                Console.WriteLine($"{name12} | {name13} | True");
            }

            return name12;
        }
  }

}
