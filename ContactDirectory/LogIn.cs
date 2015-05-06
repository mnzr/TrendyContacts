using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactDirectory
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void logoBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trendy Contact Directory helps you save your contacts. (C) TrendBreaker LTD.");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data\ContactDB.mdf;Integrated Security=True");
            SqlDataAdapter sad = new SqlDataAdapter("Select Count(*) From Admins where Username='" + inputUsername.Text + "' and Password='" + inputPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                TrendyContactDirectory t = new TrendyContactDirectory();
                t.Show();
            } else {
                MessageBox.Show("Invalid username or password! Please try again!");
            };
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
