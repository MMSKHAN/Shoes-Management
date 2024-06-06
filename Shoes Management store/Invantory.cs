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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Shoes_Management_store
{
    public partial class Invantory : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True");

        public Invantory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string Brand = Brand_Name.Text;
            int Size = int.Parse(Shoes_Size.Text);
            string Colors = Col.Text;
            int Quant = int.Parse(Quantity.Text);
            int Pric = int.Parse(Price.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EXEC InsertShoe @Brand, @Size, @Color, @Quantity, @Price", connection))
                    {
                        command.Parameters.AddWithValue("@Brand", Brand);
                        command.Parameters.AddWithValue("@Size", Size);
                        command.Parameters.AddWithValue("@Color", Colors);
                        command.Parameters.AddWithValue("@Quantity", Quant);
                        command.Parameters.AddWithValue("@Price", Pric);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully inserted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

           LoadShoesData();
        }
        private void LoadShoesData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand c = new SqlCommand("GetAllShoes", con))
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

        private int shoeId;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                shoeId = Convert.ToInt32(row.Cells["Shoes_Id"].Value);
                Brand_Name.Text = row.Cells["Brand"].Value.ToString();
                Shoes_Size.Text = row.Cells["Size"].Value.ToString();
                Col.Text = row.Cells["Color"].Value.ToString();
                Quantity.Text = row.Cells["Quantity"].Value.ToString();
                Price.Text = row.Cells["Price"].Value.ToString();

            }
        }

        private void Invantory_Load(object sender, EventArgs e)
        {
            LoadShoesData();
        }
        private void Update_Click_1(object sender, EventArgs e)
        {
            string Brand = Brand_Name.Text;
            int Size = int.Parse(Shoes_Size.Text);
            string Colors = Col.Text;
            int Quant = int.Parse(Quantity.Text);
            int Pric = int.Parse(Price.Text);
            int ShoeID = shoeId; // Retrieve the shoe ID from the selected row

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand("EXEC UpdateShoe @ShoeID, @Brand, @Size, @Color, @Quantity, @Price", con))
                    {
                        command.Parameters.AddWithValue("@ShoeID", ShoeID); // Add the ShoeID parameter
                        command.Parameters.AddWithValue("@Brand", Brand);
                        command.Parameters.AddWithValue("@Size", Size);
                        command.Parameters.AddWithValue("@Color", Colors);
                        command.Parameters.AddWithValue("@Quantity", Quant);
                        command.Parameters.AddWithValue("@Price", Pric);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            LoadShoesData();
        }
        private void Delete_Click_1(object sender, EventArgs e)
        {
            int ShoeID = shoeId;
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-IUVM8D3\\SQLEXPRESS;Initial Catalog=Shoes_Management_Store;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand c = new SqlCommand("EXEC DeleteShoe @Shoes_Id", con))
                    {
                        c.Parameters.AddWithValue("@Shoes_Id", ShoeID);

                        c.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted" + ShoeID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            LoadShoesData();
        }

       
    }
}
