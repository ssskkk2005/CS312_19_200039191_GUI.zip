namespace ClothingStore
{
    partial class ucInventory
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
            this.txtInvSearch = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvInventoryCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventoryCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventoryCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventoryCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventoryCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Text = "Inventory management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // txtInvSearch
            this.txtInvSearch.Name = "txtInvSearch";
            this.txtInvSearch.Location = new System.Drawing.Point(20, 60);
            this.txtInvSearch.Size = new System.Drawing.Size(300, 27);
            this.txtInvSearch.PlaceholderText = "Search item";
            // cmbSize
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Location = new System.Drawing.Point(330, 60);
            this.cmbSize.Size = new System.Drawing.Size(120, 28);
            this.cmbSize.Items.AddRange(new object[] { "All sizes", "S", "M", "L", "XL" });
            this.cmbSize.SelectedIndex = 0;
            // cmbColor
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Location = new System.Drawing.Point(460, 60);
            this.cmbColor.Size = new System.Drawing.Size(140, 28);
            this.cmbColor.Items.AddRange(new object[] { "All colors", "Black", "White", "Blue", "Red" });
            this.cmbColor.SelectedIndex = 0;
            // btnFilter
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Location = new System.Drawing.Point(610, 58);
            this.btnFilter.Size = new System.Drawing.Size(90, 31);
            this.btnFilter.Text = "Filter";
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            // dgvInventoryCol0
            this.dgvInventoryCol0.HeaderText = "Product";
            this.dgvInventoryCol0.Name = "dgvInventoryCol0";
            // dgvInventoryCol1
            this.dgvInventoryCol1.HeaderText = "Size";
            this.dgvInventoryCol1.Name = "dgvInventoryCol1";
            // dgvInventoryCol2
            this.dgvInventoryCol2.HeaderText = "Color";
            this.dgvInventoryCol2.Name = "dgvInventoryCol2";
            // dgvInventoryCol3
            this.dgvInventoryCol3.HeaderText = "Quantity";
            this.dgvInventoryCol3.Name = "dgvInventoryCol3";
            // dgvInventoryCol4
            this.dgvInventoryCol4.HeaderText = "Status";
            this.dgvInventoryCol4.Name = "dgvInventoryCol4";
            // dgvInventory
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Location = new System.Drawing.Point(20, 105);
            this.dgvInventory.Size = new System.Drawing.Size(620, 500);
            this.dgvInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvInventoryCol0, this.dgvInventoryCol1, this.dgvInventoryCol2, this.dgvInventoryCol3, this.dgvInventoryCol4 });
            // grpStock
            this.grpStock.Name = "grpStock";
            this.grpStock.Location = new System.Drawing.Point(660, 100);
            this.grpStock.Size = new System.Drawing.Size(240, 270);
            this.grpStock.Text = "Adjust stock";
            this.grpStock.TabStop = false;
            this.grpStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // lblSelected
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(15, 30);
            this.lblSelected.Text = "Selected item";
            // txtItem
            this.txtItem.Name = "txtItem";
            this.txtItem.Location = new System.Drawing.Point(15, 52);
            this.txtItem.Size = new System.Drawing.Size(210, 27);
            this.txtItem.ReadOnly = true;
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            // lblQty
            this.lblQty.Name = "lblQty";
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(15, 92);
            this.lblQty.Text = "Quantity";
            // numQty
            this.numQty.Name = "numQty";
            this.numQty.Location = new System.Drawing.Point(15, 114);
            this.numQty.Size = new System.Drawing.Size(210, 27);
            this.numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numQty.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // btnAddStock
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Location = new System.Drawing.Point(15, 165);
            this.btnAddStock.Size = new System.Drawing.Size(210, 38);
            this.btnAddStock.Text = "Add stock";
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            // btnRemoveStock
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Location = new System.Drawing.Point(15, 212);
            this.btnRemoveStock.Size = new System.Drawing.Size(210, 38);
            this.btnRemoveStock.Text = "Remove stock";
            this.btnRemoveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.BackColor = System.Drawing.Color.White;
            this.btnRemoveStock.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnRemoveStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInvSearch);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.grpStock);
            this.grpStock.Controls.Add(this.lblSelected);
            this.grpStock.Controls.Add(this.txtItem);
            this.grpStock.Controls.Add(this.lblQty);
            this.grpStock.Controls.Add(this.numQty);
            this.grpStock.Controls.Add(this.btnAddStock);
            this.grpStock.Controls.Add(this.btnRemoveStock);
            // ucInventory
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(920, 650);
            this.Name = "ucInventory";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInvSearch;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryCol0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventoryCol4;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnRemoveStock;
    }
}