using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace sign_in
{
    public partial class Form4 : Form
    {
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        private BindingList<Class1> dataList = new BindingList<Class1>();
        private BindingList<Class1> filteredList = new BindingList<Class1>();

        public Form4()
        {
            InitializeComponent();
            InitializeComboBoxes();
            DisplayData();
        }

        private void InitializeComboBoxes()
        {
            
            comboBox1.Items.Add("A-Z");
            comboBox1.Items.Add("Z-A");
            comboBox1.Items.Add("Date");

            
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; 
            }

            
            comboBox3.Items.Add("UPI");
            comboBox3.Items.Add("Cash");
            comboBox3.Items.Add("Card");
            comboBox3.Items.Add("All"); 

            
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0; 
            }
        }

        private void DisplayData()
        {
            try
            {
                Class1 dataHandler = new Class1();
                dataList = new BindingList<Class1>(dataHandler.transactiondata());
                filteredList = new BindingList<Class1>(dataList);
                SortData(); 

                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = filteredList;
                    if (dataGridView1.Columns["ID"] != null)
                    {
                        dataGridView1.Columns["ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while displaying data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortData();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void SortData()
        {
            if (filteredList == null || !filteredList.Any())
            {
                
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a sorting option.");
                return;
            }

            string sortOrder = comboBox1.SelectedItem.ToString();
            BindingList<Class1> sortedList;

            try
            {
                switch (sortOrder)
                {
                    case "A-Z":
                        sortedList = new BindingList<Class1>(filteredList.OrderBy(d => d.Name).ToList());
                        break;
                    case "Z-A":
                        sortedList = new BindingList<Class1>(filteredList.OrderByDescending(d => d.Name).ToList());
                        break;
                    case "Date":
                        sortedList = new BindingList<Class1>(filteredList.OrderBy(d => d.Date).ToList());
                        break;
                    default:
                        MessageBox.Show("Unexpected sorting option.");
                        return;
                }

                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = sortedList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during sorting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterData()
        {
            string selectedType = comboBox3.SelectedItem.ToString();
            if (selectedType == "All")
            {
                filteredList = new BindingList<Class1>(dataList);
            }
            else
            {
                filteredList = new BindingList<Class1>(dataList.Where(d => d.Type == selectedType).ToList());
            }
            SortData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expell expellForm = new Expell();
            expellForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private int getID = 0;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                // You may use this ID for other operations if needed
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (getID > 0)
            {
                var itemToRemove = filteredList.FirstOrDefault(d => d.ID == getID);
                if (itemToRemove != null)
                {
                    filteredList.Remove(itemToRemove);
                    DeleteRowFromDatabase(getID);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void DeleteRowFromDatabase(int id)
        {
            try
            {
                string query = "DELETE FROM transaction_details WHERE ID = @ID";
                using (SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (getID > 0)
            {
                Form7 form7 = new Form7(getID);
                form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
