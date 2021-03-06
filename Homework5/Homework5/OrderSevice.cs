﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class OrderSevice
    {
        public List<Order> orders = new List<Order>();
        public void addOrder(Order order)
        {
            bool can = true;
            foreach (Order order1 in orders)
            {
                if (order1.Equals(order))
                {
                    can = false;
                }
            }
            if (can)
            {
                orders.Add(order);
                orders.Sort((o1, o2) => o2.orderNum - o1.orderNum);
            }
            else
            {
                throw new RepeatException();
            }
        }
        //通过订单号用LINQ语句查询
        public IEnumerable<Order> findOrderByNum(int number)
        {
            var result = orders.Where(o => o.orderNum.Equals(number));
            return result;
        }
        public IEnumerable<Order> findOrderByDate(int date)
        {
            var result = orders.Where(o => o.date == date).OrderBy(s => s.getMoney());
            return result;
        }
        public IEnumerable<Order> findOrderByClientName(String name)
        {
            var result = orders.Where(o => o.client.Equals(name));
            return result;
        }
        //暂时只支持修改日期，否则会引起订单与明细数据不一致问题
        public void update(int number,int date)
        {
            bool has = false;
            foreach (var current in orders)
            {
                if (current.orderNum.Equals(number))
                {
                    has = true;
                    current.setDate(date);
                }
            }
            if (!has)
            {
                throw new UpdateException();
            }
        }
        //按订单号删除记录
        public void delete(int number)
        {
            bool has = false;
            //List<Order> delete = new List<Order>();
            foreach (var current in orders.ToArray())
            {
                if (current.orderNum.Equals(number))
                {
                    has = true;
                    //delete.Add(current);
                    orders.Remove(current);
                }
            }
            if (!has)
            {
                throw new DeleteException();
            }
        }
    }
}
