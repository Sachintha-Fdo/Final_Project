using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select Name from receiver", con);
            /*MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DataBind();*/
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Name"].ToString());
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
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
                    cmd.Parameters.AddWithValue("@ReceiverName", comboBox2.Text);
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

                MySqlCommand command = new MySqlCommand("SELECT Email FROM receiver WHERE Name=@ReceiverName", con);

                // Add a parameter for the receiver's name
                command.Parameters.AddWithValue("@ReceiverName", comboBox2.SelectedItem?.ToString()!);

                // Execute the SQL query using the ExecuteScalar method of the MySqlCommand object
                //string? receiverEmail = command.ExecuteScalar()?.ToString();

                string? receiverEmail = (string?)command.ExecuteScalar();

                // Close the MySqlCommand object
                command.Dispose();

                // Create a MailMessage object and set its properties
                if (receiverEmail != null)
                {

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("upltommy23@gmail.com");
                    message.To.Add(receiverEmail);

                    /* if (receiverEmail != null)
                    {
                        message.To.Add(receiverEmail);
                    }*/



                    message.Subject = "Auto-generated email";
                    message.Body = "This is an auto-generated email sent from ASP.NET C#. from SMTP01 owner of the server: sachinthaF";

                    // Create a SmtpClient object and set its properties
                    SmtpClient smtp = new SmtpClient("upltommy23@gmail.com");
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential("upltommy23@gmail.com", "ympcfhajtpjbrwzq");
                    smtp.EnableSsl = true;

                    try
                    {
                        // Send the email
                        smtp.Send(message);
                        Console.WriteLine("Email sent successfully.");
                    }
                    catch (SmtpException ex)
                    {
                        Console.WriteLine("SmtpException: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }


                    // Send the email
                    //smtp.Send(message);
                }

                // Close the SmtpClient object and dispose of the MailMessage object
                // smtp.Dispose();
                //message.Dispose();
                command.Dispose();

                // Close the MySQL connection
               

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

        }

        private void packageSentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 sd = new Form5();
            sd.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
    }
}
