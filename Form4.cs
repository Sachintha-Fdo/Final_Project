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
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM packagedb", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;




            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("Please Check the fields and fill all the fields.");
            /*else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Passwords do not match.");
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username is already existed!");
            }*/

            else
            {

                try
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO packagedb VALUES (@awb,@PackageType,@Qty,@PONo, @Sender, @SCompany, @CourierService, @DateTime, @ReceiverName, @Department, @gate)", con);

                    cmd.Parameters.AddWithValue("@awb", textBox1.Text);
                    cmd.Parameters.AddWithValue("@PackageType", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Qty", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PONo", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Sender", textBox5.Text);
                    cmd.Parameters.AddWithValue("@SCompany", textBox6.Text);
                    cmd.Parameters.AddWithValue("@CourierService", textBox7.Text);
                    cmd.Parameters.AddWithValue("@DateTime", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@ReceiverName", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Department", textBox9.Text);
                    cmd.Parameters.AddWithValue("@gate", comboBox1.Text);
                    // cmd.Parameters.AddWithValue("@ConfirmPassword", textBox4.Text);
                    MessageBox.Show("Successfully Added");
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                con.Close();
            }
        }

        private void receiverDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 rd = new Form6();
            rd.Show();
            this.Hide();
        }
    }
}
