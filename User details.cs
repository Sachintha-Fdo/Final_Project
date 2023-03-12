
//using MySql.Data.MySqlClient;
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
    public partial class User_details : Form
    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        public User_details()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            con.Open();

            //MySqlCommand cmdToCheckDuplicate = new MySqlCommand("SELECT * FROM user1 WHERE Username = '" + textBox2 + "'", con);
            MySqlCommand cmd1 = new MySqlCommand("SELECT EmployeeID, Name FROM user1", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("Please Check the fields and fill all the fields.");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Passwords do not match.");
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username is already existed!");
            }

            else
            {
                try
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO user1 VALUES (@EmployeeID,@Name,@Username,@Password)", con);
                    
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", textBox5.Text);
                    // cmd.Parameters.AddWithValue("@ConfirmPassword", textBox4.Text);
                    MessageBox.Show("Successfully Added");
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                /* Mask the password
                string maskedPassword = new string('*', con.ConnectionString.Split(';')[3].Split('=')[1].Length);

                Console.WriteLine($"Connecting to database with the following connection string: {con.Replace(con.textBox3.Text, maskedPassword)}");*/
                con.Close();
            }
                

        
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT EmployeeID, Name FROM user1", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("Please Check the fields and fill all the fields.");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Passwords do not match.");
           /*else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username is already existed!");
            }*/

            else
            {
                try
                {


                    MySqlCommand cmd = new MySqlCommand("UPDATE user1 SET Name = @Name, Username = @Username, Password = @Password, EmployeeID = @EmployeeID WHERE Name = @Name || EmployeeID = @EmployeeID", con);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Username", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", textBox5.Text);
                    //cmd.Parameters.AddWithValue("@ConfirmPassword", textBox4.Text);
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Successfully Updated" + ex);
                }

                con.Close();

            }
            }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM user1 WHERE name = @name", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            con.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
}
