using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoes_Management_store
{

    public partial class Customer : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True");

        public Customer()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void Create_Click(object sender, EventArgs e)
        {
            string Name = Customer_Name.Text;
            int Age = int.Parse(Customer_Age.Text);
            string Email = Customer_Email.Text;
            string Contact = Customer_Contact.Text;

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand c = new SqlCommand("EXEC AddCustomer @Name, @Age, @Email, @Contact", con))
                    {
                        c.Parameters.AddWithValue("@Name", Name);
                        c.Parameters.AddWithValue("@Age", Age);
                        c.Parameters.AddWithValue("@Email", Email);
                        c.Parameters.AddWithValue("@Contact", Contact);

                        c.ExecuteNonQuery();
                        MessageBox.Show("Successfully inserted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand c = new SqlCommand("ReadCustomer", con))
                    {
                        c.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter sd = new SqlDataAdapter(c);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
        private void Customer_Load_2(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private int customerId;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                customerId = Convert.ToInt32(row.Cells["Customer_id"].Value);
                Customer_Name.Text = row.Cells["Name"].Value.ToString();
                Customer_Age.Text = row.Cells["Age"].Value.ToString();
                Customer_Email.Text = row.Cells["Email"].Value.ToString();
                Customer_Contact.Text = row.Cells["Contact"].Value.ToString();
            }
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            string Name = Customer_Name.Text;
            int Age = int.Parse(Customer_Age.Text);
            string Email = Customer_Email.Text;
            string Contact = Customer_Contact.Text;


            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand c = new SqlCommand("EXEC UpdateCustomer @CustomerID, @Name, @Age, @Email, @Contact", con))
                    {
                        c.Parameters.AddWithValue("@CustomerID", customerId); // Provide the Customer ID parameter
                        c.Parameters.AddWithValue("@Name", Name);
                        c.Parameters.AddWithValue("@Age", Age);
                        c.Parameters.AddWithValue("@Email", Email);
                        c.Parameters.AddWithValue("@Contact", Contact);

                        c.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            LoadCustomerData();
        }
        private void Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand c = new SqlCommand("EXEC DeleteCustomer @CustomerID", con))
                    {
                        c.Parameters.AddWithValue("@CustomerID", customerId);

                        c.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted" + customerId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            LoadCustomerData();
        }

       
    }
}
