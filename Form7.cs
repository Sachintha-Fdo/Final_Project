using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;


namespace Final_Project
{
    public partial class Form7 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("AWB/Invoice/GP No.", typeof(int));
            dt.Columns.Add("Package Type", typeof(string));
            dt.Columns.Add("Qty", typeof (int));
            dt.Columns.Add("Sender's Name", typeof(string));
            dt.Columns.Add("Department", typeof(string));


            dataGridView1.DataSource = dt;

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

       
    }
}
