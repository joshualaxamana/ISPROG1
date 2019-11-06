using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABOUT
{
    public partial class Body : Form
    {
        SqlConnection con = new SqlConnection(ISPROGProject.Helper.GetCon());

        public Body()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void sUSTAINABLEDEVELOPMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tabControl1.SelectTab(0);
            }
            else if (e.KeyCode == Keys.F2)
            {
                tabControl1.SelectTab(1);
            }
            else if (e.KeyCode == Keys.F3)
            {
                tabControl1.SelectTab(2);
            }
            else if (e.KeyCode == Keys.F4)
            {
                tabControl1.SelectTab(3);
            }
            else if (e.KeyCode == Keys.F5)
            {
                tabControl1.SelectTab(4);
            }
            else if (e.KeyCode == Keys.F6)
            {
                tabControl1.SelectTab(5);
            }
            else if (e.KeyCode == Keys.F7)
            {
                tabControl1.SelectTab(6);
            }

            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bankimoon/en");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/globalgoalsUN");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://plus.google.com/+unitednations/posts");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://united-nations.tumblr.com/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/GlobalGoalsUN");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/unitednations/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/unitednations");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flickr.com/photos/un_photo/");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your username?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Login SET username=@username where password=@password";

                cmd.Parameters.AddWithValue("@username", txtChangeUser.Text);
                cmd.Parameters.AddWithValue("@password", txtCurrentPw.Text);

                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("your username has successfully been changed");
            }
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your password?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Login SET password=@password where username=@username ";

                cmd.Parameters.AddWithValue("@password", txtChangePw.Text);
                cmd.Parameters.AddWithValue("@username", txtCurrentUser.Text);

                cmd.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("You have successfully changed your password");
            }
            
        }


        private void tabPage7_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tabControl1.SelectTab(0);
            }
            else if (e.KeyCode == Keys.F2)
            {
                tabControl1.SelectTab(1);
            }
            else if (e.KeyCode == Keys.F3)
            {
                tabControl1.SelectTab(2);
            }
            else if (e.KeyCode == Keys.F4)
            {
                tabControl1.SelectTab(3);
            }
            else if (e.KeyCode == Keys.F5)
            {
                tabControl1.SelectTab(4);
            }
            else if (e.KeyCode == Keys.F6)
            {
                tabControl1.SelectTab(5);
            }
            else if (e.KeyCode == Keys.F7)
            {
                tabControl1.SelectTab(6);
            }
        }
    }
}
