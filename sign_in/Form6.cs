using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sign_in
{
    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (string.IsNullOrWhiteSpace(emailtxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM login WHERE email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFields();
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO login (email, password) VALUES (@Email, @Password)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@Email", emailtxt.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@Password", passwordtxt.Text.Trim());
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                Form1 form1 = new Form1();
                                form1.Show();
                                this.Hide();
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

        private void ClearFields()
        {
            emailtxt.Clear();
            passwordtxt.Clear();
            textBox1.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }
    }
}