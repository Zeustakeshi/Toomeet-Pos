namespace Toomeet_Pos.UI.UC
{
    partial class CustomMenuItemGroup
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
            this.customSeparator = new Toomeet_Pos.UI.UC.CustomSeparator();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // customSeparator
            // 
            this.customSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.customSeparator.Label = "Sản phẩm";
            this.customSeparator.Location = new System.Drawing.Point(0, 0);
            this.customSeparator.Name = "customSeparator";
            this.customSeparator.Size = new System.Drawing.Size(310, 27);
            this.customSeparator.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 31);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(304, 160);
            this.guna2Panel2.TabIndex = 5;
            // 
            // CustomMenuItemGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customSeparator);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "CustomMenuItemGroup";
            this.Size = new System.Drawing.Size(310, 194);
            this.Load += new System.EventHandler(this.CustomMenuItemGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomSeparator customSeparator;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
