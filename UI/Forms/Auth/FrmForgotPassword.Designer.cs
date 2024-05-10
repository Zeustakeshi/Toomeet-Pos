namespace Toomeet_Pos.UI.Forms
{
    partial class FrmForgotPasssword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPasssword));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbUsernameError = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.llbLogin = new System.Windows.Forms.LinkLabel();
            this.logo1 = new Toomeet_Pos.UI.UC.Logo();
            this.controlBoxGroup1 = new Toomeet_Pos.UI.UC.ControlBoxGroupMacOs();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 100;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.controlBoxGroup1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel1.Size = new System.Drawing.Size(586, 42);
            this.guna2Panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quên mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel7.Controls.Add(this.lbUsernameError);
            this.guna2Panel7.Controls.Add(this.txtUsername);
            this.guna2Panel7.Controls.Add(this.label1);
            this.guna2Panel7.Location = new System.Drawing.Point(12, 204);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(562, 100);
            this.guna2Panel7.TabIndex = 19;
            // 
            // lbUsernameError
            // 
            this.lbUsernameError.AutoSize = true;
            this.lbUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.lbUsernameError.Location = new System.Drawing.Point(27, 79);
            this.lbUsernameError.Name = "lbUsernameError";
            this.lbUsernameError.Size = new System.Drawing.Size(121, 16);
            this.lbUsernameError.TabIndex = 2;
            this.lbUsernameError.Text = "Email không hợp lệ";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(21, 35);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtUsername.PlaceholderText = "Email hoặc số điện thoại";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(526, 40);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(12, 353);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(562, 52);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Lấy lại mật khẩu";
            // 
            // llbLogin
            // 
            this.llbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbLogin.AutoSize = true;
            this.llbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.llbLogin.Location = new System.Drawing.Point(480, 316);
            this.llbLogin.Name = "llbLogin";
            this.llbLogin.Size = new System.Drawing.Size(79, 18);
            this.llbLogin.TabIndex = 21;
            this.llbLogin.TabStop = true;
            this.llbLogin.Text = "Đăng nhập";
            this.llbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogin_LinkClicked);
            // 
            // logo1
            // 
            this.logo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo1.AutoSize = true;
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.logo1.Location = new System.Drawing.Point(156, 62);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(256, 61);
            this.logo1.TabIndex = 18;
            // 
            // controlBoxGroup1
            // 
            this.controlBoxGroup1.Location = new System.Drawing.Point(12, 13);
            this.controlBoxGroup1.Name = "controlBoxGroup1";
            this.controlBoxGroup1.Size = new System.Drawing.Size(60, 19);
            this.controlBoxGroup1.TabIndex = 2;
            // 
            // FrmForgotPasssword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 440);
            this.Controls.Add(this.llbLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmForgotPasssword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTemplate";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private UC.Logo logo1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label lbUsernameError;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.LinkLabel llbLogin;
        private UC.ControlBoxGroupMacOs controlBoxGroup1;
    }
}