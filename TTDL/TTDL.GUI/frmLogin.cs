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

namespace TTDL.GUI
{
    public partial class frmLogin : Form
    {

        UserBLL bllUser = new UserBLL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (bllUser.DangNhap(txtUsername.Text, txtPassword.Text))
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    //  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Hide();
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
