
namespace sign_in
{
    partial class Expell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            Today_income = new Panel();
            label6 = new Label();
            Monthly_income = new Panel();
            label13 = new Label();
            yearly_income = new Panel();
            label8 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            Monthly_expense = new Panel();
            label10 = new Label();
            Today_expense = new Panel();
            label11 = new Label();
            total_balance = new Panel();
            label24 = new Label();
            button5 = new Button();
            button6 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2.SuspendLayout();
            Today_income.SuspendLayout();
            Monthly_income.SuspendLayout();
            yearly_income.SuspendLayout();
            panel9.SuspendLayout();
            Monthly_expense.SuspendLayout();
            Today_expense.SuspendLayout();
            total_balance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(11, -11);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 1571);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(-12, 476);
            button4.Name = "button4";
            button4.Size = new Size(236, 61);
            button4.TabIndex = 3;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(-12, 364);
            button3.Name = "button3";
            button3.Size = new Size(236, 59);
            button3.TabIndex = 2;
            button3.Text = "Report";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 76);
            label1.Name = "label1";
            label1.Size = new Size(179, 44);
            label1.TabIndex = 1;
            label1.Text = "Welcome,";
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(-12, 273);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(236, 59);
            button2.TabIndex = 1;
            button2.Text = "Transactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(-12, 168);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(236, 61);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.LightYellow;
            monthCalendar1.ForeColor = Color.LightGoldenrodYellow;
            monthCalendar1.Location = new Point(839, 157);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 3;
            monthCalendar1.TitleBackColor = Color.Black;
            monthCalendar1.TitleForeColor = Color.MintCream;
            monthCalendar1.TrailingForeColor = Color.Yellow;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Today_income
            // 
            Today_income.BackColor = SystemColors.Window;
            Today_income.Controls.Add(label6);
            Today_income.ForeColor = SystemColors.ControlLightLight;
            Today_income.Location = new Point(300, 520);
            Today_income.Name = "Today_income";
            Today_income.Size = new Size(399, 58);
            Today_income.TabIndex = 8;
            Today_income.Paint += panel6_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(2, 11);
            label6.Name = "label6";
            label6.Size = new Size(175, 27);
            label6.TabIndex = 0;
            label6.Text = "Today's Income :";
            label6.Click += label6_Click;
            // 
            // Monthly_income
            // 
            Monthly_income.BackColor = SystemColors.Window;
            Monthly_income.Controls.Add(label13);
            Monthly_income.ForeColor = SystemColors.ControlLightLight;
            Monthly_income.Location = new Point(302, 602);
            Monthly_income.Name = "Monthly_income";
            Monthly_income.Size = new Size(397, 60);
            Monthly_income.TabIndex = 9;
            Monthly_income.Paint += Monthly_income_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(7, 11);
            label13.Name = "label13";
            label13.Size = new Size(168, 27);
            label13.TabIndex = 2;
            label13.Text = "Monthly Income";
            // 
            // yearly_income
            // 
            yearly_income.BackColor = SystemColors.Window;
            yearly_income.Controls.Add(label8);
            yearly_income.ForeColor = SystemColors.ControlLightLight;
            yearly_income.Location = new Point(302, 694);
            yearly_income.Name = "yearly_income";
            yearly_income.Size = new Size(397, 60);
            yearly_income.TabIndex = 10;
            yearly_income.Paint += yearly_income_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(2, 11);
            label8.Name = "label8";
            label8.Size = new Size(151, 27);
            label8.TabIndex = 0;
            label8.Text = "Yearly Income";
            label8.Click += label8_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Window;
            panel9.Controls.Add(label9);
            panel9.ForeColor = SystemColors.ControlLightLight;
            panel9.Location = new Point(806, 694);
            panel9.Name = "panel9";
            panel9.Size = new Size(397, 60);
            panel9.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(2, 11);
            label9.Name = "label9";
            label9.Size = new Size(160, 27);
            label9.TabIndex = 0;
            label9.Text = "Yearly Expense";
            label9.Click += label9_Click;
            // 
            // Monthly_expense
            // 
            Monthly_expense.BackColor = SystemColors.Window;
            Monthly_expense.Controls.Add(label10);
            Monthly_expense.ForeColor = SystemColors.ControlLightLight;
            Monthly_expense.Location = new Point(806, 602);
            Monthly_expense.Name = "Monthly_expense";
            Monthly_expense.Size = new Size(397, 60);
            Monthly_expense.TabIndex = 12;
            Monthly_expense.Paint += panel10_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(2, 11);
            label10.Name = "label10";
            label10.Size = new Size(177, 27);
            label10.TabIndex = 0;
            label10.Text = "Monthly Expense";
            label10.Click += label10_Click;
            // 
            // Today_expense
            // 
            Today_expense.BackColor = SystemColors.Window;
            Today_expense.Controls.Add(label11);
            Today_expense.ForeColor = SystemColors.ControlLightLight;
            Today_expense.Location = new Point(804, 520);
            Today_expense.Name = "Today_expense";
            Today_expense.Size = new Size(399, 58);
            Today_expense.TabIndex = 11;
            Today_expense.Paint += panel11_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(2, 11);
            label11.Name = "label11";
            label11.Size = new Size(169, 27);
            label11.TabIndex = 0;
            label11.Text = "Today's Expense";
            // 
            // total_balance
            // 
            total_balance.BackColor = SystemColors.Window;
            total_balance.Controls.Add(label24);
            total_balance.ForeColor = SystemColors.ControlLightLight;
            total_balance.Location = new Point(804, 443);
            total_balance.Name = "total_balance";
            total_balance.Size = new Size(399, 58);
            total_balance.TabIndex = 12;
            total_balance.Paint += total_balance_Paint;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Trebuchet MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(5, 12);
            label24.Name = "label24";
            label24.Size = new Size(145, 27);
            label24.TabIndex = 0;
            label24.Text = "Total Balance";
            label24.Click += label24_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(330, 44);
            button5.Name = "button5";
            button5.Size = new Size(312, 90);
            button5.TabIndex = 14;
            button5.Text = "Enter Income";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkBlue;
            button6.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(780, 44);
            button6.Name = "button6";
            button6.Size = new Size(312, 90);
            button6.TabIndex = 15;
            button6.Text = "Enter Expense";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(304, 178);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(450, 293);
            chart1.TabIndex = 16;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click_1;
            // 
            // Expell
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1273, 814);
            Controls.Add(chart1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(total_balance);
            Controls.Add(panel9);
            Controls.Add(Monthly_expense);
            Controls.Add(Today_expense);
            Controls.Add(yearly_income);
            Controls.Add(Monthly_income);
            Controls.Add(Today_income);
            Controls.Add(monthCalendar1);
            Controls.Add(panel2);
            Name = "Expell";
            Text = "Expell";
            Load += Expell_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Today_income.ResumeLayout(false);
            Today_income.PerformLayout();
            Monthly_income.ResumeLayout(false);
            Monthly_income.PerformLayout();
            yearly_income.ResumeLayout(false);
            yearly_income.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            Monthly_expense.ResumeLayout(false);
            Monthly_expense.PerformLayout();
            Today_expense.ResumeLayout(false);
            Today_expense.PerformLayout();
            total_balance.ResumeLayout(false);
            total_balance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button4;
        private Button button3;
        private Label label1;
        private Button button2;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel Today_income;
        private Panel Monthly_income;
        private Panel yearly_income;
        private Label label8;
        private Panel panel9;
        private Label label9;
        private Panel Monthly_expense;
        private Label label10;
        private Panel Today_expense;
        private Label label11;
        private Label label13;
        private Label label19;
        private Label label16;
        private Label label20;
        private Label label14;
        private Panel total_balance;
        private Label label24;
        private Label label6;
        private Button button5;
        private Button button6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}