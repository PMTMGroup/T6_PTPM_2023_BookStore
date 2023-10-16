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
    public partial class Frm_QLSanPham : Form
    {
        public Frm_QLSanPham()
        {
            InitializeComponent();
        }

        private void btn_TTDS_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TTDS_maSach.Text = "";
            txt_TTDS_tenSach.Text = "";
            txt_TTDS_tacGia.Text = "";
            txt_TTDS_soTrang.Text = "";
            txt_TTDS_giaBan.Text = "";
        }
    }
}
