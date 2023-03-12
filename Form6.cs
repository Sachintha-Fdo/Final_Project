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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class Form6 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();  
        DataTable dt = new DataTable(); 
        public Form6()
        {
            InitializeComponent();

           /* con.Open();

            

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM receiver", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();*/
        }


        public void searchData(string ValueToSearch)
        {
            string query = "SELECT * FROM receiver WHERE CONCAT( 'Name','Epf','Department','Email','Designation','Contact') like '%" +ValueToSearch+ "%'";
            //string query = "SELECT * FROM receiver WHERE Name = @Name || Epf = @Epf || Department = @Department || Email = @Email || Designation = @Designation || contact = @Contact like '%" + ValueToSearch + "%'";
            cmd = new MySqlCommand(query,con);
            da = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();


            if (textBox1 == null || textBox2 == null || textBox3 == null || textBox4 == null || textBox5 == null || textBox6 == null)
            MessageBox.Show("Please Fill all the Fields");


            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO receiver VALUES (@Name,@Epf,@Department,@Email,@Designation,@Contact)", con);

                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Department", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Designation", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Epf", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Contact", textBox4.Text);
                    
                    // cmd.Parameters.AddWithValue("@ConfirmPassword", textBox4.Text);
                    MessageBox.Show("Successfully Added");
                    cmd.ExecuteNonQuery();


                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM receiver", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE receiver SET Name = @Name, Epf = @Epf, Department = @Department, Email = @Email, Designation = @Designation, Contact = @Contact WHERE Name = @Name || Epf = @Epf", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Department", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@Designation", textBox5.Text);
            cmd.Parameters.AddWithValue("@Epf", textBox6.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox4.Text);



            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM receiver", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM receiver WHERE Name = @Name || Epf = @Epf", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Epf", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");


            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM receiver", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            /* cmd.Parameters.AddWithValue("Name", textBoxValueToSearch.Text);
             cmd.Parameters.AddWithValue("Epf", textBoxValueToSearch.Text);

             string ValueToSearch = textBoxValueToSearch.Text.ToString();
             searchData(ValueToSearch);*/

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM receiver WHERE Name = '" + textBoxValueToSearch.Text +"' || Epf = '" + textBoxValueToSearch.Text + "'";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
