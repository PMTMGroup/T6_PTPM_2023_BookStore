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
    public partial class Frm_QLKhoHang : Form
    {
        public Frm_QLKhoHang()
        {
            InitializeComponent();
        }

        private void btn_TTHDK_lamMoi_Click(object sender, EventArgs e)
        {
            txt_ngayLap.Text = "";
            txt_maSach.Text = "";
            txt_gia.Text = "";
            txt_ghiChu.Text = "";
        }
    }
}
