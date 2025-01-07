namespace QLSV_App
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnBanner = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLogin.SuspendLayout();
            this.pnBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(119, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 38);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lblRole);
            this.pnLogin.Controls.Add(this.cboRole);
            this.pnLogin.Controls.Add(this.lblPassword);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.lblUserName);
            this.pnLogin.Controls.Add(this.txtUserName);
            this.pnLogin.Controls.Add(this.lblLogin);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLogin.Location = new System.Drawing.Point(0, 164);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(323, 318);
            this.pnLogin.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(54, 76);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Select Role",
            "Admin",
            "Manager"});
            this.cboRole.Location = new System.Drawing.Point(73, 95);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(192, 21);
            this.cboRole.TabIndex = 4;
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(54, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(73, 202);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(54, 131);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(73, 150);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(131, 17);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // pnBanner
            // 
            this.pnBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnBanner.Controls.Add(this.lblX);
            this.pnBanner.Controls.Add(this.label1);
            this.pnBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBanner.Location = new System.Drawing.Point(0, 0);
            this.pnBanner.Name = "pnBanner";
            this.pnBanner.Size = new System.Drawing.Size(323, 67);
            this.pnBanner.TabIndex = 0;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(299, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 20);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnBanner);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnBanner.ResumeLayout(false);
            this.pnBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel pnBanner;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
    }
}

