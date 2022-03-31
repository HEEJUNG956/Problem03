using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_07번___두개뽑아서더하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("처음숫자 입력하기 => ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두번째숫자 입력하기 => ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세번째숫자 입력하기 => ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("네번째숫자 입력하기 => ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("다섯번째숫자 입력하기 => ");
            int e = int.Parse(Console.ReadLine());

            int[] numbers = { a, b, c, d,e};
            List<int> list = new List<int>();
            for(int i = 0; i < numbers.Length - 1; ++i)
            {
                for(int j = i + 1; j < numbers.Length; ++j)
                {
                    if (!list.Contains(numbers[i] + numbers[j]))
                        list.Add(numbers[i] + numbers[j]);
                }
            }
            list.Sort();
            for(int i = 0; i < list.Count; ++i)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
