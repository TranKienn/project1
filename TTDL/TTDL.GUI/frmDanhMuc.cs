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
    public partial class frmDanhMuc : Form
    {
        public Action<string,string> getData;

        DanhMucBLL bllDanhMuc = new DanhMucBLL();

        DanhMuc dm = new DanhMuc();
        public frmDanhMuc()
        {
            InitializeComponent();
            getData = GetDanhMuc;
        }

        public void GetDanhMuc(string maDM, string tenDM)
        {
            txtMaDanhMuc.Text = maDM;
            txtTenDanhMuc.Text = tenDM;
        }
        //Tạo sự kiện liên kết đến delegate
        public event EventHandler Button_Clicked;

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhMuc.Text != string.Empty && txtTenDanhMuc.Text != string.Empty)
                {
                    dm.MaDanhMuc = txtMaDanhMuc.Text;
                    dm.TenDanhMuc = txtTenDanhMuc.Text;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            ;
            if (MessageBox.Show("Bạn có chắc không ?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllDanhMuc.Delete(dm);
            }
        }
    }
}
