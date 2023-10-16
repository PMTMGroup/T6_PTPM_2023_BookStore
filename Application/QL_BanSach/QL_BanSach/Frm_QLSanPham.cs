using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Frm_DangNhap
{
    public partial class Frm_QLSanPham : Form
    {
        BLL_Sach sachBLL = new BLL_Sach();
        public Frm_QLSanPham()
        {
            InitializeComponent();
            loadDGVSaches();
        }

        private void btn_TTDS_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TTDS_maSach.Text = "";
            txt_TTDS_tenSach.Text = "";
            txt_TTDS_tacGia.Text = "";
            txt_TTDS_soTrang.Text = "";
            txt_TTDS_giaBan.Text = "";
        }

        private void loadDGVSaches()
        {
            List<DTO_Sach> saches = sachBLL.GetAllSaches();
            gv_dsDauSach.DataSource = saches;
        }
    }
}
