using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTDL.BLL;
using TTDL.DTO;
using TTDL.UTIL;

namespace TTDL.GUI
{
    public partial class frmTTDuLich : Form
    {
        public Action<string, string, string, DateTime, string, string> getData;

        TTDuLichBLL bllTTDL = new TTDuLichBLL();

        TTDuLich dm = new TTDuLich();
        public frmTTDuLich()
        {
            InitializeComponent();
            getData = GetTTDL;
            
        }

        public void GetTTDL(string maTTDL, string maDiemDL, string diemXP, DateTime ngayKH, string pt, string gia)
        {
            txtMaTTDL.Text = maTTDL;
            cboMaDiemDL.Text = maDiemDL;
            cboDiemXuatPhat.Text = diemXP;
            dtpNgayKH.Value = ngayKH;
            txtPhuongTien.Text = pt;
            txtGia.Text = gia;
        }

        public event EventHandler Button_Clicked;

        private void TTDuLich_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTTDL.Text != string.Empty)
                {
                    dm.MaTTDL = txtMaTTDL.Text;
                    dm.MaDiemDL = cboMaDiemDL.Text;
                    dm.DiemXuatPhat = cboDiemXuatPhat.Text;
                    dm.NgayKhoiHanh = dtpNgayKH.Value;
                    dm.PhuongTien = txtPhuongTien.Text;
                    dm.Gia = txtGia.Text;
                    if (Common.state == 0)
                    {
                        if (bllTTDL.Insert(dm))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu thất bại!", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (bllTTDL.Update(dm))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu thất bại!", "Lỗi", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            //Khi sự kiện xảy ra
            if (Button_Clicked != null)
            {
                //Phát sinh sự kiện
                Button_Clicked(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
