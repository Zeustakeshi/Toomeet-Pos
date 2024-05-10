namespace Toomeet_Pos.UI.Forms
{
    partial class FrmTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemplate));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.controlBoxGroup1 = new Toomeet_Pos.UI.UC.ControlBoxGroupMacOs();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
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
            this.guna2Panel1.Size = new System.Drawing.Size(1197, 46);
            this.guna2Panel1.TabIndex = 16;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmTileMouseDown);
            // 
            // controlBoxGroup1
            // 
            this.controlBoxGroup1.Location = new System.Drawing.Point(13, 13);
            this.controlBoxGroup1.Name = "controlBoxGroup1";
            this.controlBoxGroup1.Size = new System.Drawing.Size(60, 19);
            this.controlBoxGroup1.TabIndex = 1;
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1197, 709);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTemplate";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UC.ControlBoxGroupMacOs controlBoxGroup1;
    }
}