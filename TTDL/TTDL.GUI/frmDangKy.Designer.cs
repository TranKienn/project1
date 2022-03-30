namespace TTDL.GUI
{
    partial class frmDangKy
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(42, 23);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(40, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PassWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "FullName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DateOfBirth";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(126, 20);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(439, 20);
            this.txtUserID.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(126, 65);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(439, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(126, 101);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(439, 20);
            this.txtPassWord.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(126, 145);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(439, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(439, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 243);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(439, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(126, 348);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(502, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(126, 285);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(439, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserID);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}