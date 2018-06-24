using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @out
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                string account1;
                string password1;
                Console.WriteLine("请输入用户名：");
                string account = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string password = Console.ReadLine();
                if (CheckLogin(account, password, out account1, out password1))
                {
                    Console.WriteLine("登录成功，您的登录账号为{0} 密码为 {1}", account1, password1);
                    break;
                }
                else
                {
                    Console.WriteLine("登录失败，您的登录账号为{0} 密码为 {1}", account1, password1);
                    continue;
                }
                
            }
        }

        public static bool CheckLogin(string account, string password, out string account1, out string password1)
        {
            account1 = account;
            password1 = password;
            if (account == "tongyang" && password == "1989o8o2")
            {
                return true;
            }
            return false;
        }
    }
}
