using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字：");
            string s = Console.ReadLine();
            IsZS(s);
        }

        public static void IsZS(string ZS)
        {
           

            while (int.TryParse(ZS, out int zs) == false)
            {
                Console.WriteLine("请输入一个数字：");
                ZS = Console.ReadLine();
                continue;
            }

            Console.WriteLine(ZS);
        }
    }
}
