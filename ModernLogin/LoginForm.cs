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

namespace ModernLogin
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(Program.connString);
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

            conn.Open();

            int loginResult = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            if (loginResult == 1)
            {
                if (Application.OpenForms.OfType<RegisterUserForm>().Count() >=1)
                {
                    Application.OpenForms.OfType<RegisterUserForm>().First().BringToFront();
                }
                else
                {
                    RegisterUserForm af = new RegisterUserForm();
                    af.Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
