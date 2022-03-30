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
    public partial class frmDiemDuLichList : Form
    {

        DiemDuLichBLL bllDM = new DiemDuLichBLL();
        public frmDiemDuLichList()
        {
            InitializeComponent();
        }

        private void frmDiemDuLichList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
         public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<DiemDuLich> listDanhMuc = new List<DiemDuLich>();
            try
            {
                listDanhMuc = bllDM.GetAll();
                dgvDiemDuLich.DataSource = listDanhMuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maDL = dgvDiemDuLich.CurrentRow.Cells[0].Value.ToString();
            string tenDL = dgvDiemDuLich.CurrentRow.Cells[1].Value.ToString();
            string maDM = dgvDiemDuLich.CurrentRow.Cells[2].Value.ToString();
            frmDiemDuLich frm = new frmDiemDuLich();
            frm.Show();
            frm.GetDiemDuLich(maDL, tenDL,maDM);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Common.state = 0;
            frmDiemDuLich frm = new frmDiemDuLich();
            //đăng ký sự kiện
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DiemDuLich dm = new DiemDuLich();
            dm.MaDiemDL = dgvDiemDuLich.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc không ?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllDM.Delete(dm);
            }
            LoadData();
        }
    }
}
