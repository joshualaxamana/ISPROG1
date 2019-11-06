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

namespace ISPROGProject
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(Helper.GetCon());

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Login where [username] = '" + txtUsername.Text + "' and [password] = '" + txtPassword.Text + "'", con);
            SqlDataReader dataread;
            dataread = command.ExecuteReader();
            int count = 0;
            while (dataread.Read())
            {
                count += 1;
            }

            if (count == 1)
            {
                MessageBox.Show("You have successfully logged in!");
                this.Hide();
                ABOUT.Body form = new ABOUT.Body();
                form.Closed += (s, args) => this.Close();
                form.Show();

            }
            else
            {
                MessageBox.Show("Username or password incorrect");
            }

            con.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "") //makes sure first that user has input data on both username and pw
            {
                MessageBox.Show("Please input data on all fields");
            }
            else
            {
                // asks if you want to confirm the Sign Up information you provided
                DialogResult result = MessageBox.Show("Are you sure of the information you provided?", "Sign Up Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    con.Open(); //reads first if there is already an existing username of the one provided
                    SqlCommand command = new SqlCommand("SELECT * FROM Login where [username] = '" + txtUsername.Text + "'", con);
                    SqlDataReader dataread;
                    dataread = command.ExecuteReader();
                    int count = 0;
                    while (dataread.Read())
                    {
                        count += 1;
                    }

                    if (count == 1) //if it finds a match, message will show that the username provided has already been taken
                    {
                        con.Close();
                        MessageBox.Show("Sorry, that username has been taken, please enter another", "Error", MessageBoxButtons.OK);
                    }

                    else //if there is no existing record of the username to match, system writes a new record of the username and pw
                    {
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con;
                        cmd1.CommandText = "INSERT into Login VALUES (@username, @password)";

                        cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd1.Parameters.AddWithValue("@password", txtPassword.Text);

                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Login details have been successfully added to the database. Please Log-in.");
                    }

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

