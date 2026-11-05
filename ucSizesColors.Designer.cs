namespace ClothingStore
{
    partial class ucSizesColors
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
            this.grpSizes = new System.Windows.Forms.GroupBox();
            this.lstSizes = new System.Windows.Forms.ListBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAddSize = new System.Windows.Forms.Button();
            this.btnDeleteSize = new System.Windows.Forms.Button();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Text = "Sizes and colors";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // grpSizes
            this.grpSizes.Name = "grpSizes";
            this.grpSizes.Location = new System.Drawing.Point(20, 60);
            this.grpSizes.Size = new System.Drawing.Size(430, 540);
            this.grpSizes.Text = "Sizes";
            this.grpSizes.TabStop = false;
            // lstSizes
            this.lstSizes.Name = "lstSizes";
            this.lstSizes.ItemHeight = 20;
            this.lstSizes.Location = new System.Drawing.Point(15, 30);
            this.lstSizes.Size = new System.Drawing.Size(400, 380);
            this.lstSizes.IntegralHeight = false;
            this.lstSizes.Items.AddRange(new object[] { "S", "M", "L", "XL", "XXL" });
            // txtSize
            this.txtSize.Name = "txtSize";
            this.txtSize.Location = new System.Drawing.Point(15, 428);
            this.txtSize.Size = new System.Drawing.Size(200, 27);
            this.txtSize.PlaceholderText = "New size";
            // btnAddSize
            this.btnAddSize.Name = "btnAddSize";
            this.btnAddSize.Location = new System.Drawing.Point(225, 425);
            this.btnAddSize.Size = new System.Drawing.Size(90, 33);
            this.btnAddSize.Text = "Add";
            this.btnAddSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSize.UseVisualStyleBackColor = false;
            this.btnAddSize.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAddSize.ForeColor = System.Drawing.Color.White;
            this.btnAddSize.FlatAppearance.BorderSize = 0;
            // btnDeleteSize
            this.btnDeleteSize.Name = "btnDeleteSize";
            this.btnDeleteSize.Location = new System.Drawing.Point(322, 425);
            this.btnDeleteSize.Size = new System.Drawing.Size(90, 33);
            this.btnDeleteSize.Text = "Delete";
            this.btnDeleteSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSize.UseVisualStyleBackColor = false;
            this.btnDeleteSize.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteSize.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSize.FlatAppearance.BorderSize = 0;
            // grpColors
            this.grpColors.Name = "grpColors";
            this.grpColors.Location = new System.Drawing.Point(470, 60);
            this.grpColors.Size = new System.Drawing.Size(430, 540);
            this.grpColors.Text = "Colors";
            this.grpColors.TabStop = false;
            // lstColors
            this.lstColors.Name = "lstColors";
            this.lstColors.ItemHeight = 20;
            this.lstColors.Location = new System.Drawing.Point(15, 30);
            this.lstColors.Size = new System.Drawing.Size(400, 330);
            this.lstColors.IntegralHeight = false;
            this.lstColors.Items.AddRange(new object[] { "Black", "White", "Blue", "Red", "Green" });
            // txtColor
            this.txtColor.Name = "txtColor";
            this.txtColor.Location = new System.Drawing.Point(15, 378);
            this.txtColor.Size = new System.Drawing.Size(200, 27);
            this.txtColor.PlaceholderText = "New color";
            // pnlColorPreview
            this.pnlColorPreview.Name = "pnlColorPreview";
            this.pnlColorPreview.Location = new System.Drawing.Point(225, 376);
            this.pnlColorPreview.Size = new System.Drawing.Size(34, 29);
            this.pnlColorPreview.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // btnPickColor
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Location = new System.Drawing.Point(268, 374);
            this.btnPickColor.Size = new System.Drawing.Size(147, 33);
            this.btnPickColor.Text = "Pick color";
            this.btnPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickColor.UseVisualStyleBackColor = false;
            this.btnPickColor.BackColor = System.Drawing.Color.White;
            this.btnPickColor.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnPickColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            // btnAddColor
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Location = new System.Drawing.Point(15, 425);
            this.btnAddColor.Size = new System.Drawing.Size(90, 33);
            this.btnAddColor.Text = "Add";
            this.btnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAddColor.ForeColor = System.Drawing.Color.White;
            this.btnAddColor.FlatAppearance.BorderSize = 0;
            // btnDeleteColor
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Location = new System.Drawing.Point(112, 425);
            this.btnDeleteColor.Size = new System.Drawing.Size(90, 33);
            this.btnDeleteColor.Text = "Delete";
            this.btnDeleteColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteColor.UseVisualStyleBackColor = false;
            this.btnDeleteColor.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteColor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteColor.FlatAppearance.BorderSize = 0;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpSizes);
            this.grpSizes.Controls.Add(this.lstSizes);
            this.grpSizes.Controls.Add(this.txtSize);
            this.grpSizes.Controls.Add(this.btnAddSize);
            this.grpSizes.Controls.Add(this.btnDeleteSize);
            this.Controls.Add(this.grpColors);
            this.grpColors.Controls.Add(this.lstColors);
            this.grpColors.Controls.Add(this.txtColor);
            this.grpColors.Controls.Add(this.pnlColorPreview);
            this.grpColors.Controls.Add(this.btnPickColor);
            this.grpColors.Controls.Add(this.btnAddColor);
            this.grpColors.Controls.Add(this.btnDeleteColor);
            // ucSizesColors
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(920, 650);
            this.Name = "ucSizesColors";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSizes;
        private System.Windows.Forms.ListBox lstSizes;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAddSize;
        private System.Windows.Forms.Button btnDeleteSize;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnDeleteColor;
    }
}