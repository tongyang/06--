using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_函数
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 先复习一边冒泡排序
            int[] numbers = { 3, 3, 2, 1, 321, 32, 323, 111, 32, 5, 6, 31 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
            #endregion

        }
    }
}
