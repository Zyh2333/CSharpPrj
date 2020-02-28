using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorApp1
{
    public partial class Form1 : Form
    {   
        //该函数是窗体构建函数
        public Form1()
        {
            InitializeComponent();
            addCombobox();
        }
        public void addCombobox()
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
        private void caculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                //char op1 = Convert.ToChar(op.Text);
                char op1 = Convert.ToChar(comboBox1.Text);
                double result = 0;
                switch (op1)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/':
                        if (num2 == 0) { Console.WriteLine("The second num can not be 0"); }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        this.result.Text = ("The operator is false");
                        break;
                }
                this.result.Text = Convert.ToString(result);
            }
            catch (OverflowException)
            {
                result.Text = "The result is overflow";
                return;
            }
            catch (FormatException)//检查操作数的合法性
            {
                result.Text = "The number is wrong";
                return;
            }
            Console.ReadKey();
        }
    }
}
