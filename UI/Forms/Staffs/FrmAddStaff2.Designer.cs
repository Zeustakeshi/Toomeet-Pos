namespace Toomeet_Pos.UI.Forms.Staffs
{
    partial class FrmAddStaff2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAddStaff);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(30, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDescription);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(23, 434);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(665, 146);
            this.panel5.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 37);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(630, 106);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 598);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hủy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(594, 598);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(122, 47);
            this.btnAddStaff.TabIndex = 4;
            this.btnAddStaff.Text = "Mời";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddRole);
            this.panel4.Controls.Add(this.cbRoles);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(23, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(665, 89);
            this.panel4.TabIndex = 4;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(322, 49);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddRole.TabIndex = 3;
            this.btnAddRole.Text = "Thêm";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(20, 48);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(267, 24);
            this.cbRoles.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vai trò";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Location = new System.Drawing.Point(23, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 89);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(630, 34);
            this.txtEmail.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Location = new System.Drawing.Point(23, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 89);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(20, 37);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(630, 34);
            this.txtPhone.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(23, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 89);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên nhân viên";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(630, 34);
            this.txtName.TabIndex = 0;
            // 
            // FrmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddStaff";
            this.Text = "FrmAddStaff";
            this.Load += new System.EventHandler(this.FrmAddStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}