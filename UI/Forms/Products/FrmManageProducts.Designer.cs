namespace Toomeet_Pos.UI.Forms.Products
{
    partial class FrmManageProducts
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnViewProductCategories = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExportProductFile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUploadProductFile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnAddProduct);
            this.guna2Panel1.Controls.Add(this.btnViewProductCategories);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.btnExportProductFile);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btnUploadProductFile);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(1003, 57);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BorderRadius = 10;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::Toomeet_Pos.Properties.Resources.plus_ico;
            this.btnAddProduct.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAddProduct.Location = new System.Drawing.Point(806, 10);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(177, 37);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnViewProductCategories
            // 
            this.btnViewProductCategories.BorderRadius = 10;
            this.btnViewProductCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProductCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProductCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewProductCategories.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewProductCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewProductCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewProductCategories.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnViewProductCategories.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnViewProductCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewProductCategories.ForeColor = System.Drawing.Color.White;
            this.btnViewProductCategories.Location = new System.Drawing.Point(306, 10);
            this.btnViewProductCategories.Name = "btnViewProductCategories";
            this.btnViewProductCategories.Size = new System.Drawing.Size(171, 37);
            this.btnViewProductCategories.TabIndex = 24;
            this.btnViewProductCategories.Text = "Loại sản phẩm";
            this.btnViewProductCategories.Click += new System.EventHandler(this.btnViewProductCategories_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(296, 10);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.guna2Panel3.Size = new System.Drawing.Size(10, 37);
            this.guna2Panel3.TabIndex = 23;
            // 
            // btnExportProductFile
            // 
            this.btnExportProductFile.BorderRadius = 10;
            this.btnExportProductFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportProductFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportProductFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportProductFile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportProductFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportProductFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportProductFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnExportProductFile.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnExportProductFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportProductFile.ForeColor = System.Drawing.Color.White;
            this.btnExportProductFile.Image = global::Toomeet_Pos.Properties.Resources.download_icon4;
            this.btnExportProductFile.Location = new System.Drawing.Point(163, 10);
            this.btnExportProductFile.Name = "btnExportProductFile";
            this.btnExportProductFile.Size = new System.Drawing.Size(133, 37);
            this.btnExportProductFile.TabIndex = 22;
            this.btnExportProductFile.Text = "Xuất file";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(153, 10);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.guna2Panel2.Size = new System.Drawing.Size(10, 37);
            this.guna2Panel2.TabIndex = 21;
            // 
            // btnUploadProductFile
            // 
            this.btnUploadProductFile.BorderRadius = 10;
            this.btnUploadProductFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadProductFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadProductFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadProductFile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadProductFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadProductFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUploadProductFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnUploadProductFile.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnUploadProductFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadProductFile.ForeColor = System.Drawing.Color.White;
            this.btnUploadProductFile.Image = global::Toomeet_Pos.Properties.Resources.cloud_computing1;
            this.btnUploadProductFile.Location = new System.Drawing.Point(20, 10);
            this.btnUploadProductFile.Name = "btnUploadProductFile";
            this.btnUploadProductFile.Size = new System.Drawing.Size(133, 37);
            this.btnUploadProductFile.TabIndex = 20;
            this.btnUploadProductFile.Text = "Nhập file";
            // 
            // FrmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1003, 678);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmManageProducts";
            this.Text = "FrmManageProducts";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnUploadProductFile;
        private Guna.UI2.WinForms.Guna2GradientButton btnExportProductFile;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewProductCategories;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddProduct;
    }
}