using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        //设置初始值
        private double th = -Math.PI / 2;
        //设置参数调整
        private Graphics graphics;
        private int dpth;
        private double len;
        private double rightDegree;
        private double leftDegree;
        private double rightPer;
        private double leftPer;

        public Form1()
        {
            InitializeComponent();
            this.panel2.BackColor = Color.White;
            panel1.Controls.Add(this.deepth);
            panel1.Controls.Add(this.length);
            panel1.Controls.Add(this.rPer);
            panel1.Controls.Add(this.lPer);
            panel1.Controls.Add(this.lPerBox);
            panel1.Controls.Add(this.rPerBox);
            panel1.Controls.Add(this.pen);
            panel1.Controls.Add(this.comboBox1);
            panel1.Controls.Add(this.dLeft);
            panel1.Controls.Add(this.create);
            panel1.Controls.Add(this.dLeftBox);
            panel1.Controls.Add(this.dRightBox);
            panel1.Controls.Add(this.lBox);
            panel1.Controls.Add(this.dBox);
        }
        
        public void set()
        {
            dpth = int.Parse(dBox.Text);
            len = double.Parse(lBox.Text);
            rightDegree = double.Parse(dRightBox.Text)*Math.PI/180;
            leftDegree = double.Parse(dLeftBox.Text)*Math.PI/180;
            rightPer = double.Parse(rPerBox.Text);
            leftPer = double.Parse(lPerBox.Text);
        }
        private void create_Click(object sender, EventArgs e)
        {
            set();
            if (graphics == null)
                graphics = this.CreateGraphics();
            else
            {    
                drawCayleyTree(panel2.Width/2, panel2.Height, len, dpth, th);
            }
        }
        void drawCayleyTree(double x0,double y0,double len,int n,double th)
        {
            if (n == 0) return;
            double x1 = x0 + len * Math.Cos(th);
            double y1= y0 + len * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(x1, y1, rightPer * len, n-1,th + rightDegree);
            drawCayleyTree(x1, y1, leftPer * len,n-1, th-leftDegree);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            Pen[] pens = { Pens.Blue, Pens.Green, Pens.Black };
            graphics = this.panel2.CreateGraphics();
            graphics.DrawLine(pens[comboBox1.SelectedIndex], (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.graphics.Clear(Color.White);
        }
    }
}
