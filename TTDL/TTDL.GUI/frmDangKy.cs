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
    public partial class frmDangKy : Form
    {

        //public Action<string, string> getData;

        UserBLL bllDanhMuc = new UserBLL();

        User dm = new User();
        public frmDangKy()
        {
            InitializeComponent();
        }

        
        //Tạo sự kiện liên kết đến delegate
        public event EventHandler Button_Clicked;

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text != string.Empty && txtUserName.Text != string.Empty && txtPassWord.Text != string.Empty)
                {
                    dm.UserID = txtUserID.Text;
                    dm.UserName = txtUserName.Text;
                    dm.Password = txtPassWord.Text;
                    dm.FullName = txtFullName.Text;
                    dm.Email = txtEmail.Text;
                    dm.Phone = txtPhone.Text;
                    dm.DateOfBirth = dtpNgaySinh.Value;
                    if (Common.state == 0)
                    {
                        if (bllDanhMuc.Insert(dm))
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.OK,
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
