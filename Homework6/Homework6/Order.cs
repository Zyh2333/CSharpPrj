using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //在客户创建订单时就会通过订单构造函数将订单存入List中
    [Serializable]
    public class Order
    {
        public List<OrderItem> items{ get; set; }
        //订单号
        public int orderNum { set; get; }
        //客户名字
        public string client { set; get; }
        //客户订单日期,用整数代替某天
        public int date { set; get; }
        //订单金额
        public double money { set; get; }
        //初始化订单并添加到list中
        public Order(String clientName,int num1,int num2,int date,int orderNum)
        {
            {                         
                this.client = clientName;
                this.money = num1 * Good.getMoney1() + num2 * Good.getMoney2();
                items = new List<OrderItem>();
                this.items.Add(new OrderItem(num1,Good.getGoodNum1()));
                this.items.Add(new OrderItem(num2,Good.getGoodNum2()));
                this.date = date;
                this.orderNum = orderNum;
            }
        }
        //无参构造函数以备反序列化
        public Order() { }
        public void setDate(int date)
        {
            this.date = date;
        }
        public double getMoney()
        {
            return money;
        }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && this.orderNum == order.orderNum;
        }
        public override int GetHashCode()
        {
            return this.orderNum;
        }
        public override string ToString()
        {
            return ($"订单如下：订单号：{this.orderNum},客户姓名：{this.client}总金额：{this.money},时间{this.date}");
        }
    }
}