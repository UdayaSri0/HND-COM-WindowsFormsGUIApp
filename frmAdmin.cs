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
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsGUIApp
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            lblLoggedUserName.Text = Session.LoggedInUserName;
            lblLoggedUserEMPNumber.Text = Session.LoggedInUserEMPNumber;
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT UserID, Name, Email, EMPNumber, ContactNumber1, ContactNumber2, Address1, Address2, Role, CreatedBy, CreatedAt FROM Users";
                DataTable dataTable = DatabaseConnection.ExecuteQuery(query);
                dataGridView.DataSource = dataTable;

                // Optional customizations
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto-resize columns
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Users (Name, Email, Password, ContactNumber1, ContactNumber2, Address1, Address2, Role, CreatedBy) " +
                               "VALUES (@Name, @Email, @Password, @ContactNumber1, @ContactNumber2, @Address1, @Address2, @Role, @CreatedBy)";

                SqlParameter[] parameters = {
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@Email", txtEmail.Text),
                    new SqlParameter("@Password", txtPassword.Text),
                    new SqlParameter("@ContactNumber1", txtContactNumber1.Text),
                    new SqlParameter("@ContactNumber2", string.IsNullOrEmpty(txtContactNumber2.Text) ? (object)DBNull.Value : txtContactNumber2.Text),
                    new SqlParameter("@Address1", txtAddress1.Text),
                    new SqlParameter("@Address2", string.IsNullOrEmpty(txtAddress2.Text) ? (object)DBNull.Value : txtAddress2.Text),
                    new SqlParameter("@Role", cmbRole.SelectedItem.ToString()),
                    new SqlParameter("@CreatedBy", Session.LoggedInUserName) // Assuming you store the logged-in user
                };

                int rowsAffected = DatabaseConnection.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"{rowsAffected} user(s) added successfully.");
                LoadData(); // Refresh the grid
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting user: {ex.Message}");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password, ContactNumber1 = @ContactNumber1, " +
                               "ContactNumber2 = @ContactNumber2, Address1 = @Address1, Address2 = @Address2, Role = @Role WHERE UserID = @UserID";

                SqlParameter[] parameters = {
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@Email", txtEmail.Text),
                    new SqlParameter("@Password", txtPassword.Text),
                    new SqlParameter("@ContactNumber1", txtContactNumber1.Text),
                    new SqlParameter("@ContactNumber2", string.IsNullOrEmpty(txtContactNumber2.Text) ? (object)DBNull.Value : txtContactNumber2.Text),
                    new SqlParameter("@Address1", txtAddress1.Text),
                    new SqlParameter("@Address2", string.IsNullOrEmpty(txtAddress2.Text) ? (object)DBNull.Value : txtAddress2.Text),
                    new SqlParameter("@Role", cmbRole.SelectedItem.ToString()),
                    new SqlParameter("@UserID", int.Parse(txtUserID.Text)) // Assuming you have a hidden field or column to store UserID
                };

                int rowsAffected = DatabaseConnection.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"{rowsAffected} user(s) updated successfully.");
                LoadData(); // Refresh the grid
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                SqlParameter[] parameters = { new SqlParameter("@UserID", int.Parse(txtUserID.Text)) };

                int rowsAffected = DatabaseConnection.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"{rowsAffected} user(s) deleted successfully.");
                LoadData(); // Refresh the grid
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE Email = @Email";
                SqlParameter[] parameters = { new SqlParameter("@Email", txtEmail.Text) };

                DataTable dataTable = DatabaseConnection.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtName.Text = row["Name"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtPassword.Text = row["Password"].ToString();
                    txtContactNumber1.Text = row["ContactNumber1"].ToString();
                    txtContactNumber2.Text = row["ContactNumber2"].ToString();
                    txtAddress1.Text = row["Address1"].ToString();
                    txtAddress2.Text = row["Address2"].ToString();
                    cmbRole.SelectedItem = row["Role"].ToString();
                }
                else
                {
                    MessageBox.Show("No user found with the given email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for user: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtContactNumber1.Text = "";
            txtContactNumber2.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            cmbRole.SelectedIndex = -1;
        }

        // Exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicks on a valid row (not the header or an empty row)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Populate text boxes with values from the selected row
                txtUserID.Text = selectedRow.Cells["UserID"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPassword.Text = ""; // Avoid displaying the password for security
                txtContactNumber1.Text = selectedRow.Cells["ContactNumber1"].Value.ToString();
                txtContactNumber2.Text = selectedRow.Cells["ContactNumber2"].Value?.ToString() ?? ""; // Handle NULL values
                txtAddress1.Text = selectedRow.Cells["Address1"].Value.ToString();
                txtAddress2.Text = selectedRow.Cells["Address2"].Value?.ToString() ?? ""; // Handle NULL values
                cmbRole.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Redirect to the login form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                // Close the current admin form
                this.Close();
            }
        }
    }
}
