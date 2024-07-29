using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace sign_in
{
    public class Class1
    {
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=ANDREA\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string IncomeExpense { get; set; }

        public List<Class1> transactiondata()
        {
            List<Class1> list = new List<Class1>();
            conn.Open();
            string query = "SELECT * FROM transaction_details";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Class1 cd = new Class1
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["tname"].ToString(),
                        Description = reader["tdesc"].ToString(),
                        Type = reader["ttype"].ToString(),
                        Amount = Convert.ToDecimal(reader["tamount"]),
                        Category = reader["tcategory"].ToString(),
                        Date = Convert.ToDateTime(reader["tdate"]),
                        IncomeExpense = reader["income_expense"].ToString()
                    };
                    list.Add(cd);
                }
            }
            conn.Close();
            return list;
        }
    }
}
