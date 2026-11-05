namespace ClothingStore
{
    partial class frmLogin
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // pnlTop
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(420, 10);
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            // lblBrand
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.AutoSize = false;
            this.lblBrand.Location = new System.Drawing.Point(0, 70);
            this.lblBrand.Text = "Urban Wear";
            this.lblBrand.Size = new System.Drawing.Size(420, 50);
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblSub
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = false;
            this.lblSub.Location = new System.Drawing.Point(0, 120);
            this.lblSub.Text = "Store manager";
            this.lblSub.Size = new System.Drawing.Size(420, 26);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(60, 185);
            this.lblUser.Text = "Username";
            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Location = new System.Drawing.Point(60, 210);
            this.txtUsername.Size = new System.Drawing.Size(300, 27);
            this.txtUsername.PlaceholderText = "admin";
            // lblPass
            this.lblPass.Name = "lblPass";
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(60, 255);
            this.lblPass.Text = "Password";
            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(60, 280);
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.PlaceholderText = "password";
            this.txtPassword.UseSystemPasswordChar = true;
            // chkRemember
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(60, 325);
            this.chkRemember.Text = "Remember me";
            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Location = new System.Drawing.Point(60, 370);
            this.btnLogin.Size = new System.Drawing.Size(300, 44);
            this.btnLogin.Text = "Login";
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.btnLogin);
            // frmLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Urban Wear";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnLogin;
    }
}