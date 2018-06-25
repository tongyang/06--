using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法递归
{
    class Program
    {
        public static int i = 0;

        static void Main(string[] args)
        {
            TellStory();
        }

        /// <summary>
        /// 方法递归可以用：从A点到B点需要经过很多的门，无论是正常通过还是原路返回都必须经过这些门
        /// </summary>
        public static void TellStory()
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("山上有座庙");
            i++;
            if (i >= 10)
            {
                return;
                
            }
            TellStory();
        }
    }
}
