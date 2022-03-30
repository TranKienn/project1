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
    public partial class frmDanhMucList : Form
    {
        DanhMucBLL bllDM = new DanhMucBLL();
        public frmDanhMucList()
        {
            InitializeComponent();
        }

        private void frmDanhMucList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<DanhMuc> listDanhMuc = new List<DanhMuc>();
            try
            {
                listDanhMuc = bllDM.GetAll();
                //gán nguồn dữ liệu cho dgvChucVu
                dgvDanhMuc.DataSource = listDanhMuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DataTimKiem(string keyword)
        {
            List<DanhMuc> listResult = new List<DanhMuc>();
            try
            {
                listResult = bllDM.TimKiem();
                //gán nguồn dữ liệu cho dgvChucVu
                dgvDanhMuc.DataSource = listResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Common.state = 0;
            frmDanhMuc frm = new frmDanhMuc();
            //đăng ký sự kiện
            frm.Button_Clicked += CallLoadData;
            frm.Show(); 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maDM = dgvDanhMuc.CurrentRow.Cells[0].Value.ToString();
            string tenDM = dgvDanhMuc.CurrentRow.Cells[1].Value.ToString();
            frmDanhMuc frm = new frmDanhMuc();
            frm.Show();
            frm.GetDanhMuc(maDM, tenDM);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDanhMuc = dgvDanhMuc.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc không ?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllDM.Delete(dm);
            }
            LoadData();
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
