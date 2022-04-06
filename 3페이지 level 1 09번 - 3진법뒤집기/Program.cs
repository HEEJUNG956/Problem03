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
            
            /*
            새로운 방법
            int answer = 0;
            List<int> list = new List<int>();

            while(true)
            {
                if(n == 0) break;
                int temp = n % 3;
                list.Add(temp);
                n /= 3;
            }

            list.Reverse();

            for(int i = 0 ; i < list.Count; i++)
            {
                answer += (int)(list[i] * Math.Pow(3, i));
            }
            return answer;
            */
        }
    }
}
