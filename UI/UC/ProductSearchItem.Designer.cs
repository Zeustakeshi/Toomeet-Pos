namespace Toomeet_Pos.UI.UC
{
    partial class ProductSearchItem
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
            this.image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbProductCategory = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BorderRadius = 10;
            this.image.Dock = System.Windows.Forms.DockStyle.Left;
            this.image.ErrorImage = global::Toomeet_Pos.Properties.Resources.store_image;
            this.image.Image = global::Toomeet_Pos.Properties.Resources.store_image;
            this.image.ImageRotate = 0F;
            this.image.Location = new System.Drawing.Point(5, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(84, 64);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.ProducSearchItem_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.lbProductCategory);
            this.guna2Panel1.Controls.Add(this.lbProductName);
            this.guna2Panel1.Location = new System.Drawing.Point(95, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(220, 64);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Click += new System.EventHandler(this.ProducSearchItem_Click);
            // 
            // lbProductCategory
            // 
            this.lbProductCategory.AutoSize = true;
            this.lbProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lbProductCategory.Location = new System.Drawing.Point(12, 41);
            this.lbProductCategory.Name = "lbProductCategory";
            this.lbProductCategory.Size = new System.Drawing.Size(44, 16);
            this.lbProductCategory.TabIndex = 6;
            this.lbProductCategory.Text = "label2";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoEllipsis = true;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.lbProductName.Location = new System.Drawing.Point(11, 9);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(161, 22);
            this.lbProductName.TabIndex = 5;
            this.lbProductName.Text = "Kem đánh răng PS";
            // 
            // ProductSearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.image);
            this.Name = "ProductSearchItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(323, 74);
            this.Load += new System.EventHandler(this.ProducSearchItem_Load);
            this.Click += new System.EventHandler(this.ProducSearchItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox image;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbProductCategory;
        private System.Windows.Forms.Label lbProductName;
    }
}
