﻿using System;
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
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNumber1.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress1.Text) ||
                    cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if validation fails
                }

                // Prepare the SQL INSERT query
                string query = "INSERT INTO Users (Name, Email, Password, ContactNumber1, ContactNumber2, Address1, Address2, Role, CreatedBy) " +
                               "VALUES (@Name, @Email, @Password, @ContactNumber1, @ContactNumber2, @Address1, @Address2, @Role, @CreatedBy)";

                // Create parameters for the query
                SqlParameter[] parameters = {
            new SqlParameter("@Name", txtName.Text.Trim()),
            new SqlParameter("@Email", txtEmail.Text.Trim()),
            new SqlParameter("@Password", txtPassword.Text.Trim()), // Store hashed password in real-world scenarios
            new SqlParameter("@ContactNumber1", txtContactNumber1.Text.Trim()),
            new SqlParameter("@ContactNumber2", string.IsNullOrWhiteSpace(txtContactNumber2.Text) ? (object)DBNull.Value : txtContactNumber2.Text.Trim()),
            new SqlParameter("@Address1", txtAddress1.Text.Trim()),
            new SqlParameter("@Address2", string.IsNullOrWhiteSpace(txtAddress2.Text) ? (object)DBNull.Value : txtAddress2.Text.Trim()),
            new SqlParameter("@Role", cmbRole.SelectedItem.ToString()),
            new SqlParameter("@CreatedBy", Session.LoggedInUserName) // Assuming Session class contains the logged-in user
        };

                // Execute the query
                int rowsAffected = DatabaseConnection.ExecuteNonQuery(query, parameters);

                // Provide feedback to the user
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the data grid and clear input fields
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("No user was added. Please try again.", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                // Check for unique constraint violation (e.g., Email or EMPNumber already exists)
                if (sqlEx.Number == 2627) // SQL Server error code for unique constraint violation
                {
                    MessageBox.Show("A user with the same email already exists. Please use a different email.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtContactNumber1.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress1.Text) ||
                    cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                // Prevent logged-in user from changing their own role
                if (txtUserID.Text == Session.LoggedInUserEMPNumber && cmbRole.SelectedItem.ToString() != Session.LoggedInUserRole)
                {
                    MessageBox.Show("You cannot change your own role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method
                }

                // SQL Query for updating user
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password, ContactNumber1 = @ContactNumber1, " +
                               "ContactNumber2 = @ContactNumber2, Address1 = @Address1, Address2 = @Address2, Role = @Role WHERE UserID = @UserID";

                // Parameters for the query
                SqlParameter[] parameters = {
                new SqlParameter("@Name", txtName.Text.Trim()),
                new SqlParameter("@Email", txtEmail.Text.Trim()),
                new SqlParameter("@Password", txtPassword.Text.Trim()),
                new SqlParameter("@ContactNumber1", txtContactNumber1.Text.Trim()),
                new SqlParameter("@ContactNumber2", string.IsNullOrWhiteSpace(txtContactNumber2.Text) ? (object)DBNull.Value : txtContactNumber2.Text.Trim()),
                new SqlParameter("@Address1", txtAddress1.Text.Trim()),
                new SqlParameter("@Address2", string.IsNullOrWhiteSpace(txtAddress2.Text) ? (object)DBNull.Value : txtAddress2.Text.Trim()),
                new SqlParameter("@Role", cmbRole.SelectedItem.ToString()),
                new SqlParameter("@UserID", int.Parse(txtUserID.Text.Trim())) // Assuming UserID is stored as an integer
    };

                // Execute the query
                int rowsAffected = DatabaseConnection.ExecuteNonQuery(query, parameters);

                // Provide feedback to the user
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No user was updated. Please check the UserID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refresh the grid and clear the form
                LoadData();
                ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid UserID format. Please ensure UserID is a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the UserID or EMPNumber of the account to be deleted
                string selectedEMPNumber = txtUserID.Text.Trim(); // Or use EMPNumber if preferred

                // Check if the logged-in user is trying to delete their own account
                if (selectedEMPNumber == Session.LoggedInUserEMPNumber)
                {
                    MessageBox.Show("You cannot delete your own account while logged in.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method without performing t  he delete
                }

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this account?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // SQL query to delete the user
                    string query = "DELETE FROM Users WHERE EMPNumber = @EMPNumber";

                    // Parameterize the query to avoid SQL injection
                    SqlParameter[] parameters = {
                new SqlParameter("@EMPNumber", selectedEMPNumber)
            };

                    // Execute the query
                    int rowsAffected = DatabaseConnection.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView to reflect changes
                        LoadData();

                        // Clear input fields
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Account deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
