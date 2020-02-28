using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Program
    {
        static int MAXSIZE = 5;
        static void getArray(ref int[] array)
        {
            int i = 0;
            Console.WriteLine("请输入数组元素：");
            int? num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                array[i] = (int)num;
                i++;
            } while (num != null&&i<MAXSIZE);
        }
        static void getMaxAndMin(int[] array,out int max,out int min,out double average,out int andAll)
        {
            andAll = 0;
            average = 0;
            max = array[0];
            min = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                andAll += array[i];
            }
            average = (double)andAll / array.Length;
        }
        static void Main(string[] args)
        {
            //int[] a = { 2, 6, 3,10 };
            int[] a = new int[MAXSIZE];
            getArray(ref a);
            int max, min,andAll;
            double average;
            getMaxAndMin(a,out max,out min,out average, out andAll);
            Console.WriteLine("最大值是：" + max);
            Console.WriteLine("最小值是：" + min);
            Console.WriteLine("平均值是：" + average);
            Console.WriteLine("和是：" + andAll);
        }
    }
}
