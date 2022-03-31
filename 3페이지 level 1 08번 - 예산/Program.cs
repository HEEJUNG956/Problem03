using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_08번___예산
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째부서 예산 입력하기 => ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두번째부서 예산 입력하기 => ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세번째부서 예산 입력하기 => ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("네번째부서 예산 입력하기 => ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("다섯번째부서 예산 입력하기 => ");
            int e = int.Parse(Console.ReadLine());

            int[] arr = {a,b,c,d,e };
            Console.Write("전체 예산 입력하기 => ");
            int budget = int.Parse(Console.ReadLine());
            int answer = 0;
            Array.Sort(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                budget -= arr[i];

                if (budget >= 0)
                    answer++;
                else
                    continue;
            }

            Console.WriteLine(answer);
        }
    }
}
