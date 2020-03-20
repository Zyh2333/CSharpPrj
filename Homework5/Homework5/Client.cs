using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //客户在创建订单时，只需指明商品名称及自己的姓名
    class Client
    {
        //客户姓名
        public String name { set; get; }
        private Order order;
        public Client(String name)
        {
            //设置客户姓名
            this.name = name;
        }
        //客户指明购买商品的个数
        public void buyGood(int num1,int num2,int orderNum)
        {
            DateTime dateTime = DateTime.Now;
            //实例化订单
            this.order = new Order(this.name, num1, num2,dateTime.Day,orderNum);
        }
        public Order GetOrder()
        {
            return order;
        }
        public override string ToString()
        {
            return ($"订单如下：订单号：{this.order.orderNum},客户姓名：{this.name},订单详情请用订单再次查询");
        }
    }
}
