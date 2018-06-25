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
            string[] strs = {"马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            Console.WriteLine(ShowMax(strs));
            #endregion
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
