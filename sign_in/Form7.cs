using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sign_in
{
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        private int getID;

        public Form7(int id)
        {
            InitializeComponent();
            getID = id;
            LoadTransactionData();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Any initialization logic can be added here
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting logic here
        }


        private void LoadTransactionData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM transaction_details WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", getID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            textBox1.Text = reader["tname"].ToString();
                            comboBox3.SelectedItem = reader["ttype"].ToString();
                            textBox2.Text = reader["tamount"].ToString();
                            textBox3.Text = reader["tdesc"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(reader["tdate"]);
                            comboBox2.SelectedItem = reader["tcategory"].ToString();
                            comboBox1.SelectedItem = reader["income_expense"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        string query = "UPDATE transaction_details SET tname = @tname, ttype = @ttype, tamount = @tamount, tdesc = @tdesc, tdate = @tdate, tcategory = @tcategory, income_expense = @income_expense WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", getID);
                            cmd.Parameters.AddWithValue("@tname", textBox1.Text);
                            cmd.Parameters.AddWithValue("@ttype", comboBox3.SelectedItem);
                            cmd.Parameters.AddWithValue("@tamount", Convert.ToDecimal(textBox2.Text));
                            cmd.Parameters.AddWithValue("@tdesc", textBox3.Text);
                            cmd.Parameters.AddWithValue("@tdate", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@tcategory", comboBox2.SelectedItem);
                            cmd.Parameters.AddWithValue("@income_expense", comboBox1.SelectedItem);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
