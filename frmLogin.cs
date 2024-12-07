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

namespace WindowsFormsGUIApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "SELECT Name, Email, EMPNumber, Role FROM Users WHERE Email = @Email AND Password = @Password";
                SqlParameter[] parameters = {
            new SqlParameter("@Email", email),
            new SqlParameter("@Password", password)
        };

                DataTable dataTable = DatabaseConnection.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow user = dataTable.Rows[0];
                    // Set session details
                    Session.LoggedInUserName = user["Name"].ToString();
                    Session.LoggedInUserEMPNumber = user["EMPNumber"].ToString();

                    // Navigate to the appropriate form
                    if (user["Role"].ToString() == "Admin")
                    {
                        frmAdmin adminForm = new frmAdmin();
                        adminForm.Show();
                    }
                    else if (user["Role"].ToString() == "User")
                    {
                        frmUser userForm = new frmUser();
                        userForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
