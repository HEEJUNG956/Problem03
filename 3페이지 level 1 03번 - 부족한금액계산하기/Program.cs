using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_03번___부족한금액계산하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("가격 : ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("소지한 돈 : ");
            int money = int.Parse(Console.ReadLine());
            Console.Write("이용횟수 : ");
            int count = int.Parse(Console.ReadLine());

            long result = price * ((long)count * (1 + count) / 2);

            if(result <= money)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result - (long)money);
            }
        }
    }
}
