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
    public partial class FormCustomer : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        string connectionString;
        SqlConnection connection;
        public FormCustomer()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AkutansiSiklusPenjualan.Properties.Settings.dbAkutansiConnectionString"].ConnectionString;
        }
        void loadCustomer()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection))
            {
                connection.Open();
                ds = new DataSet();
                da = new SqlDataAdapter(command);
                da.Fill(ds, "Customer");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Customer";
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Refresh();
            }
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }

        private void custAddBtn_Click(object sender, EventArgs e)
        {
            if (custId.Text.Trim() == "" || custName.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "INSERT into Customer VALUES " +
                    "('" + custId.Text + "','" + custName.Text + "')", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully inputted!");
                    loadCustomer();
                }
            }
        }

        private void custEditBtn_Click(object sender, EventArgs e)
        {
            if (custId.Text.Trim() == "" || custName.Text.Trim() == "")
            {
                MessageBox.Show("Fill empty spaces first!");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "UPDATE Customer SET CustomerId = '" + custId.Text + "',CustomerName = '" + custName.Text + "' WHERE CustomerId = '" + custId.Text + "'", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data succesfully Updated!");
                    loadCustomer();
                }
            }
        }

            private void custRmvBtn_Click(object sender, EventArgs e)
            {
                if (custId.Text.Trim() == "" || custName.Text.Trim() == "")
                {
                    MessageBox.Show("Fill empty spaces first!");
                }
                else
                {
                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(
                        "DELETE Customer WHERE CustomerId = '" +custId.Text + "'", connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data succesfully Removed!");
                        loadCustomer();
                    }
                }

            }

            private void custSrchBtn_Click(object sender, EventArgs e)
            {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "SELECT * FROM Customer where CustomerId = '" + custId.Text + "'", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                rd = command.ExecuteReader();
                if (rd.Read())
                {
                    custId.Text = rd[0].ToString();
                    custName.Text = rd[1].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Data!");
                }
            }
        }
        }
    
}
