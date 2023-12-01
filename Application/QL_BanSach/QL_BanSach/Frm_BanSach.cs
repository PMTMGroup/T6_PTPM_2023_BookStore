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
    public partial class Frm_BanSach : Form
    {
        BLL_BanSach bllBanSach = new BLL_BanSach();
        BLL_XuatHoaDon bllXHD = new BLL_XuatHoaDon();
        private string maTKDN;
        public Frm_BanSach(string maTKDN)
        {
            InitializeComponent();
            this.maTKDN = maTKDN;
        }
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
            refreshFieldInput();
            pb_hinhAnh.Image = Image.FromFile("../Debug/Products/loadingPic.png");
        }

        private void refreshFieldInput()
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
            num_soLuongMua.Value = Convert.ToInt32("1");
            setTongTienLabel();
        }

        private void btn_kiemTra_Click(object sender, EventArgs e)
        {
            if (txt_maSach.Text.Trim() == string.Empty && txt_tenSach.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền Mã sách hoặc Tên sách!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(txt_maSach.Text.Trim() != string.Empty)
                {
                    DTO_Sach _sach = bllBanSach.getSachfromMaSach(txt_maSach.Text.Trim());
                    if(_sach == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        txt_maSach.Text = _sach.MaSach.Trim();
                        txt_tenSach.Text = _sach.TenSach.Trim();
                        txt_tacGia.Text = _sach.TacGia.Trim();
                        txt_nxb.Text = bllBanSach.getNXBfromMaNXB(_sach.MaNXB.Trim()).TenNXB;
                        txt_theLoai.Text = bllBanSach.getTheLoaifromMaTheLoai(_sach.MaTheLoai.Trim()).TenTheLoai;
                        txt_giaBan.Text = _sach.GiaBan.ToString();
                        pb_hinhAnh.Image = Image.FromFile("../Debug/Products/" + _sach.HinhAnh);
                    }
                }
                else
                {
                    DTO_Sach _sach = bllBanSach.getSachfromTenSach(txt_tenSach.Text.Trim());
                    if (_sach == null)
                        MessageBox.Show("Không tìm thấy thông tin của Sách từ Tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        txt_maSach.Text = _sach.MaSach.Trim();
                        txt_tenSach.Text = _sach.TenSach.Trim();
                        txt_tacGia.Text = _sach.TacGia.Trim();
                        txt_nxb.Text = bllBanSach.getNXBfromMaNXB(_sach.MaNXB.Trim()).TenNXB;
                        txt_theLoai.Text = bllBanSach.getTheLoaifromMaTheLoai(_sach.MaTheLoai.Trim()).TenTheLoai;
                        txt_giaBan.Text = _sach.GiaBan.ToString();
                        pb_hinhAnh.Image = Image.FromFile("../Debug/Products/" + _sach.HinhAnh);
                    }
                }
            }
        }

        private List<DTO_ChiTietHoaDonBan> _dsMua = new List<DTO_ChiTietHoaDonBan>();
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_maSach.Text.Trim() == string.Empty)
                MessageBox.Show("Chưa có thông tin Sách muốn mua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DTO_Sach _sach = bllBanSach.getSachfromMaSach(txt_maSach.Text.Trim());
                if (_sach == null)
                    MessageBox.Show("Không tìm thấy thông tin của Sách từ Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    bool checkExist = isExistInList(_dsMua, _sach.MaSach);
                    if(!checkExist)
                    {
                        if (!bllBanSach.checkSLTonKhoDapUng(_sach.MaSach, Convert.ToInt32(num_soLuongMua.Value)))
                        {
                            MessageBox.Show("Số lượng sách tồn không đủ đáp ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        _dsMua.Add(new DTO_ChiTietHoaDonBan(0, _sach.MaSach, Convert.ToInt32(num_soLuongMua.Value), _sach.GiaBan * Convert.ToInt32(num_soLuongMua.Value)));
                    }
                    else
                    {
                        foreach (DTO_ChiTietHoaDonBan hd in _dsMua)
                        {
                            if (hd.MaSach == _sach.MaSach)
                            {
                                if (!bllBanSach.checkSLTonKhoDapUng(_sach.MaSach, hd.SoLuong + Convert.ToInt32(num_soLuongMua.Value)))
                                {
                                    MessageBox.Show("Số lượng sách tồn không đủ đáp ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                hd.SoLuong = hd.SoLuong + Convert.ToInt32(num_soLuongMua.Value);
                                hd.TongTien = _sach.GiaBan * hd.SoLuong;
                            }
                        }
                    }
                    loadDSMua();
                    refreshFieldInput();
                }
            }
        }

        private bool isExistInList(List<DTO_ChiTietHoaDonBan> _dsMua, string _maSach)
        {
            foreach(DTO_ChiTietHoaDonBan hd in _dsMua)
            {
                if (hd.MaSach == _maSach)
                    return true;
            }
            return false;
        }

        private void loadDSMua()
        {
            table_qlbanhang.DataSource = null;
            table_qlbanhang.DataSource = _dsMua;
        }

        private void table_qlbanhang_SelectionChanged(object sender, EventArgs e)
        {
            if(table_qlbanhang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = table_qlbanhang.SelectedRows[0];
                DTO_Sach _sach = bllBanSach.getSachfromMaSach(selectedRow.Cells[1].Value.ToString());
                txt_maSach.Text = _sach.MaSach.Trim();
                txt_tenSach.Text = _sach.TenSach.Trim();
                txt_tacGia.Text = _sach.TacGia.Trim();
                txt_nxb.Text = bllBanSach.getNXBfromMaNXB(_sach.MaNXB.Trim()).TenNXB;
                txt_theLoai.Text = bllBanSach.getTheLoaifromMaTheLoai(_sach.MaTheLoai.Trim()).TenTheLoai;
                txt_giaBan.Text = _sach.GiaBan.ToString();
                pb_hinhAnh.Image = Image.FromFile("../Debug/Products/" + _sach.HinhAnh);
                num_soLuongMua.Value = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());
            }
        }

        private void btn_xoaHet_Click(object sender, EventArgs e)
        {
            _dsMua = new List<DTO_ChiTietHoaDonBan>();
            table_qlbanhang.DataSource = null;
            refreshFieldInput();
            pb_hinhAnh.Image = Image.FromFile("../Debug/Products/loadingPic.png");

        }

        private void btn_ktraTTUDThanhVien_Click(object sender, EventArgs e)
        {
            if(txt_UDThanhVien.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng nhập Số điện thoại của thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                DTO_ThanhVien _tv = bllBanSach.getThanhVienfromSDT(txt_UDThanhVien.Text.Trim());
                if(_tv == null)
                    MessageBox.Show("Không tìm thấy thông tin thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string _hoten = _tv.TenThanhVien.Trim();
                    int _ptgg = bllBanSach.getLoaiTVfromMaLoaiTV(_tv.MaLoaiTV.Trim()).PhanTramGiamGia;
                    MessageBox.Show("Thành viên "+_hoten + " được giảm giá: "+ _ptgg + " (%)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lb_thanhVien.Text = _hoten;
                    lbl_maTV.Text = _tv.MaTV.ToString().Trim();
                    lbl_ggTV.Text = (int.Parse(lbl_tongtien.Text) * _ptgg / 100).ToString();
                    lbl_thanhtien.Text = (int.Parse(lbl_thanhtien.Text) - int.Parse(lbl_ggTV.Text)).ToString();

                    btn_ktraTTUDThanhVien.Enabled = false;
                    txt_UDThanhVien.Enabled = false;
                }
            }
            txt_UDThanhVien.Text = "";
        }

        private void btn_ktraTTUDGiamGia_Click(object sender, EventArgs e)
        {
            if (txt_UDPhieuGiamGia.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng nhập thông tin Mã giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DTO_PhieuGiamGia _gg = bllBanSach.getPGGfromMaPGG(txt_UDPhieuGiamGia.Text.Trim());
                if (_gg == null)
                    MessageBox.Show("Không tìm thấy thông tin phiếu giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DateTime today = DateTime.Today;
                    bool checkDaySaleOf = (today.CompareTo(_gg.NgayBD) < 0 || today.CompareTo(_gg.NgayKT) > 0) ? false : true;
                    if(!checkDaySaleOf)
                        MessageBox.Show("Phiếu giảm giá không trong thời gian ưu đãi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        string _tengg = _gg.TenGiamGia.Trim();
                        int _ptgg = _gg.PhanTramGiamGia;
                        MessageBox.Show("Phiếu giảm giá " + _tengg + " được giảm giá: " + _ptgg + " (%)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lb_phieuGiamGia.Text = _tengg;
                        lbl_maGG.Text = _gg.MaGiamGia;
                        lbl_ggVC.Text = (int.Parse(lbl_tongtien.Text) * _ptgg / 100).ToString();
                        lbl_thanhtien.Text = (int.Parse(lbl_thanhtien.Text) - int.Parse(lbl_ggVC.Text)).ToString();

                        btn_ktraTTUDGiamGia.Enabled = false;
                        txt_UDPhieuGiamGia.Enabled = false;
                    }                    
                }
            }
            txt_UDPhieuGiamGia.Text = "";
        }

        private int loadTongTien(List<DTO_ChiTietHoaDonBan> _dsMua)
        {
            int tongTien = 0;
            foreach (DTO_ChiTietHoaDonBan hd in _dsMua)
            {
                tongTien += hd.TongTien;
            }
            return tongTien;
        }

        private void setTongTienLabel()
        {
            lbl_tongtien.Text = loadTongTien(_dsMua).ToString();
            lbl_thanhtien.Text = loadTongTien(_dsMua).ToString();
        }

        private void btn_TTDS_lamMoi_Click(object sender, EventArgs e)
        {
            refreshAllData();
        }

        private void refreshAllData()
        {
            lbl_tongtien.Text = "0";
            lbl_thanhtien.Text = "0";
            lbl_ggVC.Text = "0";
            lbl_ggTV.Text = "0";
            btn_ktraTTUDThanhVien.Enabled = true;
            txt_UDThanhVien.Enabled = true;
            btn_ktraTTUDGiamGia.Enabled = true;
            txt_UDPhieuGiamGia.Enabled = true;
            _dsMua = new List<DTO_ChiTietHoaDonBan>();
            table_qlbanhang.DataSource = null;
            refreshFieldInput();
            pb_hinhAnh.Image = Image.FromFile("../Debug/Products/loadingPic.png");
            lbl_maGG.Text = "None";
            lbl_maTV.Text = "1";
            lb_phieuGiamGia.Text = "Loading...";
            lb_thanhVien.Text = "Loading...";
        }

        private void btn_HoanTatThanhToan_Click(object sender, EventArgs e)
        {
            if(_dsMua.Count < 1)
                MessageBox.Show("Chưa chọn mua bất kì Sách nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (!bllBanSach.checkSLTonKho(_dsMua))
                    MessageBox.Show("Số lượng sách tồn không đủ đáp ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận hoàn tất thanh toán: " + lbl_thanhtien.Text + " đ ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.Yes)
                    {
                        DateTime today = DateTime.Today;

                        bool storeHDB = bllBanSach.storeHDBanSach(new DTO_HoaDonBan(
                                0,
                                today,
                                int.Parse(lbl_tongtien.Text),
                                int.Parse(lbl_ggTV.Text) + int.Parse(lbl_ggVC.Text),
                                int.Parse(lbl_thanhtien.Text),
                                int.Parse(lbl_maTV.Text),
                                lbl_maGG.Text,
                                this.maTKDN
                        ));

                        if(lbl_maTV.Text.Trim() != "1")
                        {
                            bllBanSach.updateTienDaMuaCuaThanhVien(int.Parse(lbl_maTV.Text), int.Parse(lbl_tongtien.Text));
                        }

                        int soHDnewStore = bllBanSach.getSoHDnewStore();

                        foreach (DTO_ChiTietHoaDonBan hd in _dsMua)
                            hd.SoHD = soHDnewStore;

                        bool storeCTHDB = bllBanSach.storeCTHDBanSach(_dsMua);
                        bool updateSLT = bllBanSach.updateSoLuongTon(_dsMua);                        

                        if (storeCTHDB && storeHDB && updateSLT)
                        {
                            MessageBox.Show("Tạo hóa đơn mua hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshAllData();
                        }
                        else
                            MessageBox.Show("Lỗi trong quá trình thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            int soHDRP = bllXHD.getSoHDXuatHoaDon();
            Frm_CrystalReportHoaDon frmRP = new Frm_CrystalReportHoaDon(soHDRP);
            frmRP.Show();
        }
    }
}
