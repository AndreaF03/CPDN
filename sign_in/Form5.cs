using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sign_in
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Initialization logic if needed
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || comboBox3.SelectedIndex == -1 || string.IsNullOrEmpty(textBox2.Text) || comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True"))
                    {
                        conn.Open();
                        string query = "INSERT INTO transaction_details (tname, ttype, tamount, tdesc, tdate, tcategory, income_expense) VALUES (@tname, @ttype, @tamount, @tdesc, @tdate, @tcategory, @income_expense)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@tname", textBox1.Text);
                            cmd.Parameters.AddWithValue("@ttype", comboBox3.SelectedItem);
                            cmd.Parameters.AddWithValue("@tamount", Convert.ToDecimal(textBox2.Text));
                            cmd.Parameters.AddWithValue("@tdesc", textBox3.Text);
                            cmd.Parameters.AddWithValue("@tdate", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@tcategory", comboBox2.SelectedItem);
                            cmd.Parameters.AddWithValue("@income_expense", comboBox1.SelectedItem);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("All the inputs are added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel paint event if needed
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
