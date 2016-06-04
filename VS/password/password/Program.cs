using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
       
        static void Main(string[] args)
        {
            const uint errcnt=3;
            int error = 0;
            string password = "ok1234";
            string choice;
            while (true)
            {
                while (error < errcnt)
                {
                    System.Console.WriteLine("Please input password:");
                    string buf = System.Console.ReadLine();
                    if (buf == password)
                        break;
                    else
                        error++;
                }
                if (error < errcnt)//密码正确
                {
                    error = 0;
                    while (true)
                    {
                        System.Console.WriteLine("=====================================");
                        System.Console.WriteLine("         (a)Change Password");
                        System.Console.WriteLine("         (b)score");
                        System.Console.WriteLine("         (c)Exit");
                        System.Console.WriteLine("=====================================");
                        System.Console.WriteLine("       Please input choice:");
                        choice = System.Console.ReadLine();
                        if (choice == "A" || choice == "a" || choice == "B" || choice == "b" || choice == "C" || choice == "c")
                            break;
                    }
                    if (choice == "A" || choice == "a")
                    {
                        System.Console.WriteLine("Please input change password:");
                        password = System.Console.ReadLine();
                    }
                    else if (choice == "B" || choice == "b")
                    {
                        System.Console.WriteLine("90-100 very good!");
                        System.Console.WriteLine("60-89 Pass!");
                        System.Console.WriteLine("0-59 Failed!");
                        System.Console.ReadLine();
                        return;
                    }
                    else if (choice == "C" || choice == "c")
                    {
                        return;
                    }
                }
                else
                {
                    return;//错误3次退出
                }
            }
        }
    }
}
