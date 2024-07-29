using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sign_in
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Load charts when the form loads
            LoadBalanceHistoryChart();
            LoadExpenseHistoryChart();
        }

        private void LoadBalanceHistoryChart()
        {
            
            var balanceHistory = new[]
            {
                new { Date = DateTime.Now.AddDays(-10), Balance = 1000 },
                new { Date = DateTime.Now.AddDays(-9), Balance = 1050 },
                new { Date = DateTime.Now.AddDays(-8), Balance = 1020 },
                new { Date = DateTime.Now.AddDays(-7), Balance = 1100 },
                new { Date = DateTime.Now.AddDays(-6), Balance = 1075 },
                new { Date = DateTime.Now.AddDays(-5), Balance = 1150 },
                new { Date = DateTime.Now.AddDays(-4), Balance = 1200 },
                new { Date = DateTime.Now.AddDays(-3), Balance = 1250 },
                new { Date = DateTime.Now.AddDays(-2), Balance = 1300 },
                new { Date = DateTime.Now.AddDays(-1), Balance = 1280 },
                new { Date = DateTime.Now, Balance = 1350 }
            };

            
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            
            ChartArea chartArea1 = new ChartArea
            {
                Name = "ChartArea1",
                AxisX = { MajorGrid = { LineWidth = 0 } }, 
                AxisY = { MajorGrid = { LineWidth = 0 } }  
            };
            chart1.ChartAreas.Add(chartArea1);

            
            Series series1 = new Series
            {
                Name = "Balance",
                ChartType = SeriesChartType.Spline,
                XValueType = ChartValueType.DateTime
            };
            chart1.Series.Add(series1);

            
            foreach (var dataPoint in balanceHistory)
            {
                series1.Points.AddXY(dataPoint.Date, dataPoint.Balance);
            }

            
            chart1.Titles.Clear();
            chart1.Titles.Add("Balance History");

            
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd MMM";

            
            chart1.ChartAreas[0].BackColor = Color.Transparent; 
            chart1.Legends.Clear(); 
        }

        private void LoadExpenseHistoryChart()
        {
            
            var expenseHistory = new[]
            {
                new { Day = "Monday", Amount = 150 },
                new { Day = "Tuesday", Amount = 200 },
                new { Day = "Wednesday", Amount = 175 },
                new { Day = "Thursday", Amount = 225 },
                new { Day = "Friday", Amount = 180 },
                new { Day = "Saturday", Amount = 160 },
                new { Day = "Sunday", Amount = 210 }
            };

            
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            
            ChartArea chartArea2 = new ChartArea
            {
                Name = "ChartArea1",
                AxisX = { MajorGrid = { LineWidth = 0 } }, 
                AxisY = { MajorGrid = { LineWidth = 0 } }  
            };
            chart2.ChartAreas.Add(chartArea2);

            
            Series series2 = new Series
            {
                Name = "Expenses",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };
            chart2.Series.Add(series2);

            
            foreach (var dataPoint in expenseHistory)
            {
                series2.Points.AddXY(dataPoint.Day, dataPoint.Amount);
            }

            
            chart2.Titles.Clear();
            chart2.Titles.Add("Weekly Expense History");

            
            chart2.ChartAreas[0].BackColor = Color.Transparent; 
            chart2.Legends.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            
        }

        private void chart3_Click(object sender, EventArgs e)
        {
            
            var weeklyActivity = new[]
            {
                new { Day = "Monday", Expense = 150, Income = 300 },
                new { Day = "Tuesday", Expense = 200, Income = 350 },
                new { Day = "Wednesday", Expense = 175, Income = 400 },
                new { Day = "Thursday", Expense = 225, Income = 250 },
                new { Day = "Friday", Expense = 180, Income = 300 },
                new { Day = "Saturday", Expense = 160, Income = 280 },
                new { Day = "Sunday", Expense = 210, Income = 350 }
            };

           
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();

            
            ChartArea chartArea3 = new ChartArea
            {
                Name = "ChartArea1",
                AxisX = { MajorGrid = { LineWidth = 0 } }, 
                AxisY = { MajorGrid = { LineWidth = 0 } } 
            };
            chart3.ChartAreas.Add(chartArea3);

            
            Series expenseSeries = new Series
            {
                Name = "Expenses",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                Color = Color.Red 
            };

            
            Series incomeSeries = new Series
            {
                Name = "Income",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                Color = Color.Green
            };

            chart3.Series.Add(expenseSeries);
            chart3.Series.Add(incomeSeries);

            // Populate the series with data
            foreach (var dataPoint in weeklyActivity)
            {
                expenseSeries.Points.AddXY(dataPoint.Day, dataPoint.Expense);
                incomeSeries.Points.AddXY(dataPoint.Day, dataPoint.Income);
            }

            
            chart3.Titles.Clear();
            chart3.Titles.Add("Weekly Activity of Expenses and Income");

            
            chart3.ChartAreas[0].BackColor = Color.Transparent; 
            chart3.Legends.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
