using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_05번___최소직사각형
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 배열 처음숫자 입력하기 => ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("첫번째 배열 두번째숫자 입력하기 => ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("두번째 배열 처음숫자 입력하기 => ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("두번째 배열 두번째숫자 입력하기 => ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("세번째 배열 처음숫자 입력하기 => ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("세번째 배열 두번째숫자 입력하기 => ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("네번째 배열 처음숫자 입력하기 => ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("네번째 배열 두번째숫자 입력하기 => ");
            int h = int.Parse(Console.ReadLine());
            int[,] sizes = { {a,b },{c,d },{e,f },{g,h} };
            List<int[]> list = new List<int[]>();

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                int temp = 0;
                if (sizes[i, 0] < sizes[i, 1])
                {
                    temp = sizes[i, 1];
                    sizes[i, 1] = sizes[i, 0];
                    sizes[i, 0] = temp;
                }
                list.Add(new int[2]{sizes[i, 0], sizes[i, 1]});
            }
            Console.WriteLine("명함의 크기는 " + list.Max(x => x[0]) * list.Max(x => x[1]));
        }
    }
}
