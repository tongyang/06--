using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            replace(ref num1, ref num2);
            Console.WriteLine("{0}\n{1}", num1, num2);
        }

        public static void replace(ref int num1, ref int num2)
        {
            int temp = num2;
            num2 = num1;
            num1 = temp;
        }
    }
}
