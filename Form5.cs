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

namespace Final_Project
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Spackage", con);
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

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Spackage VALUES (@GP,@PackageType,@Qty,@Sender, @Dpt., @Courier, @VehicleNo, @Date, @ReceivedBy, @Receiver, @Company, @Gate)", con);

                    cmd.Parameters.AddWithValue("@GP", textBox1.Text);
                    cmd.Parameters.AddWithValue("@PackageType", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Qty", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Sender", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Dpt.", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Courier", textBox7.Text);
                    cmd.Parameters.AddWithValue("@VehicleNo", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@ReceivedBy", textBox10.Text);
                    cmd.Parameters.AddWithValue("@Receiver", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Company", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Gate", comboBox1.Text);
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
            FormR rd = new FormR();
            rd.Show();
            this.Hide();
        }

        private void receivedPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
