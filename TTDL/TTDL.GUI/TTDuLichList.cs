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
    public partial class TTDuLichList : Form
    {
        TTDuLichBLL bllDM = new TTDuLichBLL();
        public TTDuLichList()
        {
            InitializeComponent();
        }

        public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Common.state = 0;
            frmTTDuLich frm = new frmTTDuLich();
            //đăng ký sự kiện
            frm.Button_Clicked += CallLoadData;
            frm.Show(); 
        }

        private void TTDuLichList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<TTDuLich> listDanhMuc = new List<TTDuLich>();
            try
            {
                listDanhMuc = bllDM.GetAll();
                //gán nguồn dữ liệu cho dgvChucVu
                dgvTTDuLich.DataSource = listDanhMuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.state = 1;
            string maTTDL = dgvTTDuLich.CurrentRow.Cells[0].Value.ToString();
            string maDiemDL = dgvTTDuLich.CurrentRow.Cells[1].Value.ToString();
            string diemXP = dgvTTDuLich.CurrentRow.Cells[2].Value.ToString();
            DateTime ngayKH = DateTime.Parse(dgvTTDuLich.CurrentRow.Cells[3].Value.ToString());
            string pt = dgvTTDuLich.CurrentRow.Cells[4].Value.ToString();
            string gia = dgvTTDuLich.CurrentRow.Cells[5].Value.ToString();
            frmTTDuLich frm = new frmTTDuLich();
            frm.Show();
            frm.GetTTDL(maTTDL, maDiemDL, diemXP, ngayKH, pt, gia);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TTDuLich dm = new TTDuLich();
            dm.MaTTDL = dgvTTDuLich.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc không ?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllDM.Delete(dm);
            }
            LoadData();
        }
    }
}
