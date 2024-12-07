using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUIApp
{
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
            lblLoggedUserName.Text = Session.LoggedInUserName;
            lblLoggedUserEMPNumber.Text = Session.LoggedInUserEMPNumber;
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

        private void btnAdminPage_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.Show();
            this.Close();
        }


        private void CleanupResources()
        {
            try
            {
                // Close all active database connections
                DatabaseConnection.CloseAllConnections();

                // Delete temporary files safely
                string tempPath = System.IO.Path.GetTempPath();
                var tempFiles = System.IO.Directory.GetFiles(tempPath, "*.tmp");

                foreach (var file in tempFiles)
                {
                    try
                    {
                        // Check if the file is locked
                        using (var stream = new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite))
                        {
                            // File is not in use, delete it
                            stream.Close();
                            System.IO.File.Delete(file);
                        }
                    }
                    catch (System.IO.IOException)
                    {
                        // File is in use, skip it
                        continue;
                    }
                }

                // Other cleanup tasks (if any)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during cleanup: {ex.Message}", "Cleanup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                // Show a confirmation dialog
                var result = MessageBox.Show(
                    "Are you sure you want to exit the application?",
                    "Exit Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Exit the application if the user confirms
                if (result == DialogResult.Yes)
                {
                    // Perform cleanup tasks (if any)
                    CleanupResources();

                    // Exit the application
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors during exit
                MessageBox.Show($"An error occurred while exiting the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
