namespace WindowsFormsGUIApp
{
    partial class frmAdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLoggedUserEMPNumber = new System.Windows.Forms.Label();
            this.lblLoggedUserName = new System.Windows.Forms.Label();
            this.btnAdminPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(586, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 43;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLoggedUserEMPNumber
            // 
            this.lblLoggedUserEMPNumber.AutoSize = true;
            this.lblLoggedUserEMPNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUserEMPNumber.Location = new System.Drawing.Point(21, 64);
            this.lblLoggedUserEMPNumber.Name = "lblLoggedUserEMPNumber";
            this.lblLoggedUserEMPNumber.Size = new System.Drawing.Size(0, 27);
            this.lblLoggedUserEMPNumber.TabIndex = 33;
            // 
            // lblLoggedUserName
            // 
            this.lblLoggedUserName.AutoSize = true;
            this.lblLoggedUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUserName.Location = new System.Drawing.Point(21, 20);
            this.lblLoggedUserName.Name = "lblLoggedUserName";
            this.lblLoggedUserName.Size = new System.Drawing.Size(0, 27);
            this.lblLoggedUserName.TabIndex = 39;
            // 
            // btnAdminPage
            // 
            this.btnAdminPage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPage.Location = new System.Drawing.Point(210, 134);
            this.btnAdminPage.Name = "btnAdminPage";
            this.btnAdminPage.Size = new System.Drawing.Size(153, 72);
            this.btnAdminPage.TabIndex = 44;
            this.btnAdminPage.Text = "User Manage";
            this.btnAdminPage.UseVisualStyleBackColor = true;
            this.btnAdminPage.Click += new System.EventHandler(this.btnAdminPage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(698, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 35);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdminPage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoggedUserEMPNumber);
            this.Controls.Add(this.lblLoggedUserName);
            this.Name = "frmAdminHome";
            this.Text = "frmAdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLoggedUserEMPNumber;
        private System.Windows.Forms.Label lblLoggedUserName;
        private System.Windows.Forms.Button btnAdminPage;
        private System.Windows.Forms.Button btnExit;
    }
}