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
    public partial class Sales : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True");

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Custom = Cus.Text;
            int sho = int.Parse(shoe.Text);
            string dat = date.Text;
            string quant = quantity.Text;

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand c = new SqlCommand("EXEC InsertSales  @CustomerID,  @ShoeID,   @SaleDate,  @Quantity", con))
                    {
                        c.Parameters.AddWithValue("@CustomerID", Custom);
                        c.Parameters.AddWithValue("@ShoeID", sho);
                        c.Parameters.AddWithValue("@SaleDate", dat);
                        c.Parameters.AddWithValue("@Quantity", quant);

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
                    using (SqlCommand c = new SqlCommand("ReadSales", con))
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

    }
}
