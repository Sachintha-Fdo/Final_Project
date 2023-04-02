using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Final_Project
{
    public partial class Form8 : Form
    {

        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
       
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
          
                con.Open();

                try
                {
                // MySqlCommand cmd = new MySqlCommand("SELECT Gp, PakageType, Qty, Sender, Dpt., Date, Courier,  VehicleNo, ReceivedBy, Receiver, Company,  Gate FROM Spackage", con);

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Spackage", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                

                    dataGridView1.AutoGenerateColumns = false;

                    /*DataGridViewTextBoxColumn awbCol = new DataGridViewTextBoxColumn();
                    awbCol.DataPropertyName = "awb";
                    awbCol.HeaderText = "AWB";
                    dataGridView1.Columns.Add(awbCol);

                    DataGridViewTextBoxColumn packageTypeCol = new DataGridViewTextBoxColumn();
                    packageTypeCol.DataPropertyName = "PackageType";
                    packageTypeCol.HeaderText = "Package Type";
                    dataGridView1.Columns.Add(packageTypeCol);*/

                    // Repeat the above two lines for each column in your table...



                    dataGridView1.Columns["Gp"].HeaderText = "Gate Pass No.";
                    dataGridView1.Columns["PakageType"].HeaderText = "Package Type";
                    dataGridView1.Columns["Qty"].HeaderText = "Quantity";
                    dataGridView1.Columns["Sender"].HeaderText = "Sender";
                    dataGridView1.Columns["Dpt."].HeaderText = "Department";
                    dataGridView1.Columns["Company"].HeaderText = "Sender Company";
                    

                    dataGridView1.Columns["VehicleNo"].HeaderText = "Vehicle No.";
                    dataGridView1.Columns["Courier"].HeaderText = "Courier Service";
                    dataGridView1.Columns["Date"].HeaderText = "Date";
                    dataGridView1.Columns["Receiver"].HeaderText = "Receiver's Name";
                    dataGridView1.Columns["ReceivedBy"].HeaderText = "Received By";
                    dataGridView1.Columns["Gate"].HeaderText = "Gate";



                    //DataTable dt = new DataTable();
                    /* dt.Columns.Add("AWB/Invoice/GP No.", typeof(int));
                     dt.Columns.Add("Package Type", typeof(string));
                     dt.Columns.Add("Qty", typeof (int));
                     dt.Columns.Add("Sender's Name", typeof(string));
                     dt.Columns.Add("Company", typeof(string));
                     dt.Columns.Add("Department", typeof(string));
                     dt.Columns.Add("Department", typeof(string));*/

                    // dataGridView1.DataSource = dt;

                    /* dataGridView1.Columns["AWB/Invoice/GP No."].DataPropertyName = "AWB/Invoice/GP No.";
                     dataGridView1.Columns["Package Type"].DataPropertyName = "Package Type";
                     dataGridView1.Columns["Qty"].DataPropertyName = "Qty";
                     dataGridView1.Columns["Sender's Name"].DataPropertyName = "Sender's Name";
                     dataGridView1.Columns["Company"].DataPropertyName = "Company";
                     dataGridView1.Columns["Department"].DataPropertyName = "Department";

                     dataGridView1.Columns["PO No."].DataPropertyName = "AWB/Invoice/GP No.";
                     dataGridView1.Columns["Courier Service"].DataPropertyName = "Package Type";
                     dataGridView1.Columns["Date & Time"].DataPropertyName = "Qty";
                     dataGridView1.Columns["Receiver's Name"].DataPropertyName = "Sender's Name";
                     dataGridView1.Columns["Gate"].DataPropertyName = "Company"; */

                    /*string query = "SELECT `awb`, `PackageType`, `Qty`, `Sender`, `SCompany`, `Department`, 'PONo', 'CourierService', 'DateTime', 'ReceiverName', 'gate' FROM packagedb";

                    dataGridView1.Columns["awb"].DataPropertyName = "AWB/Invoice/GP No.";
                    dataGridView1.Columns["Package Type"].DataPropertyName = "PackageType";
                    dataGridView1.Columns["Qty"].DataPropertyName = "Qty";
                    dataGridView1.Columns["Sender's Name"].DataPropertyName = "Sender";
                    dataGridView1.Columns["Company"].DataPropertyName = "SCompany";
                    dataGridView1.Columns["Department"].DataPropertyName = "Department";

                    dataGridView1.Columns["PO No."].DataPropertyName = "PONo";
                    dataGridView1.Columns["Courier Service"].DataPropertyName = "CourierService";
                    dataGridView1.Columns["Date & Time"].DataPropertyName = "DateTime";
                    dataGridView1.Columns["Receiver's Name"].DataPropertyName = "ReceiverName";
                    dataGridView1.Columns["Gate"].DataPropertyName = "gate";
                    */
                    cmd.ExecuteNonQuery();

                }


                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                con.Close();

        }

            private void Search_Click(object sender, EventArgs e)
            {

            }

            private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
            }

        private void Search_Click_1(object sender, EventArgs e)
        {
            con.Open();
            /* cmd.Parameters.AddWithValue("Name", textBoxValueToSearch.Text);
             cmd.Parameters.AddWithValue("Epf", textBoxValueToSearch.Text);

             string ValueToSearch = textBoxValueToSearch.Text.ToString();
             searchData(ValueToSearch);*/

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM receiver WHERE Gp = '" + textBox1.Text + "' || Sender = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
