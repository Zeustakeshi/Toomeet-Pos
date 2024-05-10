namespace Toomeet_Pos.UI.Forms.settings
{
    partial class FrmStaffManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridStaffList = new System.Windows.Forms.DataGridView();
            this.btnAddStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tất cả nhân viên";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(76, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(612, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridStaffList
            // 
            this.dataGridStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaffList.Location = new System.Drawing.Point(76, 114);
            this.dataGridStaffList.Name = "dataGridStaffList";
            this.dataGridStaffList.RowHeadersWidth = 51;
            this.dataGridStaffList.RowTemplate.Height = 24;
            this.dataGridStaffList.Size = new System.Drawing.Size(693, 358);
            this.dataGridStaffList.TabIndex = 5;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(624, 17);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(145, 33);
            this.btnAddStaff.TabIndex = 6;
            this.btnAddStaff.Text = "Thêm nhân viên";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // FrmStaffManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 503);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.dataGridStaffList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmStaffManage";
            this.Text = "FrmStaffManage";
            this.Load += new System.EventHandler(this.FrmStaffManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridStaffList;
        private System.Windows.Forms.Button btnAddStaff;
    }
}