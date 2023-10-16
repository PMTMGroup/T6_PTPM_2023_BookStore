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
    public partial class Frm_TimKiemSanPham : Form
    {
        public Frm_TimKiemSanPham()
        {
            InitializeComponent();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maSach.Text = "";
            txt_tenSach.Text = "";
            txt_tacGia.Text = "";
        }
    }
}
