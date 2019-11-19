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
            textBox_rate.Text = "3.75";
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
            int all_loan = Convert.ToInt32(textBox_loan.Text);
            int term = ((ComboxItem)comboBox_years.SelectedItem).Value;

        }



        private double cal(double banlance, double month_rate, double pay)
        {
            return 0.0;
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
