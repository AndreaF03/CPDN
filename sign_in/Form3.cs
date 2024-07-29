using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sign_in
{
    public partial class Expell : Form
    {
        private readonly string connectionString = @"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";
        private List<Class1> filteredList = new List<Class1>();

        public Expell()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            
            var class1 = new Class1();
            filteredList = class1.transactiondata();

            
            DisplayTodaysIncome();
            DisplayMonthlyIncome();
            DisplayYearlyIncome();
            DisplayTodaysExpense();
            DisplayMonthlyExpense();
            DisplayYearlyExpense();
            DisplayTotalBalance();

            
            PopulatePieChart();
        }

        private void DisplayTodaysIncome()
        {
            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Income' AND CAST(tdate AS DATE) = CAST(GETDATE() AS DATE)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal totalIncome = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label6.Text = $"Today's Income: {totalIncome:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMonthlyIncome()
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Income' AND YEAR(tdate) = @Year AND MONTH(tdate) = @Month";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", currentYear);
                        cmd.Parameters.AddWithValue("@Month", currentMonth);

                        object result = cmd.ExecuteScalar();
                        decimal totalIncome = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label13.Text = $"Monthly Income: {totalIncome:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayYearlyIncome()
        {
            int currentYear = DateTime.Now.Year;

            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Income' AND YEAR(tdate) = @Year";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", currentYear);

                        object result = cmd.ExecuteScalar();
                        decimal totalIncome = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label8.Text = $"Yearly Income: {totalIncome:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTodaysExpense()
        {
            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Expense' AND CAST(tdate AS DATE) = CAST(GETDATE() AS DATE)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal totalExpense = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label11.Text = $"Today's Expense: {totalExpense:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMonthlyExpense()
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Expense' AND YEAR(tdate) = @Year AND MONTH(tdate) = @Month";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", currentYear);
                        cmd.Parameters.AddWithValue("@Month", currentMonth);

                        object result = cmd.ExecuteScalar();
                        decimal totalExpense = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label10.Text = $"Monthly Expense: {totalExpense:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayYearlyExpense()
        {
            int currentYear = DateTime.Now.Year;

            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Expense' AND YEAR(tdate) = @Year";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", currentYear);

                        object result = cmd.ExecuteScalar();
                        decimal totalExpense = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label9.Text = $"Yearly Expense: {totalExpense:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayTotalBalance()
        {
            
            decimal totalIncome = GetTotalIncome();

            
            decimal totalExpenses = GetTotalExpenses();

            
            decimal totalBalance = totalIncome - totalExpenses;

            
            label24.Text = $"Total Balance: {totalBalance:C}";
        }

        private decimal GetTotalIncome()
        {
            int currentYear = DateTime.Now.Year;

            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Income' AND YEAR(tdate) = @Year";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", currentYear);

                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving income: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private decimal GetTotalExpenses()
        {
            int currentYear = DateTime.Now.Year;

            string query = "SELECT SUM(tamount) FROM transaction_details WHERE income_expense = 'Expense' AND YEAR(tdate) = @Year";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", currentYear);

                        object result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void PopulatePieChart()
        {
            
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            
            Series series = new Series
            {
                Name = "Categories",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie 
            };

            
            foreach (var categoryGroup in filteredList.GroupBy(d => d.Category))
            {
                series.Points.Add(new DataPoint
                {
                    AxisLabel = categoryGroup.Key,
                    YValues = new[] { Convert.ToDouble(categoryGroup.Sum(d => d.Amount)) }
                });
            }

            
            chart1.Series.Add(series);

            
            chart1.Legends.Add(new Legend("Legend"));
            chart1.Titles.Add("Expenses by Category");
        }

       
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Monthly_income_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void yearly_income_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void total_balance_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label24_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Expell_Load_1(object sender, EventArgs e)
        {
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8= new Form8();
            form8.Show();
            this.Hide();
        }
    }
}
