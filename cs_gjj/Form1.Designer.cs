namespace cs_gjj
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_plan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.comboBox_years = new System.Windows.Forms.ComboBox();
            this.textBox_loan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_addnew = new System.Windows.Forms.Button();
            this.textBox_newvalue = new System.Windows.Forms.TextBox();
            this.trackBar_1 = new System.Windows.Forms.TrackBar();
            this.label_newvalue = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_newvalues = new System.Windows.Forms.ListBox();
            this.button_cal = new System.Windows.Forms.Button();
            this.listView_detail = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_summary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_plan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_rate);
            this.groupBox1.Controls.Add(this.comboBox_years);
            this.groupBox1.Controls.Add(this.textBox_loan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本配置";
            // 
            // comboBox_plan
            // 
            this.comboBox_plan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_plan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_plan.FormattingEnabled = true;
            this.comboBox_plan.Location = new System.Drawing.Point(65, 109);
            this.comboBox_plan.Name = "comboBox_plan";
            this.comboBox_plan.Size = new System.Drawing.Size(183, 20);
            this.comboBox_plan.TabIndex = 12;
            this.comboBox_plan.SelectedIndexChanged += new System.EventHandler(this.comboBox_plan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "预设方案";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "年利率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "贷款时长";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "万元";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "贷款额";
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(66, 77);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(35, 21);
            this.textBox_rate.TabIndex = 5;
            // 
            // comboBox_years
            // 
            this.comboBox_years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_years.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_years.FormattingEnabled = true;
            this.comboBox_years.Location = new System.Drawing.Point(66, 46);
            this.comboBox_years.Name = "comboBox_years";
            this.comboBox_years.Size = new System.Drawing.Size(104, 20);
            this.comboBox_years.TabIndex = 4;
            this.comboBox_years.SelectedIndexChanged += new System.EventHandler(this.comboBox_years_SelectedIndexChanged);
            // 
            // textBox_loan
            // 
            this.textBox_loan.Location = new System.Drawing.Point(66, 17);
            this.textBox_loan.Name = "textBox_loan";
            this.textBox_loan.Size = new System.Drawing.Size(35, 21);
            this.textBox_loan.TabIndex = 3;
            this.textBox_loan.Text = "120";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_addnew);
            this.groupBox2.Controls.Add(this.textBox_newvalue);
            this.groupBox2.Controls.Add(this.trackBar_1);
            this.groupBox2.Controls.Add(this.label_newvalue);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义方案-调整额度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "新还款额";
            // 
            // button_addnew
            // 
            this.button_addnew.Location = new System.Drawing.Point(173, 90);
            this.button_addnew.Name = "button_addnew";
            this.button_addnew.Size = new System.Drawing.Size(75, 23);
            this.button_addnew.TabIndex = 3;
            this.button_addnew.Text = "添加";
            this.button_addnew.UseVisualStyleBackColor = true;
            this.button_addnew.Click += new System.EventHandler(this.button_addnew_Click);
            // 
            // textBox_newvalue
            // 
            this.textBox_newvalue.Location = new System.Drawing.Point(87, 20);
            this.textBox_newvalue.Name = "textBox_newvalue";
            this.textBox_newvalue.Size = new System.Drawing.Size(100, 21);
            this.textBox_newvalue.TabIndex = 2;
            // 
            // trackBar_1
            // 
            this.trackBar_1.Location = new System.Drawing.Point(6, 47);
            this.trackBar_1.Name = "trackBar_1";
            this.trackBar_1.Size = new System.Drawing.Size(242, 45);
            this.trackBar_1.TabIndex = 1;
            this.trackBar_1.Scroll += new System.EventHandler(this.trackBar_1_Scroll);
            // 
            // label_newvalue
            // 
            this.label_newvalue.AutoSize = true;
            this.label_newvalue.Location = new System.Drawing.Point(21, 95);
            this.label_newvalue.Name = "label_newvalue";
            this.label_newvalue.Size = new System.Drawing.Size(41, 12);
            this.label_newvalue.TabIndex = 0;
            this.label_newvalue.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_newvalues);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 267);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "调整记录";
            // 
            // listBox_newvalues
            // 
            this.listBox_newvalues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_newvalues.FormattingEnabled = true;
            this.listBox_newvalues.ItemHeight = 12;
            this.listBox_newvalues.Location = new System.Drawing.Point(3, 17);
            this.listBox_newvalues.Name = "listBox_newvalues";
            this.listBox_newvalues.Size = new System.Drawing.Size(248, 247);
            this.listBox_newvalues.TabIndex = 0;
            // 
            // button_cal
            // 
            this.button_cal.Location = new System.Drawing.Point(272, 12);
            this.button_cal.Name = "button_cal";
            this.button_cal.Size = new System.Drawing.Size(479, 38);
            this.button_cal.TabIndex = 7;
            this.button_cal.Text = "计算";
            this.button_cal.UseVisualStyleBackColor = true;
            this.button_cal.Click += new System.EventHandler(this.button_cal_Click);
            // 
            // listView_detail
            // 
            this.listView_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_detail.FullRowSelect = true;
            this.listView_detail.GridLines = true;
            this.listView_detail.Location = new System.Drawing.Point(272, 56);
            this.listView_detail.Name = "listView_detail";
            this.listView_detail.Size = new System.Drawing.Size(479, 445);
            this.listView_detail.TabIndex = 8;
            this.listView_detail.UseCompatibleStateImageBehavior = false;
            this.listView_detail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "期数";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "还款额";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "利息";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "本金";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "剩余本金";
            this.columnHeader4.Width = 242;
            // 
            // textBox_summary
            // 
            this.textBox_summary.Location = new System.Drawing.Point(273, 507);
            this.textBox_summary.Multiline = true;
            this.textBox_summary.Name = "textBox_summary";
            this.textBox_summary.ReadOnly = true;
            this.textBox_summary.Size = new System.Drawing.Size(478, 50);
            this.textBox_summary.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 569);
            this.Controls.Add(this.textBox_summary);
            this.Controls.Add(this.listView_detail);
            this.Controls.Add(this.button_cal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "公积金自由还款计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.ComboBox comboBox_years;
        private System.Windows.Forms.TextBox textBox_loan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_newvalue;
        private System.Windows.Forms.TrackBar trackBar_1;
        private System.Windows.Forms.TextBox textBox_newvalue;
        private System.Windows.Forms.Button button_addnew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_newvalues;
        private System.Windows.Forms.Button button_cal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_plan;
        private System.Windows.Forms.ListView listView_detail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBox_summary;
        private System.Windows.Forms.Button button1;
    }
}

