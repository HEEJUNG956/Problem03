using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_01번___나누어떨어지는배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("처음배열숫자 입력하기 => ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두번째배열숫자 입력하기 => ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세번째배열숫자 입력하기 => ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("네번째배열숫자 입력하기 => ");
            int d = int.Parse(Console.ReadLine());
            
            int[] arr = {a, b, c, d };
            Console.Write("나누는 숫자 입력하기 => ");
            int divisor = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            foreach(var item in arr)
            {
                if(item % divisor == 0)
                {
                    result.Add(item);
                }
            }
            if(result.Count == 0)
            {
                result.Add(-1);
            }
            else
            {
                result.Sort();
            }
            
            for(int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");  
            }
        }
    }
}
