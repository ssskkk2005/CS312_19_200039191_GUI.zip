namespace ClothingStore
{
    partial class ucProducts
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProductsCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Text = "Products management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // txtSearch
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Location = new System.Drawing.Point(20, 60);
            this.txtSearch.Size = new System.Drawing.Size(300, 27);
            this.txtSearch.PlaceholderText = "Search products";
            // cmbFilterCategory
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.Location = new System.Drawing.Point(330, 60);
            this.cmbFilterCategory.Size = new System.Drawing.Size(160, 28);
            this.cmbFilterCategory.Items.AddRange(new object[] { "All categories", "Men", "Women", "Kids", "Accessories" });
            this.cmbFilterCategory.SelectedIndex = 0;
            // btnSearch
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Location = new System.Drawing.Point(500, 58);
            this.btnSearch.Size = new System.Drawing.Size(90, 31);
            this.btnSearch.Text = "Search";
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            // dgvProductsCol0
            this.dgvProductsCol0.HeaderText = "ID";
            this.dgvProductsCol0.Name = "dgvProductsCol0";
            // dgvProductsCol1
            this.dgvProductsCol1.HeaderText = "Name";
            this.dgvProductsCol1.Name = "dgvProductsCol1";
            // dgvProductsCol2
            this.dgvProductsCol2.HeaderText = "Category";
            this.dgvProductsCol2.Name = "dgvProductsCol2";
            // dgvProductsCol3
            this.dgvProductsCol3.HeaderText = "Price";
            this.dgvProductsCol3.Name = "dgvProductsCol3";
            // dgvProducts
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Location = new System.Drawing.Point(20, 105);
            this.dgvProducts.Size = new System.Drawing.Size(560, 500);
            this.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvProductsCol0, this.dgvProductsCol1, this.dgvProductsCol2, this.dgvProductsCol3 });
            // grpDetails
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Location = new System.Drawing.Point(600, 100);
            this.grpDetails.Size = new System.Drawing.Size(300, 500);
            this.grpDetails.Text = "Product details";
            this.grpDetails.TabStop = false;
            this.grpDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // lblName
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Text = "Name";
            // txtName
            this.txtName.Name = "txtName";
            this.txtName.Location = new System.Drawing.Point(15, 52);
            this.txtName.Size = new System.Drawing.Size(270, 27);
            // lblCategory
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 90);
            this.lblCategory.Text = "Category";
            // cmbCategory
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(15, 112);
            this.cmbCategory.Size = new System.Drawing.Size(270, 28);
            this.cmbCategory.Items.AddRange(new object[] { "Men", "Women", "Kids", "Accessories" });
            this.cmbCategory.SelectedIndex = 0;
            // lblPrice
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 150);
            this.lblPrice.Text = "Price";
            // txtPrice
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Location = new System.Drawing.Point(15, 172);
            this.txtPrice.Size = new System.Drawing.Size(270, 27);
            // picProduct
            this.picProduct.Name = "picProduct";
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(15, 215);
            this.picProduct.Size = new System.Drawing.Size(270, 130);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.picProduct.TabStop = false;
            // btnChoosePicture
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Location = new System.Drawing.Point(15, 352);
            this.btnChoosePicture.Size = new System.Drawing.Size(270, 32);
            this.btnChoosePicture.Text = "Choose picture";
            this.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePicture.UseVisualStyleBackColor = false;
            this.btnChoosePicture.BackColor = System.Drawing.Color.White;
            this.btnChoosePicture.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnChoosePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            // btnAdd
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Location = new System.Drawing.Point(15, 405);
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            // btnUpdate
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Location = new System.Drawing.Point(107, 405);
            this.btnUpdate.Size = new System.Drawing.Size(85, 36);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            // btnDelete
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Location = new System.Drawing.Point(199, 405);
            this.btnDelete.Size = new System.Drawing.Size(85, 36);
            this.btnDelete.Text = "Delete";
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpDetails);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.cmbCategory);
            this.grpDetails.Controls.Add(this.lblPrice);
            this.grpDetails.Controls.Add(this.txtPrice);
            this.grpDetails.Controls.Add(this.picProduct);
            this.grpDetails.Controls.Add(this.btnChoosePicture);
            this.grpDetails.Controls.Add(this.btnAdd);
            this.grpDetails.Controls.Add(this.btnUpdate);
            this.grpDetails.Controls.Add(this.btnDelete);
            // ucProducts
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(920, 650);
            this.Name = "ucProducts";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsCol0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsCol3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}