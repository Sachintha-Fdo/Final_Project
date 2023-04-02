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
    public partial class HomePage : Form

    {
        MySqlConnection con = new MySqlConnection("Server=129.213.45.115;Database=PROJECT_DB;Uid=root;Pwd=sachintha@1998;");
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void receivedPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 pd = new Form4();
            pd.Show();
            this.Hide();

        }

        private void packageSentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ps = new Form5();
            ps.Show();
            this.Hide();
        }

        private void receiverDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormR rd = new FormR();
            rd.Show();
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

        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }
    }
}
