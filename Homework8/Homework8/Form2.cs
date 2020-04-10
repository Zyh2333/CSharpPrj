using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework5;
namespace Homework8
{
    public delegate void getOrder(Order order);
    public partial class Form2 : Form
    {
        Client currentClient;
        //获取上次最后一个订单的订单号的工具,读文件
        OrderSevice orderSevice = new OrderSevice();
        static int orderNum;
        //代理子窗口向父窗口传值
        public event getOrder transform;
        public Form2()
        {
            InitializeComponent();
            this.splitContainer1.Panel2.Hide();
        }

        private void client_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Show();
        }
        //自动创建订单对象
        private void order_Click(object sender, EventArgs e)
        {
            Order[] orders = orderSevice.import();
            if (orders == null)
            {
                orderNum = 1;
            }
            else
            {
                orderNum = orders[orders.Length - 1].orderNum + 1;
            }
            currentClient = new Client(clientName.Text);
            currentClient.buyGood(int.Parse(good1Num.Text), int.Parse(good2Num.Text), orderNum);
            orderNum++;
            //orderBindingSource.DataSource = currentClient.GetOrder();
            //orderSevice.addOrder(currentClient.GetOrder());
            //触发事件,向父窗口传值
            transform(currentClient.GetOrder());
            this.Close();
        }
    }
}
