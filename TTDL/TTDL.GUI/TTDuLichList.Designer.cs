namespace TTDL.GUI
{
    partial class TTDuLichList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTDuLichList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.dgvTTDuLich = new System.Windows.Forms.DataGridView();
            this.MaTTDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiemDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDuLich)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemMoi,
            this.btnSua,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(65, 22);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(30, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvTTDuLich
            // 
            this.dgvTTDuLich.AllowUserToAddRows = false;
            this.dgvTTDuLich.AllowUserToDeleteRows = false;
            this.dgvTTDuLich.AllowUserToOrderColumns = true;
            this.dgvTTDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTDuLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTTDL,
            this.MaDiemDL,
            this.DiemXuatPhat,
            this.NgayKhoiHanh,
            this.PhuongTien,
            this.Gia});
            this.dgvTTDuLich.Location = new System.Drawing.Point(0, 28);
            this.dgvTTDuLich.Name = "dgvTTDuLich";
            this.dgvTTDuLich.ReadOnly = true;
            this.dgvTTDuLich.Size = new System.Drawing.Size(761, 410);
            this.dgvTTDuLich.TabIndex = 1;
            // 
            // MaTTDL
            // 
            this.MaTTDL.DataPropertyName = "MaTTDL";
            this.MaTTDL.HeaderText = "Mã TT du lịch";
            this.MaTTDL.Name = "MaTTDL";
            this.MaTTDL.ReadOnly = true;
            // 
            // MaDiemDL
            // 
            this.MaDiemDL.DataPropertyName = "MaDiemDL";
            this.MaDiemDL.HeaderText = "Mã điểm du lịch";
            this.MaDiemDL.Name = "MaDiemDL";
            this.MaDiemDL.ReadOnly = true;
            // 
            // DiemXuatPhat
            // 
            this.DiemXuatPhat.DataPropertyName = "DiemXuatPhat";
            this.DiemXuatPhat.HeaderText = "Điểm xuất phát";
            this.DiemXuatPhat.Name = "DiemXuatPhat";
            this.DiemXuatPhat.ReadOnly = true;
            // 
            // NgayKhoiHanh
            // 
            this.NgayKhoiHanh.DataPropertyName = "NgayKhoiHanh";
            this.NgayKhoiHanh.HeaderText = "Ngày khởi hành";
            this.NgayKhoiHanh.Name = "NgayKhoiHanh";
            this.NgayKhoiHanh.ReadOnly = true;
            this.NgayKhoiHanh.Width = 150;
            // 
            // PhuongTien
            // 
            this.PhuongTien.DataPropertyName = "PhuongTien";
            this.PhuongTien.HeaderText = "Phương tiện";
            this.PhuongTien.Name = "PhuongTien";
            this.PhuongTien.ReadOnly = true;
            this.PhuongTien.Width = 150;
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // TTDuLichList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 442);
            this.Controls.Add(this.dgvTTDuLich);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TTDuLichList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin du lịch";
            this.Load += new System.EventHandler(this.TTDuLichList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDuLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemMoi;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.DataGridView dgvTTDuLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTTDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiemDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}