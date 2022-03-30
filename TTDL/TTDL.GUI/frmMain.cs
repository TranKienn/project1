using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTDL.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void địaPhươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucList frm = new frmDanhMucList();
            frm.Show();
        }

        private void mnuDiemDL_Click(object sender, EventArgs e)
        {
            frmDiemDuLichList frm = new frmDiemDuLichList();
            frm.Show();
        }

        private void mnuTTDuLich_Click(object sender, EventArgs e)
        {
            TTDuLichList frm = new TTDuLichList();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
