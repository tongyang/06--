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
            #region 判断闰年
            bool b = IsRun(2000);
            Console.WriteLine(b);   
            #endregion
        }
        /// <summary>
        /// 根据传入的年份判断是否为闰年
        /// </summary>
        /// <param name="year">需要判断的年份</param>
        /// <returns>返回是否为闰年，true/false</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 4 == 0) || (year % 400 == 0) && (year % 100 != 0);
            return b;
        }

        
    }
}
