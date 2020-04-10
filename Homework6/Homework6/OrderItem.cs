using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //主要包含订单的商品明细
    public class OrderItem
    {
        //订单明细
        public int goodNum { get; set; }
        //购买数量
        public int num { get; set; }
        //明细项金额
        public double money { get; set; }
        public OrderItem() { }
        //该买数量和商品编号添加订单明细
        public OrderItem(int num,int goodNum)
        {
            this.goodNum = goodNum;
            this.num = num;
            if (goodNum == 1)
            {
                this.money = num * Good.getMoney1();
            }
            else
            {
                this.money = num * Good.getMoney2();
            }
        }
        //根据明细号判断明细是否重复
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return orderItem != null && this.goodNum == orderItem.goodNum;
        }
        public override int GetHashCode()
        {
            return this.goodNum;
        }
        public override string ToString()
        {
            return ($"商品编号{this.goodNum}数量为{num},金额为{money}");
        }
    }
}
