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
            //Console.WriteLine("请输入一个数字：");
            //string s = Console.ReadLine();
            //IsZS(s);
            int[] values = { 1, 2, 3, 4, 5, 6, 32, 2, 1 };
            ShowSum(values);
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

        public static void ShowSum(int[] values)
        {
            int temp = 0;
            for (int i = 0; i < values.Length; i++)
            {
                temp += values[i];
            }

            Console.WriteLine(temp);
        }

    }
}
