namespace Toomeet_Pos.UI.UC
{
    partial class ProductOrderItem
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
            this.lbSkuCode = new System.Windows.Forms.Label();
            this.btnRemove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbProductCategory = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.numbericQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbUnitOfMeasure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numbericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSkuCode
            // 
            this.lbSkuCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSkuCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkuCode.Location = new System.Drawing.Point(5, 5);
            this.lbSkuCode.Name = "lbSkuCode";
            this.lbSkuCode.Size = new System.Drawing.Size(177, 57);
            this.lbSkuCode.TabIndex = 6;
            this.lbSkuCode.Text = "NC_STING";
            this.lbSkuCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.BorderRadius = 10;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnRemove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(57)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::Toomeet_Pos.Properties.Resources.delete;
            this.btnRemove.Location = new System.Drawing.Point(729, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 40);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbPrice.Location = new System.Drawing.Point(593, 21);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(118, 22);
            this.lbPrice.TabIndex = 43;
            this.lbPrice.Text = "100.000 VND";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductCategory
            // 
            this.lbProductCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductCategory.AutoSize = true;
            this.lbProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lbProductCategory.Location = new System.Drawing.Point(211, 41);
            this.lbProductCategory.Name = "lbProductCategory";
            this.lbProductCategory.Size = new System.Drawing.Size(97, 16);
            this.lbProductCategory.TabIndex = 45;
            this.lbProductCategory.Text = "Kem đánh răng";
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbProductName.Location = new System.Drawing.Point(210, 9);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(161, 22);
            this.lbProductName.TabIndex = 44;
            this.lbProductName.Text = "Kem đánh răng PS";
            // 
            // numbericQuantity
            // 
            this.numbericQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numbericQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numbericQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numbericQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numbericQuantity.Location = new System.Drawing.Point(396, 10);
            this.numbericQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numbericQuantity.Name = "numbericQuantity";
            this.numbericQuantity.Size = new System.Drawing.Size(135, 48);
            this.numbericQuantity.TabIndex = 47;
            this.numbericQuantity.ValueChanged += new System.EventHandler(this.numbericQuantity_ValueChanged);
            // 
            // lbUnitOfMeasure
            // 
            this.lbUnitOfMeasure.AutoSize = true;
            this.lbUnitOfMeasure.Location = new System.Drawing.Point(543, 27);
            this.lbUnitOfMeasure.Name = "lbUnitOfMeasure";
            this.lbUnitOfMeasure.Size = new System.Drawing.Size(27, 16);
            this.lbUnitOfMeasure.TabIndex = 48;
            this.lbUnitOfMeasure.Text = "Cái";
            // 
            // ProductOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbUnitOfMeasure);
            this.Controls.Add(this.numbericQuantity);
            this.Controls.Add(this.lbProductCategory);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbSkuCode);
            this.Name = "ProductOrderItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(819, 67);
            ((System.ComponentModel.ISupportInitialize)(this.numbericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSkuCode;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemove;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductCategory;
        private System.Windows.Forms.Label lbProductName;
        private Guna.UI2.WinForms.Guna2NumericUpDown numbericQuantity;
        private System.Windows.Forms.Label lbUnitOfMeasure;
    }
}
