using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AkutansiSiklusPenjualan
{
    public partial class FormSales : Form
    {

        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        string connectionString;
        SqlConnection connection;
        public FormSales()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AkutansiSiklusPenjualan.Properties.Settings.dbAkutansiConnectionString"].ConnectionString;
        }

        void loadData()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT Invoice_Id, Item_Id, Customer_Id, itemsBought, dateTime, Sales.Warehouse, (Item.Price * Sales.itemsBought) AS Cost FROM Sales, Item WHERE Id = Item_Id", connection))
            {
                connection.Open();
                ds = new DataSet();
                da = new SqlDataAdapter(command);
                da.Fill(ds, "Sales");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Sales";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
            }
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void addBtnSales_Click(object sender, EventArgs e)//add data to the table
        {
            if (invoiceIdSales.Text.Trim() == "" || custIdSales.Text.Trim() == "" || itemIdSales.Text.Trim() == "" || WarehouseSales.Text.Trim() == "" || quantitySales.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "INSERT into Sales VALUES " +
                    "('" + invoiceIdSales.Text + "','" + itemIdSales.Text + "','" + custIdSales.Text + "','" + quantitySales.Text + "','" + dateTimeSales.Value + "','" + WarehouseSales.Text + "')", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully inputted!");
                    loadData();
                }
            }
        }

        private void editBtnSales_Click(object sender, EventArgs e)
        {

            if (invoiceIdSales.Text.Trim() == "" || custIdSales.Text.Trim() == "" || itemIdSales.Text.Trim() == "" || WarehouseSales.Text.Trim() == "" || quantitySales.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "UPDATE Sales SET Invoice_Id = '" + invoiceIdSales.Text + "', Customer_Id = '" + custIdSales.Text + "',item_Id = '" + itemIdSales.Text + "',Warehouse = '" + WarehouseSales.Text + "',itemsBought = '" + quantitySales.Text + "',dateTime = '" + dateTimeSales.Value + "'", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully Updated!");
                    loadData();
                }
            }
        }

        private void rmvBtnSales_Click(object sender, EventArgs e)
        {

            if (invoiceIdSales.Text.Trim() == "" || custIdSales.Text.Trim() == "" || itemIdSales.Text.Trim() == "" || WarehouseSales.Text.Trim() == "" || quantitySales.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "DELETE Sales WHERE Invoice_Id = '" + invoiceIdSales.Text + "'", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully Removed!");
                    loadData();
                }
            }
        }

        private void srchBtnSales_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "SELECT * FROM Sales where Invoice_Id = '" + invoiceIdSales.Text + "'", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                rd = command.ExecuteReader();
                if (rd.Read())
                {
                    invoiceIdSales.Text = rd[1].ToString();
                    itemIdSales.Text = rd[2].ToString();
                    custIdSales.Text = rd[3].ToString();
                    WarehouseSales.Text = rd[6].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Data!");
                }
            }

        }
    }
}
