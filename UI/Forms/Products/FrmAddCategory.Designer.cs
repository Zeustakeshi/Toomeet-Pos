namespace Toomeet_Pos.UI.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCategory));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.controlBoxGroup1 = new Toomeet_Pos.UI.UC.ControlBoxGroupMacOs();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddNewCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtCategoryDesc = new Toomeet_Pos.UI.UC.CustomTextBox();
            this.txtCategoryId = new Toomeet_Pos.UI.UC.CustomTextBox();
            this.txtCategoryName = new Toomeet_Pos.UI.UC.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
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
            this.guna2Panel1.Size = new System.Drawing.Size(492, 46);
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
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnAddNewCategory);
            this.guna2Panel2.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 46);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(492, 630);
            this.guna2Panel2.TabIndex = 17;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCategory.BorderRadius = 10;
            this.btnAddNewCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCategory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddNewCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAddNewCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCategory.Location = new System.Drawing.Point(10, 559);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(469, 44);
            this.btnAddNewCategory.TabIndex = 25;
            this.btnAddNewCategory.Text = "Thêm";
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.txtCategoryDesc);
            this.guna2ShadowPanel1.Controls.Add(this.txtCategoryId);
            this.guna2ShadowPanel1.Controls.Add(this.txtCategoryName);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(10, 10);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(469, 534);
            this.guna2ShadowPanel1.TabIndex = 18;
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.ErrorMessage = "";
            this.txtCategoryDesc.IsPassword = false;
            this.txtCategoryDesc.Label = "Ghi Chú";
            this.txtCategoryDesc.Location = new System.Drawing.Point(20, 282);
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Required = true;
            this.txtCategoryDesc.Size = new System.Drawing.Size(421, 233);
            this.txtCategoryDesc.TabIndex = 28;
            this.txtCategoryDesc.TextAreaMode = true;
            this.txtCategoryDesc.TextboxPlaceholder = "Ghi chú loại sản phẩm";
            this.txtCategoryDesc.TextBoxSize = new System.Drawing.Size(385, 171);
            this.txtCategoryDesc.Value = "";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.ErrorMessage = "";
            this.txtCategoryId.IsPassword = false;
            this.txtCategoryId.Label = "Mã loại sản phẩm";
            this.txtCategoryId.Location = new System.Drawing.Point(20, 165);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Required = true;
            this.txtCategoryId.Size = new System.Drawing.Size(426, 102);
            this.txtCategoryId.TabIndex = 27;
            this.txtCategoryId.TextAreaMode = false;
            this.txtCategoryId.TextboxPlaceholder = "Mã loại sản phẩm";
            this.txtCategoryId.TextBoxSize = new System.Drawing.Size(390, 40);
            this.txtCategoryId.Value = "";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.ErrorMessage = "";
            this.txtCategoryName.IsPassword = false;
            this.txtCategoryName.Label = "Tên loại sản phẩm";
            this.txtCategoryName.Location = new System.Drawing.Point(20, 57);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Required = true;
            this.txtCategoryName.Size = new System.Drawing.Size(426, 102);
            this.txtCategoryName.TabIndex = 26;
            this.txtCategoryName.TextAreaMode = false;
            this.txtCategoryName.TextboxPlaceholder = "Ví dụ: Nước suối";
            this.txtCategoryName.TextBoxSize = new System.Drawing.Size(390, 40);
            this.txtCategoryName.Value = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Thêm loại sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(492, 676);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTemplate";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UC.ControlBoxGroupMacOs controlBoxGroup1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewCategory;
        private UC.CustomTextBox txtCategoryDesc;
        private UC.CustomTextBox txtCategoryId;
        private UC.CustomTextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
    }
}