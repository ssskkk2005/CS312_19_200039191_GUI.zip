namespace ClothingStore
{
    partial class ucReports
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
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChartHint = new System.Windows.Forms.Label();
            this.dgvReportCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Text = "Reports";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            // cmbReport
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReport.Location = new System.Drawing.Point(20, 60);
            this.cmbReport.Size = new System.Drawing.Size(200, 28);
            this.cmbReport.Items.AddRange(new object[] { "Sales report", "Inventory report", "Top products" });
            this.cmbReport.SelectedIndex = 0;
            // lblFrom
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(235, 64);
            this.lblFrom.Text = "From";
            // dtpFrom
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(280, 60);
            this.dtpFrom.Size = new System.Drawing.Size(130, 27);
            // lblTo
            this.lblTo.Name = "lblTo";
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(425, 64);
            this.lblTo.Text = "To";
            // dtpTo
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(452, 60);
            this.dtpTo.Size = new System.Drawing.Size(130, 27);
            // btnGenerate
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Location = new System.Drawing.Point(600, 58);
            this.btnGenerate.Size = new System.Drawing.Size(100, 31);
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            // btnExport
            this.btnExport.Name = "btnExport";
            this.btnExport.Location = new System.Drawing.Point(708, 58);
            this.btnExport.Size = new System.Drawing.Size(100, 31);
            this.btnExport.Text = "Export";
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            // pnlChart
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Location = new System.Drawing.Point(20, 105);
            this.pnlChart.Size = new System.Drawing.Size(880, 230);
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblChartHint
            this.lblChartHint.Name = "lblChartHint";
            this.lblChartHint.AutoSize = false;
            this.lblChartHint.Location = new System.Drawing.Point(1, 1);
            this.lblChartHint.Text = "Chart area (drag a Chart control here)";
            this.lblChartHint.Size = new System.Drawing.Size(876, 226);
            this.lblChartHint.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblChartHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // dgvReportCol0
            this.dgvReportCol0.HeaderText = "Date";
            this.dgvReportCol0.Name = "dgvReportCol0";
            // dgvReportCol1
            this.dgvReportCol1.HeaderText = "Orders";
            this.dgvReportCol1.Name = "dgvReportCol1";
            // dgvReportCol2
            this.dgvReportCol2.HeaderText = "Items sold";
            this.dgvReportCol2.Name = "dgvReportCol2";
            // dgvReportCol3
            this.dgvReportCol3.HeaderText = "Revenue";
            this.dgvReportCol3.Name = "dgvReportCol3";
            // dgvReport
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Location = new System.Drawing.Point(20, 350);
            this.dgvReport.Size = new System.Drawing.Size(880, 250);
            this.dgvReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.MultiSelect = false;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgvReportCol0, this.dgvReportCol1, this.dgvReportCol2, this.dgvReportCol3 });
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbReport);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlChart);
            this.pnlChart.Controls.Add(this.lblChartHint);
            this.Controls.Add(this.dgvReport);
            // ucReports
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(920, 650);
            this.Name = "ucReports";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChartHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportCol0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReportCol3;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}