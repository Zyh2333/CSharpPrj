using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    class Program
    {
        static int execute;
        static void getPrime(int execute)
        {
            for (int i = 2; i <= execute; i++)
            {
                while (true)
                {
                    if (execute % i == 0&&execute!=1)
                    {
                        execute /= i;//将所有2除尽，其他素数也一样
                        Console.WriteLine(i);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("输入你需要求素数因子的数：");
            try
            {
                execute = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("请输入正确的数");
            }
            getPrime(execute);
        }
    }
}
