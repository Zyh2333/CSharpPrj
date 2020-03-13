using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    class Node<T> {
        public Node<T> Next { set; get; }
        public T data { set; get; }
        public Node(T t){
            this.data = t;
            this.Next = null;
       }
    } 
    class ArrayList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public ArrayList()
        {
            head = tail = null;
        }
        public void add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                tail = head = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        //参数为委托：该委托为参数为T的方法
        public void ForEach(Action<T> action)
        {
            //从头开始遍历
            Node<T> t = this.head;
            while (t != null)
            {
                Console.WriteLine(t.data);
                //委托申明：将要对t.data进行其他操作
                action(t.data);
                t = t.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            ArrayList<int> myList = new ArrayList<int>();
            myList.add(5);
            myList.add(10);
            int max = myList.head.data;
            int min = myList.head.data;
            Action<int> action = s=>sum += s;
            action += (s => { if (s > max) max = s; });
            action += (s => { if (s < min) min = s; }); ;
            myList.ForEach(action);
            Console.WriteLine($"{max}+{min}+{sum}");
        }
    }
}
