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
    public partial class Frm_QLTaiKhoan : Form
    {
        public Frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_QLTK_lamMoi_Click(object sender, EventArgs e)
        {
            txt_QLTK_maTaiKhoan.Text = "";
            txt_QLTK_hoTen.Text = "";
            txt_QLTK_sdt.Text = "";
            txt_QLTK_tenDangNhap.Text = "";
            txt_QLTK_matKhau.Text = "";

        }
    }
}
