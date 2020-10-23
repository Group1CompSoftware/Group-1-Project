namespace Group1_CSP
{
    partial class frmEmployees
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.tbxItems = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvEmployeesView = new System.Windows.Forms.DataGridView();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(722, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(263, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // tbxName
            // 
            this.tbxName.Enabled = false;
            this.tbxName.Location = new System.Drawing.Point(507, 79);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(209, 20);
            this.tbxName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(503, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Customer Name: ";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.White;
            this.lblItems.Location = new System.Drawing.Point(503, 102);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(95, 20);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Item Name: ";
            // 
            // tbxItems
            // 
            this.tbxItems.Enabled = false;
            this.tbxItems.Location = new System.Drawing.Point(505, 125);
            this.tbxItems.Name = "tbxItems";
            this.tbxItems.Size = new System.Drawing.Size(209, 20);
            this.tbxItems.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(503, 194);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: ";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(507, 217);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(209, 20);
            this.tbxTotal.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(722, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(263, 24);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Selected Order";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(722, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(263, 24);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvEmployeesView
            // 
            this.dgvEmployeesView.AllowUserToAddRows = false;
            this.dgvEmployeesView.AllowUserToDeleteRows = false;
            this.dgvEmployeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesView.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeesView.Name = "dgvEmployeesView";
            this.dgvEmployeesView.ReadOnly = true;
            this.dgvEmployeesView.Size = new System.Drawing.Size(489, 225);
            this.dgvEmployeesView.TabIndex = 12;
            // 
            // lbxOrders
            // 
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.Location = new System.Drawing.Point(301, 284);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(482, 212);
            this.lbxOrders.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(722, 154);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(263, 24);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh Window";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(503, 148);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Enabled = false;
            this.tbxQuantity.Location = new System.Drawing.Point(507, 171);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(209, 20);
            this.tbxQuantity.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(503, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 20);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "Order ID";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(507, 35);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(209, 20);
            this.tbxId.TabIndex = 17;
            this.tbxId.TextChanged += new System.EventHandler(this.tbxId_TextChanged);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1002, 253);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvEmployeesView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.tbxItems);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbxOrders);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox tbxItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvEmployeesView;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbxId;
    }
}