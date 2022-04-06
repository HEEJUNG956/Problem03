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
            Console.Write("반환할 문자 입력하기 => ");
            string s = Console.ReadLine();
            int a = (s.Length + 1) % 2;
            int b = s.Length / 2 - a;

            Console.WriteLine("반환된 문자 => " + s.Substring(b, a + 1));
            
            /*
            새로운 방법
            string answer = "";
        
            int a = s.Length / 2;
            if(s.Length % 2 == 0)
                answer = s.Substring(a - 1, 2);
            else
                answer = s.Substring(a,1);
            return answer;
            */
        }
    }
}
