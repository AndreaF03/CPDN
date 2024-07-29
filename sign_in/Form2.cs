using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sign_in
{
    public partial class Form2 : Form
    {
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox1.Text.Trim();
            string email = maskedTextBox4.Text.Trim();
            string password = maskedTextBox3.Text.Trim();
            string city = maskedTextBox2.Text.Trim();
            string country = maskedTextBox5.Text.Trim(); // Corrected the textbox reference

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkEmailQuery = "SELECT COUNT(*) FROM login WHERE email = @Email";
            string insertQuery = "INSERT INTO login (name, email, password, city, country) VALUES (@Name, @Email, @Password, @City, @Country)";
            string updateQuery = "UPDATE login SET name = @Name, password = @Password, city = @City, country = @Country WHERE email = @Email";

            try
            {
                conn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Name", name);
                            updateCmd.Parameters.AddWithValue("@Email", email);
                            updateCmd.Parameters.AddWithValue("@Password", password); // Hash before storing
                            updateCmd.Parameters.AddWithValue("@City", city);
                            updateCmd.Parameters.AddWithValue("@Country", country);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Data updated successfully. Rows affected: " + rowsAffected);
                        }
                    }
                    else
                    {
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Name", name);
                            insertCmd.Parameters.AddWithValue("@Email", email);
                            insertCmd.Parameters.AddWithValue("@Password", password);
                            insertCmd.Parameters.AddWithValue("@City", city);
                            insertCmd.Parameters.AddWithValue("@Country", country);

                            int rowsAffected = insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully. Rows affected: " + rowsAffected);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expell form3 = new Expell();
            form3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler code
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Event handler code
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string name = maskedTextBox1.Text.Trim();
            string email = maskedTextBox4.Text.Trim();
            string password = maskedTextBox3.Text.Trim();
            string city = maskedTextBox2.Text.Trim();
            string country = maskedTextBox5.Text.Trim(); // Corrected the textbox reference

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkEmailQuery = "SELECT COUNT(*) FROM login WHERE email = @Email";
            string insertQuery = "INSERT INTO login (name, email, password, city, country) VALUES (@Name, @Email, @Password, @City, @Country)";
            string updateQuery = "UPDATE login SET name = @Name, password = @Password, city = @City, country = @Country WHERE email = @Email";

            try
            {
                conn.Open();

                using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Name", name);
                            updateCmd.Parameters.AddWithValue("@Email", email);
                            updateCmd.Parameters.AddWithValue("@Password", password); // Hash before storing
                            updateCmd.Parameters.AddWithValue("@City", city);
                            updateCmd.Parameters.AddWithValue("@Country", country);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Data updated successfully. Rows affected: " + rowsAffected);
                        }
                    }
                    else
                    {
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Name", name);
                            insertCmd.Parameters.AddWithValue("@Email", email);
                            insertCmd.Parameters.AddWithValue("@Password", password); // Hash before storing
                            insertCmd.Parameters.AddWithValue("@City", city);
                            insertCmd.Parameters.AddWithValue("@Country", country);

                            int rowsAffected = insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully. Rows affected: " + rowsAffected);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
    }
}
