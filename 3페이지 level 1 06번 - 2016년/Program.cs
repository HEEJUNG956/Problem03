using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_06번___2016년
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("일 : ");
            int b = int.Parse(Console.ReadLine());

            string answer = "";
            DateTime dateValue = new DateTime(2016, a, b);
            answer = dateValue.DayOfWeek.ToString();
            Console.WriteLine(answer);
            answer = answer.Substring(0, 3).ToUpper();
            Console.WriteLine(answer);
        }
    }
}
