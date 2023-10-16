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
    public partial class Frm_BanSach : Form
    {
        public Frm_BanSach()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_BanSach_Load(object sender, EventArgs e)
        {

        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maSach.Text = "";
            txt_tenSach.Text = "";
            txt_tacGia.Text = "";
            txt_nxb.Text = "";
            txt_theLoai.Text = "";
            txt_giaBan.Text = "";
            txt_UDThanhVien.Text = "";
            txt_UDPhieuGiamGia.Text = "";
            lb_thanhVien.Text = "";
            lb_phieuGiamGia.Text = "";
        }
    }
}
