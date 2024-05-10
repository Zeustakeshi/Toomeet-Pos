namespace Toomeet_Pos.UI.Forms
{
    partial class FrmManageStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageStaff));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.controlBoxGroup1 = new Toomeet_Pos.UI.UC.ControlBoxGroupMacOs();
            this.btnAddStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnViewRoles = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgStaffList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffList)).BeginInit();
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
            this.guna2Panel1.Size = new System.Drawing.Size(1128, 46);
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
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.BorderRadius = 10;
            this.btnAddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddStaff.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(892, 58);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(210, 50);
            this.btnAddStaff.TabIndex = 17;
            this.btnAddStaff.Text = "Thêm nhân viên khác";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnViewRoles
            // 
            this.btnViewRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRoles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnViewRoles.BorderRadius = 10;
            this.btnViewRoles.BorderThickness = 1;
            this.btnViewRoles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewRoles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewRoles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewRoles.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewRoles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewRoles.FillColor = System.Drawing.Color.Transparent;
            this.btnViewRoles.FillColor2 = System.Drawing.Color.Transparent;
            this.btnViewRoles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnViewRoles.Location = new System.Drawing.Point(664, 58);
            this.btnViewRoles.Name = "btnViewRoles";
            this.btnViewRoles.Size = new System.Drawing.Size(208, 50);
            this.btnViewRoles.TabIndex = 18;
            this.btnViewRoles.Text = "Phân quyền vai trò";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.btnSearch);
            this.guna2ShadowPanel2.Controls.Add(this.txtSearch);
            this.guna2ShadowPanel2.Controls.Add(this.dgStaffList);
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(12, 117);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.guna2ShadowPanel2.ShadowDepth = 50;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1103, 584);
            this.guna2ShadowPanel2.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1023, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 35);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Lọc";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::Toomeet_Pos.Properties.Resources.search_ico;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtSearch.IconRightOffset = new System.Drawing.Point(20, 20);
            this.txtSearch.IconRightSize = new System.Drawing.Size(5, 5);
            this.txtSearch.Location = new System.Drawing.Point(13, 65);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên nhân viên";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1004, 35);
            this.txtSearch.TabIndex = 22;
            // 
            // dgStaffList
            // 
            this.dgStaffList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgStaffList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStaffList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgStaffList.ColumnHeadersHeight = 50;
            this.dgStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStaffList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgStaffList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgStaffList.Location = new System.Drawing.Point(13, 132);
            this.dgStaffList.Name = "dgStaffList";
            this.dgStaffList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStaffList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgStaffList.RowHeadersVisible = false;
            this.dgStaffList.RowHeadersWidth = 51;
            this.dgStaffList.RowTemplate.Height = 60;
            this.dgStaffList.Size = new System.Drawing.Size(1077, 439);
            this.dgStaffList.TabIndex = 21;
            this.dgStaffList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgStaffList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgStaffList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgStaffList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgStaffList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgStaffList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgStaffList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgStaffList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgStaffList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgStaffList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgStaffList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgStaffList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgStaffList.ThemeStyle.HeaderStyle.Height = 50;
            this.dgStaffList.ThemeStyle.ReadOnly = false;
            this.dgStaffList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgStaffList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgStaffList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgStaffList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgStaffList.ThemeStyle.RowsStyle.Height = 60;
            this.dgStaffList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgStaffList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tất cả nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1128, 713);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.btnViewRoles);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTemplate";
            this.Load += new System.EventHandler(this.FrmManageStaff_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UC.ControlBoxGroupMacOs controlBoxGroup1;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewRoles;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddStaff;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgStaffList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
    }
}