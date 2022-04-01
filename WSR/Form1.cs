using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class Form1 : Form
    {
        public string constr = @"Data Source=MSI\EUGEN;Initial Catalog = wsr; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
            Time();
        }

        public void Time()
        {
            SqlConnection connection = new SqlConnection(this.constr);
            connection.Open();
            SqlDataAdapter adapterEamil = new SqlDataAdapter($"SELECT [User].Email FROM [User]", connection);
            DataSet dataset = new DataSet();

            adapterEamil.Fill(dataset);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
