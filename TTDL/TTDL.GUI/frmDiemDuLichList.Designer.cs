namespace TTDL.GUI
{
    partial class frmDiemDuLichList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemDuLichList));
            this.dgvDiemDuLich = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.MaDiemDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDiemDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDuLich)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiemDuLich
            // 
            this.dgvDiemDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDuLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDiemDL,
            this.TenDiemDL,
            this.MaDanhMuc});
            this.dgvDiemDuLich.Location = new System.Drawing.Point(0, 28);
            this.dgvDiemDuLich.Name = "dgvDiemDuLich";
            this.dgvDiemDuLich.Size = new System.Drawing.Size(708, 250);
            this.dgvDiemDuLich.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 22);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MaDiemDL
            // 
            this.MaDiemDL.DataPropertyName = "MaDiemDL";
            this.MaDiemDL.HeaderText = "Mã điểm du lịch";
            this.MaDiemDL.Name = "MaDiemDL";
            this.MaDiemDL.Width = 150;
            // 
            // TenDiemDL
            // 
            this.TenDiemDL.DataPropertyName = "TenDiemDL";
            this.TenDiemDL.HeaderText = "Tên điểm du lịch";
            this.TenDiemDL.Name = "TenDiemDL";
            this.TenDiemDL.Width = 415;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Mã danh mục";
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 22);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // frmDiemDuLichList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 278);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDiemDuLich);
            this.Name = "frmDiemDuLichList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm du lịch";
            this.Load += new System.EventHandler(this.frmDiemDuLichList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDuLich)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiemDuLich;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiemDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDiemDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnXoa;
    }
}