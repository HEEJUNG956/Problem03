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
            int[] arr = {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) , int.Parse(Console.ReadLine()) };
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
