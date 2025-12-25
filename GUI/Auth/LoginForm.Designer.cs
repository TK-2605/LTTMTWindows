namespace ShoppingSystem.GUI.Auth
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnCreateAccount = new ShoppingSystem.GUI.Auth.RoundedButton();
            this.btnLogin = new ShoppingSystem.GUI.Auth.RoundedButton();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.pnlPass = new ShoppingSystem.GUI.Auth.RoundedPanel();
            this.lblPassTag = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlEmail = new ShoppingSystem.GUI.Auth.RoundedPanel();
            this.lblEmailTag = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.pnlPass.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.lblExit);
            this.panelLeft.Controls.Add(this.lblFooter);
            this.panelLeft.Controls.Add(this.btnCreateAccount);
            this.panelLeft.Controls.Add(this.btnLogin);
            this.panelLeft.Controls.Add(this.lnkForgot);
            this.panelLeft.Controls.Add(this.chkRemember);
            this.panelLeft.Controls.Add(this.pnlPass);
            this.panelLeft.Controls.Add(this.pnlEmail);
            this.panelLeft.Controls.Add(this.lblSubtitle);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Controls.Add(this.lblLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 533);
            this.panelLeft.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExit.ForeColor = System.Drawing.Color.Gray;
            this.lblExit.Location = new System.Drawing.Point(11, 9);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 21);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(45, 450);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(294, 24);
            this.lblFooter.TabIndex = 9;
            this.lblFooter.Text = "By signing up you agree to our terms and that you have read our\r\ndata policy";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.White;
            this.btnCreateAccount.BackgroundColor = System.Drawing.Color.White;
            this.btnCreateAccount.BorderColor = System.Drawing.Color.Gray;
            this.btnCreateAccount.BorderRadius = 40;
            this.btnCreateAccount.BorderSize = 1;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateAccount.Location = new System.Drawing.Point(200, 360);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(140, 45);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(83)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(83)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(45, 360);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkForgot.LinkColor = System.Drawing.Color.Salmon;
            this.lnkForgot.Location = new System.Drawing.Point(250, 324);
            this.lnkForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(100, 15);
            this.lnkForgot.TabIndex = 6;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Forgot password?";
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRemember.ForeColor = System.Drawing.Color.Gray;
            this.chkRemember.Location = new System.Drawing.Point(45, 320);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(104, 19);
            this.chkRemember.TabIndex = 5;
            this.chkRemember.Text = "Remember me";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.BorderColor = System.Drawing.Color.LightGray;
            this.pnlPass.BorderRadius = 15;
            this.pnlPass.Controls.Add(this.lblPassTag);
            this.pnlPass.Controls.Add(this.txtPassword);
            this.pnlPass.Location = new System.Drawing.Point(45, 250);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlPass.Size = new System.Drawing.Size(300, 50);
            this.pnlPass.TabIndex = 4;
            // 
            // lblPassTag
            // 
            this.lblPassTag.AutoSize = true;
            this.lblPassTag.BackColor = System.Drawing.Color.White;
            this.lblPassTag.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPassTag.ForeColor = System.Drawing.Color.Gray;
            this.lblPassTag.Location = new System.Drawing.Point(3, 5);
            this.lblPassTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassTag.Name = "lblPassTag";
            this.lblPassTag.Size = new System.Drawing.Size(56, 13);
            this.lblPassTag.TabIndex = 1;
            this.lblPassTag.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(10, 22);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.BorderColor = System.Drawing.Color.LightGray;
            this.pnlEmail.BorderRadius = 15;
            this.pnlEmail.Controls.Add(this.lblEmailTag);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(45, 180);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlEmail.Size = new System.Drawing.Size(300, 50);
            this.pnlEmail.TabIndex = 3;
            // 
            // lblEmailTag
            // 
            this.lblEmailTag.AutoSize = true;
            this.lblEmailTag.BackColor = System.Drawing.Color.White;
            this.lblEmailTag.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEmailTag.ForeColor = System.Drawing.Color.Gray;
            this.lblEmailTag.Location = new System.Drawing.Point(3, 5);
            this.lblEmailTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailTag.Name = "lblEmailTag";
            this.lblEmailTag.Size = new System.Drawing.Size(78, 13);
            this.lblEmailTag.TabIndex = 1;
            this.lblEmailTag.Text = "Email Address";
            //
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(10, 22);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "tuhelrana@gmail.com";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(45, 145);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(193, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Please Log in to your account.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 100);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome Back!";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(99)))), ((int)(((byte)(83)))));
            this.lblLogo.Location = new System.Drawing.Point(97, 53);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(78, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "G-Mart";
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.pbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRight.Image = global::ShoppingSystem.Properties.Resources.ke_hang_cua_hang_tien_loi;
            this.pbRight.Location = new System.Drawing.Point(450, 0);
            this.pbRight.Margin = new System.Windows.Forms.Padding(2);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(417, 533);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 1;
            this.pbRight.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoppingSystem.Properties.Resources._1200x630wa;
            this.pictureBox1.Location = new System.Drawing.Point(25, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 533);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private RoundedPanel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private RoundedPanel pnlPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private RoundedButton btnLogin;
        private RoundedButton btnCreateAccount;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblEmailTag;
        private System.Windows.Forms.Label lblPassTag;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}