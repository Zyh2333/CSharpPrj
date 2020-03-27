using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Homework5.Tests
{
    [TestClass()]
    public class OrderSeviceTests
    {
        OrderSevice orderSevice = new OrderSevice();
        Order order1 = new Order("client1", 1, 1, DateTime.Now.Day, 1);
        Order order2 = new Order("client2", 2, 1, DateTime.Now.Day, 2);
        [TestInitialize]
        public void initial()
        {
            orderSevice.addOrder(order1);
            orderSevice.addOrder(order2);
        }
        [TestMethod()]
        public void addOrderTest()
        {
            //按订单号降序排序
            Assert.AreEqual(orderSevice.orders[0], order2);
            Assert.AreEqual(orderSevice.orders[1], order1);
        }

        [TestMethod()]
        public void findOrderByNumTest()
        {
            IEnumerable<Order> orders1 = orderSevice.findOrderByNum(1);
            Assert.AreEqual(orders1.ToArray()[0], order1);
        }

        [TestMethod()]
        public void findOrderByDateTest()
        {
            IEnumerable<Order> orders2 = orderSevice.findOrderByDate(DateTime.Now.Day);
            //按金额升序排序
            Assert.AreEqual(orders2.ToArray()[0], order1);
            Assert.AreEqual(orders2.ToArray()[1], order2);
        }

        [TestMethod()]
        public void findOrderByClientNameTest()
        {
            IEnumerable<Order> orders3 = orderSevice.findOrderByClientName("client1");
            Assert.AreEqual(orders3.ToArray()[0], order1);
        }

        [TestMethod()]
        public void updateTest()
        {
            //测试更新日期,根据订单号修改日期。
            orderSevice.update(1, 5);
            Assert.AreEqual(orderSevice.orders[1].date, 5);
        }

        [TestMethod()]
        public void deleteTest()
        {
            //删除订单号为1的订单
            orderSevice.delete(1);
            Assert.IsTrue(orderSevice.orders[0] == order2 && orderSevice.orders.ToArray().Length == 1);
        }

        [TestMethod()]
        public void ExportTest()
        {
            orderSevice.Export();
            Assert.IsTrue(File.Exists("orders.xml"));
        }

        [TestMethod()]
        public void importTest()
        {
            orderSevice.Export();
            Order[] orders4 = orderSevice.import();
            Assert.IsTrue(orders4[0].orderNum == order2.orderNum && orders4[1].orderNum == order1.orderNum);
        }
    }
}