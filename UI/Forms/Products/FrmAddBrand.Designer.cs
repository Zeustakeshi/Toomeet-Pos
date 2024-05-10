namespace Toomeet_Pos.UI.Forms.Products
{
    partial class FrmAddBrand
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
            this.txtBrandDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBrandName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBrand = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBrandDescription
            // 
            this.txtBrandDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrandDescription.DefaultText = "";
            this.txtBrandDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrandDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrandDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBrandDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandDescription.Location = new System.Drawing.Point(20, 34);
            this.txtBrandDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandDescription.Multiline = true;
            this.txtBrandDescription.Name = "txtBrandDescription";
            this.txtBrandDescription.PasswordChar = '\0';
            this.txtBrandDescription.PlaceholderText = "";
            this.txtBrandDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBrandDescription.SelectedText = "";
            this.txtBrandDescription.Size = new System.Drawing.Size(383, 70);
            this.txtBrandDescription.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBrandName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 67);
            this.panel2.TabIndex = 10;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrandName.DefaultText = "";
            this.txtBrandName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrandName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrandName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBrandName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandName.Location = new System.Drawing.Point(20, 34);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.PasswordChar = '\0';
            this.txtBrandName.PlaceholderText = "";
            this.txtBrandName.SelectedText = "";
            this.txtBrandName.Size = new System.Drawing.Size(383, 26);
            this.txtBrandName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhãn hiệu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBrandDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 108);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mô tả";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.Location = new System.Drawing.Point(253, 221);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(180, 45);
            this.btnAddBrand.TabIndex = 12;
            this.btnAddBrand.Text = "Thêm";
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // FrmAddBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 281);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddBrand);
            this.Name = "FrmAddBrand";
            this.Text = "FrmAddBrand";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBrandDescription;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddBrand;
    }
}