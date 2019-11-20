using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cs_gjj
{
    public partial class Form1 : Form
    {
        private double allinterest = 0.0;

        Dictionary<int, int> changeValue = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化默认值
            textBox_loan.Text = "120";
            comboBox_years.Items.Clear();
            for(int i = 1; i <= 25;i++)
            {
                comboBox_years.Items.Add(new ComboxItem(i + "年（" + (i * 12) + "期）", i));
            }
            comboBox_years.SelectedIndex = 14;
            textBox_rate.Text = "3.25";
            textBox_newvalue.Text = "5568";




        }

        //联动trackbar
        private void comboBox_years_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar_1.Minimum = 1;
            ComboxItem ci = (ComboxItem)comboBox_years.SelectedItem;
            trackBar_1.Maximum = ci.Value * 12;

            trackBar_1.Value = 1;

            listBox_newvalues.Items.Clear();
            changeValue.Clear();

        }

        //显示
        private void trackBar_1_Scroll(object sender, EventArgs e)
        {
            label_newvalue.Text = trackBar_1.Value + "期";
        }
        //添加自定义值
        private void button_addnew_Click(object sender, EventArgs e)
        {
            int newvalue = Convert.ToInt32(textBox_newvalue.Text);
            int term = trackBar_1.Value;
            if (changeValue.ContainsKey(term) == false)
            {
                changeValue.Add(term, newvalue);
                listBox_newvalues.Items.Add("从第" + term + "期开始变更为" + newvalue);
            }
            
        }



        //计算
        private void button_cal_Click(object sender, EventArgs e)
        {
            allinterest = 0.0;
            textBox_detail.Clear();
            int all_loan = Convert.ToInt32(textBox_loan.Text) * 10000;
            int term = ((ComboxItem)comboBox_years.SelectedItem).Value * 12;
            double rate = Convert.ToDouble(textBox_rate.Text) / 100.0;
            double pay = Convert.ToDouble(textBox_newvalue.Text);
            double balance = all_loan;
            for (int i = 1; i <= term - 1; i++)
            {
                balance = cal(balance, rate / 12.0, pay);
            }

            double last_interest = balance * rate / 12.0;
            allinterest += last_interest;
            double last_pay = balance + last_interest;
            Console.WriteLine("交款(last):" + last_pay + "   利息:" + last_interest + "  剩余：0" );
            textBox_detail.AppendText("交款(last):" + last_pay + "   利息:" + last_interest + "  剩余：0\r\n");
            

            //Console.WriteLine("all interest:" + allinterest);
            Console.WriteLine("利息总和:" + (last_pay + (term - 1) * pay - all_loan));
            textBox_detail.AppendText("利息总和:" + (last_pay + (term - 1) * pay - all_loan)+ "\r\n");
        }



        private double cal(double balance, double month_rate, double pay)
        {
            //month_rate = 0.00270833;
            double interest = balance * month_rate;//Math.Floor(balance * month_rate * 100.0) / 100.0;
            allinterest = allinterest + interest;
            double new_balance = balance - (pay - interest);
            Console.WriteLine("交款:" + pay + "   利息:" + interest + "  剩余：" + new_balance);
            textBox_detail.AppendText("交款:" + pay + "   利息:" + interest + "  剩余：" + new_balance + "\r\n");
            return new_balance;
        }
    }


    public class ComboxItem
    {
        public string Text = "";
        public int Value = 0;
        public ComboxItem(string _Text, int _Value)
        {
            Text = _Text;
            Value = _Value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
