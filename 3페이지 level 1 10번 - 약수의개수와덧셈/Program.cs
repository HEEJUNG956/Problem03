using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_10번___약수의개수와덧셈
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("왼쪽 숫자 입력하기 => ");
            int left = int.Parse(Console.ReadLine());
            Console.Write("오른쪽 숫자 입력하기 => ");
            int right = int.Parse(Console.ReadLine());

            int answer = 0;
            int count = 0;
            for(int i = left; i <= right; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0) count++;
                }
                answer += (count % 2 == 0) ? i : i * -1;
                count = 0;
            }
            Console.WriteLine(answer);
        }
    }
}
