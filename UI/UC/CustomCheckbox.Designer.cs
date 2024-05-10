namespace Toomeet_Pos.UI.UC
{
    partial class CustomCheckbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCheckbox));
            this.checkBox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox.Image = ((System.Drawing.Image)(resources.GetObject("checkBox.Image")));
            this.checkBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.checkBox.ImageRotate = 0F;
            this.checkBox.Location = new System.Drawing.Point(0, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(24, 27);
            this.checkBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(24, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(161, 27);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // CustomCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBox);
            this.Name = "CustomCheckbox";
            this.Size = new System.Drawing.Size(185, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageCheckBox checkBox;
        private System.Windows.Forms.Label label;
    }
}
