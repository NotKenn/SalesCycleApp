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
using System.Configuration;

namespace AkutansiSiklusPenjualan
{
    public partial class FormItem : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        string connectionString;
        SqlConnection connection;
        public FormItem()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AkutansiSiklusPenjualan.Properties.Settings.dbAkutansiConnectionString"].ConnectionString;
        }
        void loadItem()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Item", connection))
            {
                connection.Open();
                ds = new DataSet();
                da = new SqlDataAdapter(command);
                da.Fill(ds, "Item");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Item";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
            }
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            loadItem();
        }

        private void addBtnItem_Click(object sender, EventArgs e)
        {

            int Price = Convert.ToInt32(priceItem.Text);
            int Stock = Convert.ToInt32(stockItem.Text);
            if (itemId.Text.Trim() == "" || itemName.Text.Trim() == "" || warehouseName.Text.Trim() == "" || priceItem.Text.Trim() == "" || stockItem.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "INSERT into Item VALUES " +
                    "('" + itemId.Text + "','" + itemName.Text + "','" + warehouseName.Text + "','" + Price + "','" + Stock + "')", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully Inputted!");
                    loadItem();
                }
            }
        }

        private void editBtnItem_Click(object sender, EventArgs e)
        {
            int Price = Convert.ToInt32(priceItem.Text);
            int Stock = Convert.ToInt32(stockItem.Text);
            if (itemId.Text.Trim() == "" || itemName.Text.Trim() == "" || warehouseName.Text.Trim() == "" || priceItem.Text.Trim() == "" || stockItem.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "UPDATE Item SET Id = '" + itemId.Text + "', ItemName = '" + itemName.Text + "', Warehouse = '" + warehouseName.Text + "',Price = '" + Price + "', Stock = '" + Stock + "' WHERE Id = '"+ itemId.Text + "'", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully Updated!");
                    loadItem();
                }
            }

        }

        private void rmvBtnItem_Click(object sender, EventArgs e)
        {
            int Price = Convert.ToInt32(priceItem.Text);
            if (itemId.Text.Trim() == "" || itemName.Text.Trim() == "" || warehouseName.Text.Trim() == "" || priceItem.Text.Trim() == "" || stockItem.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "DELETE Item WHERE Id = '" + itemId.Text + "'", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully Removed!");
                    loadItem();
                }
            }

        }

        private void srchBtnItem_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Item where Id = '" + itemId.Text + "'", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                rd = command.ExecuteReader();
                if (rd.Read())
                {
                    itemId.Text = rd[0].ToString();
                    itemName.Text = rd[1].ToString();
                    warehouseName.Text = rd[2].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Data!");
                }

            }

        }
    }
}
