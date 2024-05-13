namespace Toomeet_Pos.UI.UC
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.mainTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new System.Windows.Forms.Label();
            this.guna2Panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.lbErrorMessage);
            this.guna2Panel7.Controls.Add(this.mainTextbox);
            this.guna2Panel7.Controls.Add(this.label);
            this.guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(322, 102);
            this.guna2Panel7.TabIndex = 14;
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.lbErrorMessage.Location = new System.Drawing.Point(27, 79);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(155, 16);
            this.lbErrorMessage.TabIndex = 2;
            this.lbErrorMessage.Text = "Trường này không hợp lệ";
            // 
            // mainTextbox
            // 
            this.mainTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextbox.BorderRadius = 10;
            this.mainTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainTextbox.DefaultText = "";
            this.mainTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mainTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mainTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mainTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mainTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mainTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainTextbox.ForeColor = System.Drawing.Color.Black;
            this.mainTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mainTextbox.Location = new System.Drawing.Point(21, 35);
            this.mainTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.PasswordChar = '\0';
            this.mainTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.mainTextbox.PlaceholderText = "Ví dụ: Nhân viên bán hàng";
            this.mainTextbox.SelectedText = "";
            this.mainTextbox.Size = new System.Drawing.Size(286, 40);
            this.mainTextbox.TabIndex = 1;
            this.mainTextbox.TextChanged += new System.EventHandler(this.mainTextbox_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(20, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Tên vai trò";
            // 
            // CustomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel7);
            this.Name = "CustomTextBox";
            this.Size = new System.Drawing.Size(322, 102);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label lbErrorMessage;
        private Guna.UI2.WinForms.Guna2TextBox mainTextbox;
        private System.Windows.Forms.Label label;
    }
}
