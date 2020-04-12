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
    public partial class Form1 : Form
    {
        public OrderSevice orderSevice = new OrderSevice();
        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
            //this.LayoutMdi(MdiLayout.Cascade);
            searchComboBox.Items.Add("按订单号查询");
            searchComboBox.Items.Add("按日期查询");
            searchComboBox.Items.Add("按客户名查询");
        }
        private void createClient_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //form2.MdiParent = this;
            //注册事件
            form2.transform += addOrderEvent;
            form2.Show();
        }

        private void searchAll_Click(object sender, EventArgs e)
        {
            //绑定集合于中介
            this.orderBindingSource.DataSource = orderSevice.orders;
        }
        //接收子窗口传来的order对象
        private void addOrderEvent(Order order)
        {
            orderSevice.addOrder(order);
            orderBindingSource.ResetBindings(false);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (this.searchComboBox.SelectedIndex){
                case 0:
                    orderBindingSource.DataSource = orderSevice.findOrderByNum(int.Parse(searchText.Text));
                    break;
                case 1:
                    orderBindingSource.DataSource = orderSevice.findOrderByDate(int.Parse(searchText.Text));
                    break;
                case 2:
                    orderBindingSource.DataSource = orderSevice.findOrderByClientName(searchText.Text);
                    break;
                default:
                    this.orderBindingSource.DataSource = orderSevice.orders;
                    break;
            }         
        }

        private void import_Click(object sender, EventArgs e)
        {
            Order[] importOrders = orderSevice.import();
            for (int i = 0; i < importOrders.Length; i++) {
                orderSevice.addOrder(importOrders[i]);
                orderBindingSource.ResetBindings(false);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            orderSevice.Export();
        }

        private void update_Click(object sender, EventArgs e)
        {
            orderSevice.update(int.Parse(numUpdate.Text), int.Parse(dateUpdate.Text));
            orderBindingSource.ResetBindings(false);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            orderSevice.delete(int.Parse(numDelete.Text));
            orderBindingSource.ResetBindings(false);
        }
    }
}
