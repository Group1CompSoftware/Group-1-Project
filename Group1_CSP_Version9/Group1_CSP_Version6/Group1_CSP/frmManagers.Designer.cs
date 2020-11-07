namespace Group1_CSP
{
    partial class frmManagers
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
            this.dgvManagersView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagersView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManagersView
            // 
            this.dgvManagersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagersView.Location = new System.Drawing.Point(13, 13);
            this.dgvManagersView.Name = "dgvManagersView";
            this.dgvManagersView.Size = new System.Drawing.Size(353, 223);
            this.dgvManagersView.TabIndex = 0;
            // 
            // frmManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvManagersView);
            this.Name = "frmManagers";
            this.Text = "Managers Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagers_FormClosing);
            this.Load += new System.EventHandler(this.frmManagers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManagersView;
    }
}