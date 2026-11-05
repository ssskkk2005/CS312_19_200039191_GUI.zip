namespace ClothingStore
{
    partial class frmMain
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSizesColors = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // pnlContent
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Location = new System.Drawing.Point(190, 0);
            this.pnlContent.Size = new System.Drawing.Size(910, 680);
            // pnlSidebar
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.pnlSidebar.Size = new System.Drawing.Size(190, 680);
            // lblBrand
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.AutoSize = false;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Text = "Urban Wear";
            this.lblBrand.Size = new System.Drawing.Size(190, 70);
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnDashboard
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Size = new System.Drawing.Size(190, 44);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // btnProducts
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Location = new System.Drawing.Point(0, 128);
            this.btnProducts.Size = new System.Drawing.Size(190, 44);
            this.btnProducts.Text = "Products";
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.UseVisualStyleBackColor = false;
            // btnSizesColors
            this.btnSizesColors.Name = "btnSizesColors";
            this.btnSizesColors.Location = new System.Drawing.Point(0, 176);
            this.btnSizesColors.Size = new System.Drawing.Size(190, 44);
            this.btnSizesColors.Text = "Sizes and colors";
            this.btnSizesColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizesColors.FlatAppearance.BorderSize = 0;
            this.btnSizesColors.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.btnSizesColors.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnSizesColors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSizesColors.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSizesColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSizesColors.UseVisualStyleBackColor = false;
            // btnInventory
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Location = new System.Drawing.Point(0, 224);
            this.btnInventory.Size = new System.Drawing.Size(190, 44);
            this.btnInventory.Text = "Inventory";
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.UseVisualStyleBackColor = false;
            // btnSales
            this.btnSales.Name = "btnSales";
            this.btnSales.Location = new System.Drawing.Point(0, 272);
            this.btnSales.Size = new System.Drawing.Size(190, 44);
            this.btnSales.Text = "Sales";
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.UseVisualStyleBackColor = false;
            // btnReports
            this.btnReports.Name = "btnReports";
            this.btnReports.Location = new System.Drawing.Point(0, 320);
            this.btnReports.Size = new System.Drawing.Size(190, 44);
            this.btnReports.Text = "Reports";
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.UseVisualStyleBackColor = false;
            // btnLogout
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnLogout.Location = new System.Drawing.Point(10, 620);
            this.btnLogout.Size = new System.Drawing.Size(170, 40);
            this.btnLogout.Text = "Log out";
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnSizesColors);
            this.pnlSidebar.Controls.Add(this.btnInventory);
            this.pnlSidebar.Controls.Add(this.btnSales);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Wear - Store manager";
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSizesColors;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
    }
}