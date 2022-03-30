namespace TTDL.GUI
{
    partial class frmDanhMuc
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
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Location = new System.Drawing.Point(27, 25);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(75, 13);
            this.lblMaDanhMuc.TabIndex = 0;
            this.lblMaDanhMuc.Text = "Mã danh mục:";
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Location = new System.Drawing.Point(27, 72);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(82, 13);
            this.lblTenDanhMuc.TabIndex = 0;
            this.lblTenDanhMuc.Text = "Tên danh mục: ";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(109, 22);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(319, 20);
            this.txtMaDanhMuc.TabIndex = 2;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(109, 69);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(319, 20);
            this.txtTenDanhMuc.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 123);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.lblTenDanhMuc);
            this.Controls.Add(this.lblMaDanhMuc);
            this.Name = "frmDanhMuc";
            this.Text = "frmDanhMuc";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.Label lblTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}