using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //商品类
    class Good
    {
        private static string name1 = "good1";
        private static string name2 = "good2";
        private static double money1 = 10;
        private static double money2 = 20;
        private static int good1Num = 1;
        private static int good2Num = 2;
        //购买数量
        //public int num { set; get; }
        public static double getMoney1()
        {
            return money1;
        }
        public static double getMoney2()
        {
            return money2;
        }
        public static string getName1()
        {
            return name1;
        }
        public static string getName2()
        {
            return name2;
        }
        public static int getGoodNum1()
        {
            return good1Num;
        }
        public static int getGoodNum2()
        {
            return good2Num;
        }
    }
}
