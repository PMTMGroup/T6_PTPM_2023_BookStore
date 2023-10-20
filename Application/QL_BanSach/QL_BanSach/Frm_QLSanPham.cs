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
        BLL_Tang tangBLL = new BLL_Tang();
        BLL_NhaXuatBan nxbBLL = new BLL_NhaXuatBan();
        public Frm_QLSanPham()
        {
            InitializeComponent();
            loadDGVSaches();
            loadCBBTang();
            loadCBBNhaXuatBan();
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

        private void loadCBBNhaXuatBan()
        {
            List<DTO_NhaXuatBan> NXBs = nxbBLL.GetAllNXBs();
            foreach (DTO_NhaXuatBan i in NXBs)
                cbo_TTDS_nxb.Items.Add(i.TenNXB);
        }

        private void loadCBBTang()
        {
            List<DTO_Tang> Tangs = tangBLL.GetAllTangs();
            foreach (DTO_Tang i in Tangs)
                cbo_TTDS_tangDatSach.Items.Add(i.TenTang);
        }

        private void gv_dsDauSach_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_dsDauSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_dsDauSach.SelectedRows[0];
                txt_TTDS_maSach.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_TTDS_tenSach.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txt_TTDS_tacGia.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txt_TTDS_soTrang.Text = selectedRow.Cells[3].Value.ToString().Trim();
                txt_TTDS_giaBan.Text = selectedRow.Cells[4].Value.ToString().Trim();
                cbo_TTDS_nxb.Text = sachBLL.getNXBfromMaNXB(selectedRow.Cells[7].Value.ToString().Trim()).TenNXB;
                cbo_TTDS_theLoai.Text = sachBLL.getTheLoaifromMaTheLoai(selectedRow.Cells[6].Value.ToString().Trim()).TenTheLoai;
                cbo_TTDS_tangDatSach.Text = sachBLL.getTangfromMaTang(selectedRow.Cells[8].Value.ToString().Trim()).TenTang;
                cbo_TTDS_keDatSach.Text = sachBLL.getKeDatfromMaKe(selectedRow.Cells[9].Value.ToString().Trim()).TenKe;
                pic_sanPham.Image = Image.FromFile("../Products/" + selectedRow.Cells[10].Value.ToString().Trim());
            }
        }
    }
}
