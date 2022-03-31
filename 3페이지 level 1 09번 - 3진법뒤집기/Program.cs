using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_09번___3진법뒤집기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("뒤집을 숫자 입력하기 => ");
            int n = int.Parse(Console.ReadLine());
            int answer = 0;

            while(n > 0)
            {
                answer *= 3;
                answer += n % 3;
                n /= 3;
            }
            Console.WriteLine(answer);
        }
    }
}
