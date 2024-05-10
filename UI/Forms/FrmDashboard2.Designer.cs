namespace Toomeet_Pos.UI.Forms
{
    partial class FrmDashboard2
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(714, 19);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(98, 32);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng quan";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(43, 283);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1155, 348);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu bán hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tỷ trọng bán hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(50, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả kinh doanh trong ngày";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hôm qua",
            "Hôm nay",
            "7 ngày qua",
            "Tháng này",
            "Tháng trước",
            "Năm nay",
            "Năm ngoái"});
            this.comboBox1.Location = new System.Drawing.Point(1033, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(202, 21);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(99, 40);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(416, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(715, 64);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(129, 29);
            this.lbRole.TabIndex = 6;
            this.lbRole.Text = "Tổng quan";
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(311, 20);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(99, 40);
            this.btnManageProduct.TabIndex = 7;
            this.btnManageProduct.Text = "Sản phẩm";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 789);
            this.Controls.Add(this.btnManageProduct);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWelcome);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Button btnManageProduct;
    }
}