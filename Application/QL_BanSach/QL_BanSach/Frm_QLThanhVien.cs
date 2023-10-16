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
    public partial class Frm_QLThanhVien : Form
    {
        public Frm_QLThanhVien()
        {
            InitializeComponent();
        }

        private void btn_TTTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TTTV_maThanhVien.Text = "";
            txt_TTTV_tenThanhVien.Text = "";
            txt_TTTV_sdt.Text = "";
            txt_TTTV_soTienDaMua.Text = "";
            txt_TTTV_matKhau.Text = "";
        }

        private void btn_TCTTTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TCTTTV_sdt.Text = "";
        }

        private void btn_QLLTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_QLLTV_maLoaiThanhVien.Text = "";
            txt_QLLTV_tenLoaiThanhVien.Text = "";
            txt_QLLTV_soTienCanDat.Text = "";
            txt_QLLTV_phanTramGiamGia.Text = "";
        }
    }
}
