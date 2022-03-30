namespace TTDL.GUI
{
    partial class frmDiemDuLich
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaDiemDL = new System.Windows.Forms.Label();
            this.lblTenDiemDL = new System.Windows.Forms.Label();
            this.txtMaDiemDL = new System.Windows.Forms.TextBox();
            this.txtTenDiemDL = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // lblMaDiemDL
            // 
            this.lblMaDiemDL.AutoSize = true;
            this.lblMaDiemDL.Location = new System.Drawing.Point(13, 26);
            this.lblMaDiemDL.Name = "lblMaDiemDL";
            this.lblMaDiemDL.Size = new System.Drawing.Size(65, 13);
            this.lblMaDiemDL.TabIndex = 0;
            this.lblMaDiemDL.Text = "Mã điểm DL";
            // 
            // lblTenDiemDL
            // 
            this.lblTenDiemDL.AutoSize = true;
            this.lblTenDiemDL.Location = new System.Drawing.Point(13, 69);
            this.lblTenDiemDL.Name = "lblTenDiemDL";
            this.lblTenDiemDL.Size = new System.Drawing.Size(69, 13);
            this.lblTenDiemDL.TabIndex = 0;
            this.lblTenDiemDL.Text = "Tên điểm DL";
            // 
            // txtMaDiemDL
            // 
            this.txtMaDiemDL.Location = new System.Drawing.Point(84, 26);
            this.txtMaDiemDL.Name = "txtMaDiemDL";
            this.txtMaDiemDL.Size = new System.Drawing.Size(344, 20);
            this.txtMaDiemDL.TabIndex = 1;
            // 
            // txtTenDiemDL
            // 
            this.txtTenDiemDL.Location = new System.Drawing.Point(84, 66);
            this.txtTenDiemDL.Name = "txtTenDiemDL";
            this.txtTenDiemDL.Size = new System.Drawing.Size(344, 20);
            this.txtTenDiemDL.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(73, 172);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(342, 172);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Location = new System.Drawing.Point(12, 118);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(72, 13);
            this.lblMaDanhMuc.TabIndex = 0;
            this.lblMaDanhMuc.Text = "Mã danh mục";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(84, 118);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(344, 20);
            this.txtMaDanhMuc.TabIndex = 1;
            // 
            // frmDiemDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.txtTenDiemDL);
            this.Controls.Add(this.txtMaDiemDL);
            this.Controls.Add(this.lblMaDanhMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTenDiemDL);
            this.Controls.Add(this.lblMaDiemDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDiemDuLich";
            this.Text = "frmDiemDuLich";
            this.Load += new System.EventHandler(this.frmDiemDuLich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaDiemDL;
        private System.Windows.Forms.Label lblTenDiemDL;
        private System.Windows.Forms.TextBox txtMaDiemDL;
        private System.Windows.Forms.TextBox txtTenDiemDL;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
    }
}