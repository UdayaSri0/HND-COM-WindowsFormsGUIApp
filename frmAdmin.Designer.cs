namespace WindowsFormsGUIApp
{
    partial class frmAdmin
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtContactNumber1 = new System.Windows.Forms.TextBox();
            this.lblContactNumber1 = new System.Windows.Forms.Label();
            this.txtContactNumber2 = new System.Windows.Forms.TextBox();
            this.lblContactNumber2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLoggedUserName = new System.Windows.Forms.Label();
            this.lblLoggedUserEMPNumber = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1287, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1207, 485);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(683, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 23);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1044, 373);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 40);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(323, 282);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 34);
            this.txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(323, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(469, 34);
            this.txtEmail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(323, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(469, 34);
            this.txtName.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(323, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 27);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // txtContactNumber1
            // 
            this.txtContactNumber1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber1.Location = new System.Drawing.Point(323, 379);
            this.txtContactNumber1.Name = "txtContactNumber1";
            this.txtContactNumber1.Size = new System.Drawing.Size(287, 34);
            this.txtContactNumber1.TabIndex = 19;
            // 
            // lblContactNumber1
            // 
            this.lblContactNumber1.AutoSize = true;
            this.lblContactNumber1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber1.Location = new System.Drawing.Point(323, 349);
            this.lblContactNumber1.Name = "lblContactNumber1";
            this.lblContactNumber1.Size = new System.Drawing.Size(288, 27);
            this.lblContactNumber1.TabIndex = 18;
            this.lblContactNumber1.Text = "Contact Number 1 Required";
            // 
            // txtContactNumber2
            // 
            this.txtContactNumber2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber2.Location = new System.Drawing.Point(683, 379);
            this.txtContactNumber2.Name = "txtContactNumber2";
            this.txtContactNumber2.Size = new System.Drawing.Size(287, 34);
            this.txtContactNumber2.TabIndex = 21;
            // 
            // lblContactNumber2
            // 
            this.lblContactNumber2.AutoSize = true;
            this.lblContactNumber2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber2.Location = new System.Drawing.Point(683, 349);
            this.lblContactNumber2.Name = "lblContactNumber2";
            this.lblContactNumber2.Size = new System.Drawing.Size(291, 27);
            this.lblContactNumber2.TabIndex = 20;
            this.lblContactNumber2.Text = "Contact Number 2 Optional ";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(688, 489);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(287, 34);
            this.txtAddress2.TabIndex = 25;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(688, 459);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(206, 27);
            this.lblAddress2.TabIndex = 24;
            this.lblAddress2.Text = "Address 2 Optional ";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(323, 489);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(287, 34);
            this.txtAddress1.TabIndex = 23;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(323, 459);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(203, 27);
            this.lblAddress1.TabIndex = 22;
            this.lblAddress1.Text = "Address 1 Required";
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbRole.Location = new System.Drawing.Point(1127, 97);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(138, 35);
            this.cmbRole.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(910, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Choose the Role";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1207, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1044, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1145, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLoggedUserName
            // 
            this.lblLoggedUserName.AutoSize = true;
            this.lblLoggedUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUserName.Location = new System.Drawing.Point(20, 14);
            this.lblLoggedUserName.Name = "lblLoggedUserName";
            this.lblLoggedUserName.Size = new System.Drawing.Size(0, 27);
            this.lblLoggedUserName.TabIndex = 31;
            // 
            // lblLoggedUserEMPNumber
            // 
            this.lblLoggedUserEMPNumber.AutoSize = true;
            this.lblLoggedUserEMPNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUserEMPNumber.Location = new System.Drawing.Point(20, 73);
            this.lblLoggedUserEMPNumber.Name = "lblLoggedUserEMPNumber";
            this.lblLoggedUserEMPNumber.Size = new System.Drawing.Size(0, 27);
            this.lblLoggedUserEMPNumber.TabIndex = 33;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 559);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1365, 252);
            this.dataGridView.TabIndex = 35;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(693, 39);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(105, 24);
            this.txtUserID.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(710, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "EMP Number";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(25, 118);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.Location = new System.Drawing.Point(895, 202);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(215, 34);
            this.txtSearchValue.TabIndex = 39;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1389, 823);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblLoggedUserEMPNumber);
            this.Controls.Add(this.lblLoggedUserName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtContactNumber2);
            this.Controls.Add(this.lblContactNumber2);
            this.Controls.Add(this.txtContactNumber1);
            this.Controls.Add(this.lblContactNumber1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtContactNumber1;
        private System.Windows.Forms.Label lblContactNumber1;
        private System.Windows.Forms.TextBox txtContactNumber2;
        private System.Windows.Forms.Label lblContactNumber2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLoggedUserName;
        private System.Windows.Forms.Label lblLoggedUserEMPNumber;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearchValue;
    }
}