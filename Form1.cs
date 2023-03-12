using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;



namespace Final_Project
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "1234") {
                MessageBox.Show("Admin login is successful.");

                User_details ud = new User_details();
                ud.Show();
                this.Hide();
            }
            else {
                try
                {

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM user1 WHERE Username = @Username and Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Username", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfull");

                        HomePage hp = new HomePage();
                        hp.Show();
                        this.Hide();
                       

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }

            

        }
            
    }
}