using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //由于想要单独测试三个异常，所以分段写了多个try,catch
    //模拟商店售货员处理客户订单并生成订单号和日期的过程
    class Program
    {
        public void show(IEnumerable<Order> query)
        {
            foreach(Order order in query)
            {
                Console.WriteLine(order);
            }
        }
        public static void showAll(IEnumerable<Order> orders)
        {
            Console.WriteLine("输出所有订单");
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Client client1;
            Client client2;
            //客户1
            client1 = new Client("client1");
            //购买商品创建订单对象,并会根据购买商品名称自动添加商品金额
            client1.buyGood(1,1,1);
            //设置订单号
            //客户2
            client2 = new Client("client2");
            client2.buyGood(2,1,2);
            OrderSevice orderSevice = new OrderSevice();
            //保存订单
            try
            {
                orderSevice.addOrder(client1.GetOrder());
                Console.WriteLine("成功保存订单");
                Console.WriteLine(client1.GetOrder());
                orderSevice.addOrder(client2.GetOrder());
                Console.WriteLine("成功保存订单");
                Console.WriteLine(client2.GetOrder());
                /*orderSevice.addOrder(client1.GetOrder());
                Console.WriteLine("成功保存订单");
                Console.WriteLine(client1.GetOrder());
                orderSevice.addOrder(client1.GetOrder());
                Console.WriteLine("成功保存订单");
                Console.WriteLine(client2.GetOrder());*/
            }
            catch(RepeatException e)
            {
                Console.WriteLine(e);
            }
            //输出所有订单，结果是已经排序过的
            List<Order> orders = orderSevice.orders;
            showAll(orders);
            //按照名字查询
            Console.WriteLine("按照名字查询订单");
            var query1 = orderSevice.findOrderByClientName("client1");
            program.show(query1);
            Console.WriteLine("按照订单号查询订单");
            var query2 = orderSevice.findOrderByNum(1);
            program.show(query2);
            Console.WriteLine("按照时间查询订单并按照金额升序排列");
            var query3 = orderSevice.findOrderByDate(20);
            program.show(query3);
            //查询订单明细
            Console.WriteLine("查询订单1的明细：");
            Console.WriteLine(client1.GetOrder().items[0]);
            Console.WriteLine(client1.GetOrder().items[1]);
            //更新订单日期
            Console.WriteLine("更新订单日期");
            try
            {
                orderSevice.update(1, 15);
                //更新异常类测试，测试成功
                //orderSevice.update(5, 15);
                Console.WriteLine("更新成功");
            }
            catch(UpdateException e)
            {
                Console.WriteLine(e);
            }
            showAll(orders);
            try
            {
                orderSevice.delete(1);
                //删除异常类测试，测试成功
                //orderSevice.delete(5);
            }
            catch(DeleteException e)
            {
                Console.WriteLine(e);
            }
            showAll(orders);
            //测试序列化
            Console.WriteLine("开始序列化");         
            orderSevice.Export();
            Order[] ordersXml = orderSevice.import();
            Console.WriteLine("开始反序列化");
            Console.WriteLine(ordersXml[0]);
        }

    }
}
