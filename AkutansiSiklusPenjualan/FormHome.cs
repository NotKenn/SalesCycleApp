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
    public partial class FormHome : Form
    {
        SqlConnection connection;
        string connectionString;
        public static FormHome home;
        MenuStrip menuStrip;
        FormSales frmSales;
        void frmSales_formClosed(object sender, FormClosedEventArgs e)
        {
            frmSales = null;
        }
        FormItem frmItem;
        void frmItem_formClosed(object sender, FormClosedEventArgs e)
        {
            frmItem = null;
        }
        FormCustomer frmCust;
        void frmCust_formClosed(object sender, FormClosedEventArgs e)
        {
            frmCust = null;
        }
        FormAboutUs frmAbtUs;
        void frmAbtUs_formClosed(object sender, FormClosedEventArgs e)
        {
            frmAbtUs = null;
        }
        FormHelp frmHelp;
        void frmHelp_formClosed(object sender, FormClosedEventArgs e)
        {
            frmHelp = null;
        }
        public FormHome()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["AkutansiSiklusPenjualan.Properties.Settings.dbAkutansiConnectionString"].ConnectionString;
            using (connection = new SqlConnection(connectionString))
                connection.Open();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            menuSales.Enabled = true;
            menuItem.Enabled = true;
            menuCustomer.Enabled = true;
            menuAboutUs.Enabled = true;
            menuHelp.Enabled = true;
            home = this;
        }

        private void menuSales_Click(object sender, EventArgs e)
        {
            if (frmSales == null)
            {
                frmSales = new FormSales();
                frmSales.FormClosed += new FormClosedEventHandler(frmSales_formClosed);
                frmSales.Enabled = true;
                frmSales.ShowDialog();
            }
            else
            {
                frmSales.Activate();
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (frmItem == null)
            {
                frmItem = new FormItem();
                frmItem.FormClosed += new FormClosedEventHandler(frmItem_formClosed);
                frmItem.ShowDialog();
            }
            else
            {
                frmItem.Activate();
            }
        }

        private void menuCustomer_Click(object sender, EventArgs e)
        {
            if (frmCust == null)
            {
                frmCust = new FormCustomer();
                frmCust.FormClosed += new FormClosedEventHandler(frmCust_formClosed);
                frmCust.ShowDialog();
            }
            else
            {
                frmCust.Activate();
            }
        }

        private void menuAboutUs_Click(object sender, EventArgs e)
        {
            if (frmAbtUs == null)
            {
                frmAbtUs = new FormAboutUs();
                frmAbtUs.FormClosed += new FormClosedEventHandler(frmAbtUs_formClosed);
                frmAbtUs.ShowDialog();
            }
            else
            {
                frmAbtUs.Activate();
            }
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            if (frmHelp == null)
            {
                frmHelp = new FormHelp();
                frmHelp.FormClosed += new FormClosedEventHandler(frmHelp_formClosed);
                frmHelp.ShowDialog();
            }
            else
            {
                frmHelp.Activate();
            }
        }
    }
}
