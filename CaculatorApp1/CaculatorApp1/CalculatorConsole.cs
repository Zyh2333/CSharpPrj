using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 c#中有异常处理类，不需要用函数判断溢出
     */
namespace Caculator
{
    class Program
    {   
        static bool isTrue(double num)
        {
            if (num / 10 > Int32.MaxValue || (num / 10 == Int32.MaxValue && num % 10 < Int32.MaxValue % 10)){
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter number1.");
                String number1_str = Console.ReadLine();
                Console.WriteLine("Please enter the op.");
                String op = Console.ReadLine();
                Console.WriteLine("Please enter number2.");
                String number2_str = Console.ReadLine();
                //检测溢出
                /*bool num1is = isTrue(Convert.ToInt32(number1_str));
                bool num2is = isTrue(Convert.ToInt32(number2_str));
                if ((num1is && num2is)!=true)
                {
                    Console.WriteLine("输入的操作数不合法");
                }*/
                int num1 = Int32.Parse(number1_str);
                int num2 = Int32.Parse(number2_str);
                char op1 = Char.Parse(op);
                double result = 0;
                switch (op1)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/':
                        if (num2 == 0) { Console.WriteLine("The second num can not be 0"); }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("The operator is false");
                        break;
                }
                Console.Write("The result is:");
                Console.WriteLine(Convert.ToString(result));
            }
            catch(OverflowException)
            {
                Console.WriteLine("The result is overflow");
                return;
            }
            catch (FormatException)//检查操作数的合法性
            {
                Console.WriteLine("Please enter the correct number");
                return;
            }
        }
    }
}
