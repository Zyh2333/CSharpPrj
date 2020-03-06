using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    abstract class Graph
    {
        protected double bottom;
        protected double height;
        protected bool isTrue;
        public static double sum;
        public Graph(double bt, double ht)
        {
            this.bottom = bt;
            this.height = ht;
        }
        abstract public bool islegal { get; set; }
        public abstract double getSquare();
    }
    class Rectangle : Graph
    {
        public Rectangle(double item1, double item2) : base(item1, item2) {
            this.islegal = true;
            if (islegal)
            {
                this.getSquare();
            }
        }
        public override bool islegal {
            get =>isTrue;
            set
            {
                if (this.bottom > 0 && this.height > 0)
                    isTrue = true;
                else
                {
                    isTrue = false;
                    throw new Exception("输入的底或高非法");
                }
            }
        }
        public override double getSquare()
        {
            sum+= this.bottom * this.height;
            return this.bottom * this.height;            
        }
    }
    class Square : Graph
    {
        private double side;
        public Square(double side) : base(side, side)
        {
            this.side = side;
            this.islegal = true;
            if (islegal)
            {
                this.getSquare();
            }
        }
        public override bool islegal
        {
            get => isTrue;
            set
            {
                if (side>0)
                    isTrue = true;
                else
                {
                    isTrue = false;
                    throw new Exception("输入的边长非法");
                }
            }
        }
        public override double getSquare()
        {
            sum += side * side;
            return side * side;
        }
    }
    class Triangle : Graph
    {
        private double r1;
        private double r2;
        private double r3;
        public Triangle(double item1, double item2, double r1, double r2, double r3) : base(item1, item2)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.islegal = true;
            if (islegal)
            {
                this.getSquare();
            }
        }
        public override bool islegal
        {
            get => isTrue;
            set
            {
                if ((this.bottom > 0 && this.height > 0)&& (r1 + r2 > r3 && r1 + r3 > r2 && r2 + r3 > r1))
                    isTrue = true;
                else
                {
                    isTrue = false;
                    throw new Exception("输入的三角形非法");
                }
            }
        }
        public override double getSquare()
        {
            sum += height * bottom / 2;
            return height * bottom / 2;           
        }
    }
    class Factory
    {
        public Rectangle getBean(double t1,double t2)
        {
            return new Rectangle(t1, t2);
        }
        public Square getBean(double t1)
        {
            return new Square(t1);
        }
        public Triangle getBean(double item1, double item2, double r1, double r2, double r3)
        {
            return new Triangle(item1,item2,r1,r2,r3);
        }
    }
    class Test
    {
        public static void Main()
        {
            Factory f = new Factory();
            Graph t1 = f.getBean(1, 6);
            Graph t2 = f.getBean(3);
            Graph t3 = f.getBean(3, 4, 5, 3, 4);;
            Graph t4 = f.getBean(3, 6);
            Graph t5 = f.getBean(6);
            Graph t6 = f.getBean(4, 2.1);
            Graph t7 = f.getBean(5.5);
            Graph t8 = f.getBean(5);
            Graph t9 = f.getBean(5,8);
            Graph t10 = f.getBean(6,8,6,8,10);
            Console.WriteLine($"面积之和为：{Graph.sum}");
            //异常示例：
            //Graph t11 = f.getBean(-2);
            //Graph t12 = f.getBean(4, -2.1);
            //Graph t13 = f.getBean(4, 2.1,4,8,100);
        }
    }
}
