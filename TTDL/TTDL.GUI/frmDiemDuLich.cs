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
    public partial class frmDiemDuLich : Form
    {

        public Action<string, string, string> getData;

        DiemDuLichBLL bllDanhMuc = new DiemDuLichBLL();

        DiemDuLich dm = new DiemDuLich();
        public frmDiemDuLich()
        {
            InitializeComponent();
            getData = GetDiemDuLich;
        }

        private void frmDiemDuLich_Load(object sender, EventArgs e)
        {

        }

        public void GetDiemDuLich(string maDL, string tenDL, string maDM)
        {
            txtMaDiemDL.Text = maDL;
            txtTenDiemDL.Text = tenDL;
            txtMaDanhMuc.Text = maDM;
        }

        public event EventHandler Button_Clicked;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDiemDL.Text != string.Empty && txtTenDiemDL.Text != string.Empty)

                {
                    dm.MaDiemDL = txtMaDiemDL.Text;
                    dm.TenDiemDL = txtTenDiemDL.Text;
                    dm.MaDanhMuc = txtMaDanhMuc.Text;
                    if (Common.state == 0)
                    {
                        if (bllDanhMuc.Insert(dm))
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
                        if (bllDanhMuc.Update(dm))
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
