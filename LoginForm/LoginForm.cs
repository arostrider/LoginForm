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

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Login.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Users where Username ='" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                MainForm ss = new MainForm();
                ss.Show();
            }
            else
            {
                //MessageBox.Show("Incorrect username and password combination!", "Warning!", MessageBoxButtons.OK);
                txtUsername.Text = null;
                txtPassword.Text = null;
            }
        }
    }

}
