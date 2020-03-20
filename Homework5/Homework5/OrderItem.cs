using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //主要包含订单的商品明细
    class OrderItem
    {
        //订单明细编号
        private int goodNum;
        private int itemNum;
        private int num;
        private double money;
        public OrderItem(int num,int itemNum)
        {
            this.itemNum = itemNum;
            this.num = num;
            if (itemNum == 1)
            {
                this.money = num * Good.getMoney1();
            }
            else
            {
                this.money = num * Good.getMoney2();
            }
            this.goodNum = itemNum;
        }
        //根据明细号判断明细是否重复
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return orderItem != null && this.itemNum == orderItem.itemNum;
        }
        public override int GetHashCode()
        {
            return this.itemNum;
        }
        public override string ToString()
        {
            return ($"当前明细编号:{itemNum},商品编号{this.goodNum}数量为{num},金额为{money}");
        }
    }
}
