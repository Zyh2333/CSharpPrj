using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_3
{
    class Program
    {
        static bool[] isPrime = new bool[101];
        static void initList()
        {
            isPrime[0] = isPrime[1] = false;
            for(int i = 2; i <= 100; i++)
            {
                isPrime[i] = true;
            }
        }
        static void getPrime()
        {
            for(int i = 2; i <= 10; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i; i * j <= 100; j++)
                    {
                        isPrime[i * j] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            initList();
            getPrime();
            int i = 0;
           while(i<=100)
            {
                if(isPrime[i])
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
