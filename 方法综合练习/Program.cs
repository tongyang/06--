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

            #region 第六个练习
            //string[] s = {"中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //ReverseArray(s);
            #endregion

            #region 第七个练习
            //double area;
            //double girth;
            //Console.WriteLine("请输入圆的半径：");
            //string s = Console.ReadLine();
            //int temp;
            //IsNumber(s, out temp);
            //double r = Convert.ToDouble(temp);
            //CountSpace(r, out area, out girth);
            //Console.WriteLine("圆的周长为 {0} 面积为 {1}", girth, area);
            #endregion

            #region 第八个练习
            //Console.WriteLine(GetMax(1, 3, 5, 22, 12, 44, 44, 4213));
            #endregion

            #region 第九个练习
            //int[] array = {1, 2, 33, 22, 1, 32, 53 };
            //array = GetAscArray(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 第十个练习
            //int[] nums = { 0, 0, 0, 15};
            //Console.WriteLine(GetAvg(nums));
            #endregion

            #region 第十一个练习
            //string[] strs = {"中国", "荷兰", "德国", "法国" };
            //Cut(strs);
            #endregion
        }

        public static void Cut(string[] strs)
        {
            for (int i = 0; i < strs.Length - 1; i++)
            {
                strs[i] = strs[i] + "|";
            }
            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(strs[i]);
            }
        }

        public static int GetAvg(int[] nums)
        {
            int sum = 0;
            // 先计算数组的和
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            float avg = (float)sum / nums.Length;
            int avgInt = sum / nums.Length;
            int one = (int)((avg * 1000) / 100);
            int two = (int)((avg * 10000) / 100);
            two = two - one * 10;
            if (two >= 5)
            {
                one += 1;
                if (one >= 5)
                {
                    avgInt += 1;
                    return avgInt;
                }
            }
            else
            {
                if (one >= 5)
                {
                    avgInt += 1;
                    return avgInt;
                }
            }
            return avgInt;
        }

        public static int[] GetAscArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 -i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (max < nums[i + 1])
                {
                    max = nums[i + 1];
                }
            }
            return max;
        }

        public static void CountSpace(double r, out double area, out double girth)
        {
            area = 0;
            girth = 0;
            area = r * r * Math.PI;
            girth = 2 * r * Math.PI;

        }

        public static void ReverseArray(string[] s)
        {
            Array.Reverse(s);
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
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
