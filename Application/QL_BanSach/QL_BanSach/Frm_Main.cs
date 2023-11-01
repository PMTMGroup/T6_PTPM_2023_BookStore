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
    public partial class Frm_Main : Form
    {
        private string maTKDN;
        public Frm_Main()
        {
            InitializeComponent();
        }

        public Frm_Main(string maTKDN)
        {
            InitializeComponent();
            positionFixedUIDefault();
            this.maTKDN = maTKDN;
        }

        private void positionFixedUIDefault()
        {
            Button[] arr_button = new Button[]{
                btn_bansach, btn_qlsanpham, btn_timkiemsp, btn_dondathang, btn_qlhoadon, btn_qlthanhvien, btn_qluudai, btn_qlkho, btn_qltaikhoan, btn_thongke, btn_hethongvattu, btn_dangxuat
            };
            foreach(Button button in arr_button)
            {
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }
        private void onClickChange(Button btnClicked)
        {
            Button[] arr_button = new Button[]{
                btn_bansach, btn_qlsanpham, btn_timkiemsp, btn_dondathang, btn_qlhoadon, btn_qlthanhvien, btn_qluudai, btn_qlkho, btn_qltaikhoan, btn_thongke, btn_hethongvattu
            };
            foreach (Button button in arr_button)
            {
                button.BackColor = Color.White;
            }
            btnClicked.BackColor = Color.LightGray;
        }

        private void btn_qlhoadon_Click(object sender, EventArgs e)
        {
            onClickChange(btn_qlhoadon);
            Frm_QLHoaDonBan _frm = new Frm_QLHoaDonBan();
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_qlsanpham_Click(object sender, EventArgs e)
        {
            onClickChange(btn_qlsanpham);
            Frm_QLSanPham _frm = new Frm_QLSanPham();
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_timkiemsp_Click(object sender, EventArgs e)
        {
            onClickChange(btn_timkiemsp);
            Frm_TimKiemSanPham _frm = new Frm_TimKiemSanPham();
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_dondathang_Click(object sender, EventArgs e)
        {
            onClickChange(btn_dondathang);
            Frm_QLDonDatHang _frm = new Frm_QLDonDatHang();
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_bansach_Click(object sender, EventArgs e)
        {
            onClickChange(btn_bansach);
            Frm_BanSach _frm = new Frm_BanSach(maTKDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_qlthanhvien_Click(object sender, EventArgs e)
        {
            onClickChange(btn_qlthanhvien);
            Frm_QLThanhVien _frm = new Frm_QLThanhVien(maTKDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_qluudai_Click(object sender, EventArgs e)
        {
            onClickChange(btn_qluudai);
            Frm_QLPhieuGiamGia _frm = new Frm_QLPhieuGiamGia(maTKDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_qlkho_Click(object sender, EventArgs e)
        {
            onClickChange(btn_qlkho);
            Frm_QLKhoHang _frm = new Frm_QLKhoHang(maTKDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_qltaikhoan_Click(object sender, EventArgs e)
        {
            onClickChange(btn_qltaikhoan);
            Frm_QLTaiKhoan _frm = new Frm_QLTaiKhoan(maTKDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            onClickChange(btn_thongke);
            Frm_ThongKe _frm = new Frm_ThongKe(maTKDN);
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_hethongvattu_Click(object sender, EventArgs e)
        {
            onClickChange(btn_hethongvattu);
            Frm_QLHeThongVatTu _frm = new Frm_QLHeThongVatTu();
            _frm.TopLevel = false;
            panel_master.Controls.Clear();
            panel_master.Controls.Add(_frm);
            _frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _frm.Dock = DockStyle.Fill;
            _frm.Show();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                this.Visible = false;
                Frm_DangNhap frmOBJ = new Frm_DangNhap();
                frmOBJ.Show();
            }
        }
    }
}
