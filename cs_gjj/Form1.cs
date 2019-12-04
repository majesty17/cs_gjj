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

        //总利息
        private double allinterest = 0.0;

        //默认利率
        private double default_rate_0 = 2.75;
        private double default_rate_1 = 3.25;


        //用户添加的调整值
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
            textBox_rate.Text = default_rate_1.ToString();
            textBox_newvalue.Text = "5568";
            textBox_monthpay.Text = "5568";


            //预设方案
            comboBox_plan.Items.Clear();
            comboBox_plan.Items.Add(new ComboxItem("1，连续固定值，最后一次还清（默认）", 1));
            comboBox_plan.Items.Add(new ComboxItem("2，等额本息（每次还款一样）", 2));
            comboBox_plan.Items.Add(new ComboxItem("3，等额本金（每月还款递减）", 3));
            comboBox_plan.Items.Add(new ComboxItem("4，每年递减（复合型1）", 4));
            comboBox_plan.Items.Add(new ComboxItem("5，每半年递减（复合型2）", 5));
            comboBox_plan.Items.Add(new ComboxItem("6，每季度递减（复合型3）", 6));
            comboBox_plan.Items.Add(new ComboxItem("7，自定义", 7));
            comboBox_plan.SelectedIndex = 0;


        }

        //联动trackbar、利率、等额本金钱数;
        private void comboBox_years_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar_1.Minimum = 1;
            ComboxItem ci = (ComboxItem)comboBox_years.SelectedItem;
            trackBar_1.Maximum = ci.Value * 12;

            trackBar_1.Value = 1;

            listBox_newvalues.Items.Clear();
            changeValue.Clear();

            //联动利率
            if (ci.Value <= 5)
            {
                textBox_rate.Text = default_rate_0.ToString();
            }else
            {
                textBox_rate.Text = default_rate_1.ToString();
            }


        }


        //预设方案调整
        private void comboBox_plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboxItem ci = (ComboxItem)comboBox_plan.SelectedItem;
            int value = ci.Value;

            if (value <= 6)
            {
                textBox_newvalue.Enabled = false;
                trackBar_1.Enabled = false;
                listBox_newvalues.Enabled = false;
                button_addnew.Enabled = false;
            }
            else if (value == 7)
            {

                textBox_newvalue.Enabled = true;
                trackBar_1.Enabled = true;
                listBox_newvalues.Enabled = true;
                button_addnew.Enabled = true;
            }

            if (value == 1 || value == 4 || value==5 || value==6)
            {
                textBox_monthpay.Enabled = true;
            }
            else
            {
                textBox_monthpay.Enabled = false;
            }


            if(value==4 || value == 5 || value==6)
            {
                label8.Text = "递减额";
            }
            else
            {
                label8.Text = "月还款额";
            }



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
            listView_detail.Items.Clear();
            textBox_summary.Clear();

            int all_loan = Convert.ToInt32(textBox_loan.Text) * 10000;
            int term = ((ComboxItem)comboBox_years.SelectedItem).Value * 12;
            double rate = Convert.ToDouble(textBox_rate.Text) / 100.0;
            double rate_month = rate / 12.0;
            double balance = all_loan;
            double month_pay = Convert.ToDouble(textBox_monthpay.Text);


            int plan_type = ((ComboxItem)comboBox_plan.SelectedItem).Value;



            if (plan_type == 1) {
                //前term-1次，最小值
                for (int i = 1; i <= term - 1; i++)
                {
                    balance = cal(balance, rate_month, month_pay, i);
                }
                //最后一次还剩余的
                double last_interest = balance * rate_month;
                allinterest += last_interest;
                double last_pay = balance + last_interest;


                Console.WriteLine("交款(last):" + last_pay + "   利息:" + last_interest + "  剩余：0");
                //textBox_detail.AppendText("交款(last):" + last_pay + "   利息:" + last_interest + "  剩余：0\r\n");
                ListViewItem lvi = new ListViewItem("第" + string.Format("{0:D3}", term) + "期|第" +
                string.Format("{0:D2}", (term / 12)) + "年");
                lvi.SubItems.Add(decimalFormat(last_pay));
                lvi.SubItems.Add(decimalFormat(last_interest));
                lvi.SubItems.Add(decimalFormat(last_pay - last_interest));
                lvi.SubItems.Add(decimalFormat(0f));

                listView_detail.Items.Add(lvi);




                //Console.WriteLine("all interest:" + allinterest);
                Console.WriteLine("利息总和:" + (last_pay + (term - 1) * month_pay - all_loan));
                //textBox_detail.AppendText("利息总和:" + (last_pay + (term - 1) * pay - all_loan) + "\r\n");
                textBox_summary.AppendText("利息总和:" + (last_pay + (term - 1) * month_pay - all_loan) + "\r\n");
            }
            else if (plan_type==2)
            {

                //等额本息: 贷款本金×[月利率×(1+月利率) ^ 还款月数]÷{[(1+月利率) ^ 还款月数]-1}
                /**复杂的一比。。
                某期还款后剩余本金：
                “=贷款金额-（（PMT(每期利率，还款期数，贷款金额)*当前期数-（贷款额*期利率-月偿还额）*（（1+期利率）^当前期数-1）/期利率+当前期数*月偿还额））”
                某期还款后剩余利息：
                “=PMT(每期利率，还款期数，贷款金额)*偿还期数-贷款金额-（贷款额*期利率-月偿还额）*（（1+期利率）^当前期数-1）/期利率+当前期数*月偿还额”
                 *
                 * **/

                double pay_month = balance * (rate_month * Math.Pow(1.0 + rate_month, term)) /
                    (Math.Pow(1 + rate_month, term) - 1.0);


                for (int i = 1; i <= term; i++)
                {
                    balance = cal(balance, rate_month, pay_month, i);
                }
                textBox_summary.AppendText("利息总和1:" + (pay_month * term - all_loan) + "\r\n");
                textBox_summary.AppendText("利息总和2:" + (allinterest) + "\r\n");
            }
            else if (plan_type==3)
            {
                //等额本金
                double month_principal = all_loan / term; //每月需偿还的本金
                for (int i = 1; i <= term; i++)
                {
                    ListViewItem lvi = new ListViewItem("第" + string.Format("{0:D3}", term) + "期|第" +
                        string.Format("{0:D2}", (term / 12)) + "年");

                    double this_interest = rate_month * month_principal * (term - i + 1);
                    double this_pay = month_principal + this_interest;
                    allinterest = allinterest + this_interest;

                    lvi.SubItems.Add(decimalFormat(this_pay));
                    lvi.SubItems.Add(decimalFormat(this_interest));
                    lvi.SubItems.Add(decimalFormat(month_principal));
                    lvi.SubItems.Add(decimalFormat(all_loan - i * month_principal));

                    listView_detail.Items.Add(lvi);
                }
                textBox_summary.AppendText("利息总和2:" + (allinterest) + "\r\n");
            }

            else if(plan_type==4 || plan_type==5 || plan_type==6)
            {
                //每x递减
                int incstep = 12;//每年调整
                if (plan_type == 5) incstep = 6;//每半年调整
                if (plan_type == 6) incstep = 3;//每季度调整

                double maxdec = GetMaxDecmoney(balance, rate_month, term, incstep);
                double mydec = Convert.ToDouble(textBox_monthpay.Text);

                if (mydec>maxdec)
                {
                    MessageBox.Show("递减值过大:" + mydec + ">" + maxdec);
                    return;
                }


                calResultDJ(all_loan, rate_month, term, mydec, incstep);

            }




        }


        //计算某期交款额为pay的情况下的利息和本金，返回剩余本金
        private double cal(double balance, double month_rate, double pay,int terms)
        {
            //month_rate = 0.00270833;
            double interest = balance * month_rate;//Math.Floor(balance * month_rate * 100.0) / 100.0;
            allinterest = allinterest + interest;
            double new_balance = balance - (pay - interest);
            Console.WriteLine("交款:" + pay + "   利息:" + interest + "  剩余：" + new_balance);
            //textBox_detail.AppendText("交款:" + pay + "   利息:" + interest + "  剩余：" + new_balance + "\r\n");


            ListViewItem lvi = new ListViewItem("第" + string.Format("{0:D3}", terms) + "期|第" +
                string.Format("{0:D2}", ((terms - 1) / 12) + 1) + "年");
            lvi.SubItems.Add(decimalFormat(pay));
            lvi.SubItems.Add(decimalFormat(interest));
            lvi.SubItems.Add(decimalFormat(pay-interest));
            lvi.SubItems.Add(decimalFormat(new_balance));



            listView_detail.Items.Add(lvi);
            return new_balance;
        }



        //获取最大还款递减额
        private double GetMaxDecmoney(double total, double monthrate, int terms, int incstep)
        {

            double we = terms % incstep;    //这个应该是0
            int v = terms / incstep;        //有多少个等值块


            double tmp1 = (total * monthrate * (Math.Pow(1.0 + monthrate, terms))) / (Math.Pow(1.0 + monthrate, terms) - 1.0);
            double tmp2 = 1 / (Math.Pow(1 + monthrate, terms) - 1);
            double tmp3 = Math.Pow(1 + monthrate, we) * (Math.Pow(1 + monthrate, (v + 1) * incstep) - 1) / (Math.Pow(1 + monthrate, incstep) - 1);

            return tmp1 / ((v + 1.0) - tmp2 * (tmp3 - (v + 1.0)));
        }


        //递减还款

        private void calResultDJ(double total,double monthrate,int terms,double decmoney,int incstep)
        {
            double capMon, corpusMon, varerestMon;//月供，月供本金，月供利息
            double capTotle = 0, corpusTotle = 0, varerestTotle = 0;
            double corpusLeft = total;//还款本金
            double corpusLeftMon = total;//本金余额
            //var rate = (parseFloat(yearrate)) / 100 / 12;//月利率
            //double sbResultDJ;
            //sbResultDJ = createTable(sbResultDJ);
            double totalpay22 = 0;
            double totalrate22 = 0;
            double monthpay22 = 0;
            double remain22 = total;
            for (int k = 1; k <= terms; k++)
            {

                monthpay22 = GetMonthPayDZ(total, monthrate, terms, k, decmoney, incstep);
                totalpay22 = totalpay22 + monthpay22;

                //remain22 = remain22 - GetMonthCapital(remain22, monthpay22, yearrate);
                remain22 = remain22 - (monthpay22-remain22*monthrate);


                var ratePow = Math.Pow(monthrate + 1, terms);

                capMon = monthpay22;//月供
                varerestMon = corpusLeftMon * monthrate;//月供利息
                corpusMon = capMon - varerestMon;//月供本金

                corpusLeftMon -= corpusMon;//本金余额
                capTotle += capMon;
                varerestTotle += varerestMon;
                corpusTotle += corpusMon;

                //table,期数，月供，月供利息，月供本金，本金余额，利率
                //sbResultDJ = output(sbResultDJ, k, capMon, varerestMon, corpusMon, corpusLeftMon, rate * 12 * 100);
                ListViewItem lvi = new ListViewItem("第" + string.Format("{0:D3}", k) + "期|第" +
                string.Format("{0:D2}", ((k - 1) / 12) + 1) + "年");
                lvi.SubItems.Add(decimalFormat(monthpay22));
                lvi.SubItems.Add(decimalFormat(varerestMon));
                lvi.SubItems.Add(decimalFormat(corpusMon));
                lvi.SubItems.Add(decimalFormat(corpusLeftMon));



                listView_detail.Items.Add(lvi);
            }



            textBox_summary.Text = "利息总和:" + (varerestTotle) + "\r\n";



        }

        private double GetMonthPayDZ(double total, double monthrate, int termnum,int currindex, double decmoney,int incsp)
        {
            if (currindex > termnum)
                return 0;

            int we = termnum % incsp;
            int v = termnum / incsp;


            var tmp1 = (total * monthrate * (Math.Pow(1 + monthrate, termnum))) / (Math.Pow(1 + monthrate, termnum) - 1);
            var tmp2 = -decmoney / (Math.Pow(1 + monthrate, termnum) - 1);
            var tmp3 = Math.Pow(1 + monthrate, we) * (Math.Pow(1 + monthrate, (v + 1) * incsp) - 1) / (Math.Pow(1 + monthrate, incsp) - 1);

            var A = tmp1 - tmp2 * (tmp3 - (v + 1));


            var t = (currindex-1) / incsp + 1;

            return A - t * decmoney;

        }


        //计算最小还款额度
        private double minPay(double principal,double rate_month,int terms)
        {
            double p0 = 533033;
            double ret = 0.0;
            if (terms<=5*12)
            {
                ret = principal * rate_month * (Math.Pow(1 + rate_month, terms)) / (Math.Pow(1 + rate_month, terms) - 1);
            }
            else if (terms>5*12)
            {

                ret = p0 * rate_month * (Math.Pow(1 + rate_month, terms - 1)) / (Math.Pow(1 + rate_month, terms - 1) - 1) + (principal - p0) * 1;
            }
            return ret;
        }




        //double转换为保留两位小数的string
        private string decimalFormat(double x)
        {
            //double ret = Math.Floor(x * 100) / 100.0;
            //double ret = Math.Round(x, 2);
            //return Convert.ToString(ret);
            return string.Format("{0:F2}", x);
        }


        //test
        private void button1_Click(object sender, EventArgs e)
        {
            int all_loan = Convert.ToInt32(textBox_loan.Text) * 10000;
            int term = ((ComboxItem)comboBox_years.SelectedItem).Value * 12;
            double rate = Convert.ToDouble(textBox_rate.Text) / 100.0;
            double rate_month = rate / 12.0;
            double pay = Convert.ToDouble(textBox_newvalue.Text);
            double balance = all_loan;

            double min = minPay(all_loan, rate_month, term);
            //MessageBox.Show(min.ToString());

            double maxdec = GetMaxDecmoney(1200000.0, 3.25 / 100.0 / 12.0, 15 * 12, 12);
            MessageBox.Show(maxdec+"");
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
