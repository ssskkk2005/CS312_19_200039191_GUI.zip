namespace ClothingStore
{
    partial class ucDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCardCaption1 = new System.Windows.Forms.Label();
            this.lblCardValue1 = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCardCaption2 = new System.Windows.Forms.Label();
            this.lblCardValue2 = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCardCaption3 = new System.Windows.Forms.Label();
            this.lblCardValue3 = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCardCaption4 = new System.Windows.Forms.Label();
            this.lblCardValue4 = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.dgvRecentCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecentCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecentCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecentCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.lblLow = new System.Windows.Forms.Label();
            this.dgvLowCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLowCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLow = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // pnlCard1
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Location = new System.Drawing.Point(20, 60);
            this.pnlCard1.Size = new System.Drawing.Size(210, 90);
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            // lblCardCaption1
            this.lblCardCaption1.Name = "lblCardCaption1";
            this.lblCardCaption1.AutoSize = true;
            this.lblCardCaption1.Location = new System.Drawing.Point(12, 12);
            this.lblCardCaption1.Text = "Today's sales";
            this.lblCardCaption1.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            // lblCardValue1
            this.lblCardValue1.Name = "lblCardValue1";
            this.lblCardValue1.AutoSize = true;
            this.lblCardValue1.Location = new System.Drawing.Point(12, 40);
            this.lblCardValue1.Text = "$1,240";
            this.lblCardValue1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardValue1.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // pnlCard2
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Location = new System.Drawing.Point(245, 60);
            this.pnlCard2.Size = new System.Drawing.Size(210, 90);
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            // lblCardCaption2
            this.lblCardCaption2.Name = "lblCardCaption2";
            this.lblCardCaption2.AutoSize = true;
            this.lblCardCaption2.Location = new System.Drawing.Point(12, 12);
            this.lblCardCaption2.Text = "Orders today";
            this.lblCardCaption2.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            // lblCardValue2
            this.lblCardValue2.Name = "lblCardValue2";
            this.lblCardValue2.AutoSize = true;
            this.lblCardValue2.Location = new System.Drawing.Point(12, 40);
            this.lblCardValue2.Text = "18";
            this.lblCardValue2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardValue2.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // pnlCard3
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Location = new System.Drawing.Point(470, 60);
            this.pnlCard3.Size = new System.Drawing.Size(210, 90);
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            // lblCardCaption3
            this.lblCardCaption3.Name = "lblCardCaption3";
            this.lblCardCaption3.AutoSize = true;
            this.lblCardCaption3.Location = new System.Drawing.Point(12, 12);
            this.lblCardCaption3.Text = "Products";
            this.lblCardCaption3.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            // lblCardValue3
            this.lblCardValue3.Name = "lblCardValue3";
            this.lblCardValue3.AutoSize = true;
            this.lblCardValue3.Location = new System.Drawing.Point(12, 40);
            this.lblCardValue3.Text = "342";
            this.lblCardValue3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardValue3.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // pnlCard4
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Location = new System.Drawing.Point(695, 60);
            this.pnlCard4.Size = new System.Drawing.Size(210, 90);
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            // lblCardCaption4
            this.lblCardCaption4.Name = "lblCardCaption4";
            this.lblCardCaption4.AutoSize = true;
            this.lblCardCaption4.Location = new System.Drawing.Point(12, 12);
            this.lblCardCaption4.Text = "Low stock items";
            this.lblCardCaption4.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            // lblCardValue4
            this.lblCardValue4.Name = "lblCardValue4";
            this.lblCardValue4.AutoSize = true;
            this.lblCardValue4.Location = new System.Drawing.Point(12, 40);
            this.lblCardValue4.Text = "7";
            this.lblCardValue4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardValue4.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // lblRecent
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.AutoSize = true;
            this.lblRecent.Location = new System.Drawing.Point(20, 172);
            this.lblRecent.Text = "Recent sales";
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // dgvRecentCol0
            this.dgvRecentCol0.HeaderText = "Order";
            this.dgvRecentCol0.Name = "dgvRecentCol0";
            // dgvRecentCol1
            this.dgvRecentCol1.HeaderText = "Customer";
            this.dgvRecentCol1.Name = "dgvRecentCol1";
            // dgvRecentCol2
            this.dgvRecentCol2.HeaderText = "Total";
            this.dgvRecentCol2.Name = "dgvRecentCol2";
            // dgvRecentCol3
            this.dgvRecentCol3.HeaderText = "Date";
            this.dgvRecentCol3.Name = "dgvRecentCol3";
            // dgvRecent
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.Location = new System.Drawing.Point(20, 202);
            this.dgvRecent.Size = new System.Drawing.Size(560, 400);
            this.dgvRecent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvRecentCol0, this.dgvRecentCol1, this.dgvRecentCol2, this.dgvRecentCol3 });
            // lblLow
            this.lblLow.Name = "lblLow";
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(600, 172);
            this.lblLow.Text = "Low stock";
            this.lblLow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // dgvLowCol0
            this.dgvLowCol0.HeaderText = "Item";
            this.dgvLowCol0.Name = "dgvLowCol0";
            // dgvLowCol1
            this.dgvLowCol1.HeaderText = "Qty";
            this.dgvLowCol1.Name = "dgvLowCol1";
            // dgvLow
            this.dgvLow.Name = "dgvLow";
            this.dgvLow.Location = new System.Drawing.Point(600, 202);
            this.dgvLow.Size = new System.Drawing.Size(300, 400);
            this.dgvLow.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvLow.AllowUserToAddRows = false;
            this.dgvLow.AllowUserToDeleteRows = false;
            this.dgvLow.ReadOnly = true;
            this.dgvLow.MultiSelect = false;
            this.dgvLow.RowHeadersVisible = false;
            this.dgvLow.BackgroundColor = System.Drawing.Color.White;
            this.dgvLow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvLowCol0, this.dgvLowCol1 });
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCard1);
            this.pnlCard1.Controls.Add(this.lblCardCaption1);
            this.pnlCard1.Controls.Add(this.lblCardValue1);
            this.Controls.Add(this.pnlCard2);
            this.pnlCard2.Controls.Add(this.lblCardCaption2);
            this.pnlCard2.Controls.Add(this.lblCardValue2);
            this.Controls.Add(this.pnlCard3);
            this.pnlCard3.Controls.Add(this.lblCardCaption3);
            this.pnlCard3.Controls.Add(this.lblCardValue3);
            this.Controls.Add(this.pnlCard4);
            this.pnlCard4.Controls.Add(this.lblCardCaption4);
            this.pnlCard4.Controls.Add(this.lblCardValue4);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.dgvRecent);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.dgvLow);
            // ucDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(920, 650);
            this.Name = "ucDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCardCaption1;
        private System.Windows.Forms.Label lblCardValue1;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCardCaption2;
        private System.Windows.Forms.Label lblCardValue2;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCardCaption3;
        private System.Windows.Forms.Label lblCardValue3;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCardCaption4;
        private System.Windows.Forms.Label lblCardValue4;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRecentCol0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRecentCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRecentCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRecentCol3;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLowCol0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLowCol1;
        private System.Windows.Forms.DataGridView dgvLow;
    }
}