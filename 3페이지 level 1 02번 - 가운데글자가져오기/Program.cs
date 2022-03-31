using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_02번___가운데글자가져오기
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string s = Console.ReadLine();
            int a = (s.Length + 1) % 2;
            int b = s.Length / 2 - a;

            Console.WriteLine(s.Substring(b, a + 1));
        }
    }
}
