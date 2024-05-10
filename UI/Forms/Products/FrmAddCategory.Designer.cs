namespace Toomeet_Pos.UI.Forms.Products
{
    partial class FrmAddCategory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCategoryDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCategoryName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 67);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.DefaultText = "";
            this.txtCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Location = new System.Drawing.Point(20, 34);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.PlaceholderText = "";
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(383, 26);
            this.txtCategoryName.TabIndex = 2;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCategoryDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 108);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDescription.DefaultText = "";
            this.txtCategoryDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryDescription.Location = new System.Drawing.Point(20, 34);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.PasswordChar = '\0';
            this.txtCategoryDescription.PlaceholderText = "";
            this.txtCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCategoryDescription.SelectedText = "";
            this.txtCategoryDescription.Size = new System.Drawing.Size(383, 70);
            this.txtCategoryDescription.TabIndex = 2;
            this.txtCategoryDescription.TextChanged += new System.EventHandler(this.txtCategoryDescription_TextChanged);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(253, 212);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 45);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // FrmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(445, 269);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmAddCategory";
            this.Text = "FrmAddCategory";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryDescription;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
    }
}