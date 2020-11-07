namespace Group1_CSP
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbCustomer = new System.Windows.Forms.RadioButton();
            this.gbxUserType = new System.Windows.Forms.GroupBox();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            this.rdbEmployee = new System.Windows.Forms.RadioButton();
            this.dgvLoginHolder = new System.Windows.Forms.DataGridView();
            this.gbxUserType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(134, 13);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(240, 31);
            this.tbxUsername.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(134, 47);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(240, 31);
            this.tbxPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(178, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbCustomer
            // 
            this.rdbCustomer.AutoSize = true;
            this.rdbCustomer.Location = new System.Drawing.Point(6, 14);
            this.rdbCustomer.Name = "rdbCustomer";
            this.rdbCustomer.Size = new System.Drawing.Size(69, 17);
            this.rdbCustomer.TabIndex = 6;
            this.rdbCustomer.TabStop = true;
            this.rdbCustomer.Text = "Customer";
            this.rdbCustomer.UseVisualStyleBackColor = true;
            // 
            // gbxUserType
            // 
            this.gbxUserType.Controls.Add(this.rdbManager);
            this.gbxUserType.Controls.Add(this.rdbEmployee);
            this.gbxUserType.Controls.Add(this.rdbCustomer);
            this.gbxUserType.ForeColor = System.Drawing.Color.White;
            this.gbxUserType.Location = new System.Drawing.Point(381, 13);
            this.gbxUserType.Name = "gbxUserType";
            this.gbxUserType.Size = new System.Drawing.Size(104, 82);
            this.gbxUserType.TabIndex = 7;
            this.gbxUserType.TabStop = false;
            this.gbxUserType.Text = "Select user type:";
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.Location = new System.Drawing.Point(6, 56);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(67, 17);
            this.rdbManager.TabIndex = 8;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Manager";
            this.rdbManager.UseVisualStyleBackColor = true;
            // 
            // rdbEmployee
            // 
            this.rdbEmployee.AutoSize = true;
            this.rdbEmployee.Location = new System.Drawing.Point(6, 35);
            this.rdbEmployee.Name = "rdbEmployee";
            this.rdbEmployee.Size = new System.Drawing.Size(71, 17);
            this.rdbEmployee.TabIndex = 7;
            this.rdbEmployee.TabStop = true;
            this.rdbEmployee.Text = "Employee";
            this.rdbEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvLoginHolder
            // 
            this.dgvLoginHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginHolder.Location = new System.Drawing.Point(475, 119);
            this.dgvLoginHolder.Name = "dgvLoginHolder";
            this.dgvLoginHolder.Size = new System.Drawing.Size(10, 10);
            this.dgvLoginHolder.TabIndex = 8;
            this.dgvLoginHolder.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(497, 141);
            this.Controls.Add(this.dgvLoginHolder);
            this.Controls.Add(this.gbxUserType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.gbxUserType.ResumeLayout(false);
            this.gbxUserType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbCustomer;
        private System.Windows.Forms.GroupBox gbxUserType;
        private System.Windows.Forms.RadioButton rdbManager;
        private System.Windows.Forms.RadioButton rdbEmployee;
        private System.Windows.Forms.DataGridView dgvLoginHolder;
    }
}