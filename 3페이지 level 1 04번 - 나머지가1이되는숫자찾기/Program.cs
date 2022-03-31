using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_04번___나머지가1이되는숫자찾기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력할 숫자 => ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if(n % i == 1)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            
        }
    }
}
