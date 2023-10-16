using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_DangNhap
{
    public partial class Frm_QLHeThongVatTu : Form
    {
        public Frm_QLHeThongVatTu()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TTT_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maTang.Text = "";
            txt_tenTang.Text = "";
        }

        private void btn_TTNXB_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maNXB.Text = "";
            txt_tenNXB.Text = "";
        }

        private void btn_TTTL_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maTheLoai.Text = "";
            txt_tenTheLoai.Text = "";

        }

        private void btn_TTKD_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maKe.Text = "";
            txt_tenKe.Text = "";
        }
    }
}
