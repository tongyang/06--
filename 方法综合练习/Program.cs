using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法综合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第一个练习
            //Console.WriteLine("请输入两个数字，第一个：");
            //string numStr1 = Console.ReadLine();
            //Console.WriteLine("请输入第二个数字：");
            //string numStr2 = Console.ReadLine();
            //Console.WriteLine("两个数字的和为：{0}", CountSum(numStr1, numStr2));
            #endregion

            #region 第二个练习
            //string[] strs = {"马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //Console.WriteLine(ShowMax(strs));
            #endregion

            #region 第三个练习
            //int[] nums = {1, 3, 4, 55, 2131, 13213, 123213 };
            //Console.WriteLine("该整数数组的平均值为：{0}", ShowAvg(nums)); 
            #endregion

            #region 第四个练习
            //Console.WriteLine("请输入一个数字：");
            //string s = Console.ReadLine();
            //int number;
            //IsNumber(s, out number);
            //if (IsPrime(number))
            //{
            //    Console.WriteLine("您输入的是一个质数");
            //}
            //else
            //{
            //    Console.WriteLine("您输入的不是一个质数");
            //}
            #endregion

            #region 第五个练习
            //Console.WriteLine("请输入您的分数：");
            //string s = Console.ReadLine();
            //int scoreInt;
            //IsNumber(s, out scoreInt);
            //double score = Convert.ToDouble(scoreInt);
            //string level;
            //ShowLevel(score, out level);
            //Console.WriteLine("您的成绩为：{0}", level);
            #endregion
        }

        public static void ShowLevel(double score, out string level)
        {
            level = "差";
            if (score >= 90 && score <= 100)
            {
                level = "优";
            }
            else if (score >= 80 && score < 90)
            {
                level = "良";
            }
            else if (score >= 60 && score < 70)
            {
                level = "中";
            }
            else if (score >= 70 && score < 80)
            {
                level = "一般";
            }
            else
            {
                level = "差";
            }
            
        }

        public static void IsNumber(string s, out int number)
        {
            number = 0;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(s);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("您输入的不是数字，请重新输入：");
                    s = Console.ReadLine();
                    continue;
                }
            }
        }

        public static bool IsPrime(int num)
        {
            if (num > 1)
            {
                for (int i = 2; i < 10; i++)
                {
                    if (i % num == 0 && i != num)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int ShowAvg(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        public static string ShowMax(string[] strs)
        {
            string temp = strs[0];
            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (strs[i].Length < strs[i + 1].Length)
                {
                    temp = strs[i + 1];
                }
            }
            return temp;
        }

        public static int CountSum(String numStr1, String numStr2)
        {
            int num1 = 0;
            int num2 = 0;
            while (true)
            {

                
                try
                {
                    num1 = int.Parse(numStr1);
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("您输入的不是数字，请您重新输入");
                    Console.WriteLine("请输入两个数字，第一个：");
                    numStr1 = Console.ReadLine();
                    continue;
                }
            }

            while (true)
            {
                
                try
                {
                    num2 = int.Parse(numStr2);
                    if (num2 > num1)
                    {
                        Console.WriteLine("第二个数字必须比第一个数字小，请您重新输入");
                        Console.WriteLine("请输入第二个数字：");
                        numStr2 = Console.ReadLine();
                        continue;
                    }
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("您输入的不是数字，请您重新输入");
                    Console.WriteLine("第二个数字必须比第一个数字小，请您重新输入");
                    Console.WriteLine("请输入第二个数字：");
                    continue;
                }
            }
            return num1 + num2;
        }
        
    }
}
