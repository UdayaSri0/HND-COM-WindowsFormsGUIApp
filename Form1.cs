using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGUIApp
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeLoadingScreen();
        }

        private void InitializeLoadingScreen()
        {
            // Set ProgressBar properties
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Initialize the Timer
            timer = new Timer
            {
                Interval = 50 // Update every 50 milliseconds
            };
            timer.Tick += Timer_Tick;

            // Start the Timer
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2; // Increment progress bar value
            }
            else
            {
                timer.Stop(); // Stop the timer once loading is complete

                // Open the frmLogin and close this form
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
