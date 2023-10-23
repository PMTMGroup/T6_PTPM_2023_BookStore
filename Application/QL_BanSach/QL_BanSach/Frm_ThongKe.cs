using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Frm_DangNhap
{
    public partial class Frm_ThongKe : Form
    {
        BLL_ThongKe bllThongKe = new BLL_ThongKe();
        public Frm_ThongKe()
        {
            InitializeComponent();

            double tongTienBanSach = double.Parse(bllThongKe.tongTienBanSach().ToString()) + double.Parse(bllThongKe.tongTienBanSachTrucTuyen().ToString());
            lb_tongTienBanSach.Text = string.Format("{0:#,##0}", tongTienBanSach);

            double tongTienXuatKho = double.Parse(bllThongKe.tongTienSachNhapHoacXuatKho("HDXuatKho").ToString());
            lb_tongTienXuatKho.Text = string.Format("{0:#,##0}", tongTienXuatKho);

            double tongTienNhapSach = double.Parse(bllThongKe.tongTienSachNhapHoacXuatKho("HDNhapKho").ToString());
            lb_tongTienNhapSach.Text = string.Format("{0:#,##0}", tongTienNhapSach);

            double tongLoiNhuan = tongTienBanSach + tongTienXuatKho - tongTienNhapSach;
            lb_tongLoiNhuan.Text = string.Format("{0:#,##0}", tongLoiNhuan);

            double tongDauSach = double.Parse(bllThongKe.tongDauSach().ToString());
            lb_tongDauSach.Text = string.Format("{0:#,##0}", tongDauSach);

            double tongSLTon = double.Parse(bllThongKe.tongSLSachTon().ToString());
            lb_tongSachTon.Text = string.Format("{0:#,##0}", tongSLTon);

            double tongSLTaiKhoan = double.Parse(bllThongKe.tongSLTaiKhoanNV().ToString());
            lb_soLuongNhanVien.Text = string.Format("{0:#,##0}", tongSLTaiKhoan);

            double tongSLDonDatHang = double.Parse(bllThongKe.tongSLDonDatHang().ToString());
            lb_tongDonDatHang.Text = string.Format("{0:#,##0}", tongSLDonDatHang);

            double tongSLDDHThanhCong = double.Parse(bllThongKe.tongSLDonHangTheoTrangThai("Đã giao hàng").ToString());
            lb_soDonHangThanhCong.Text = string.Format("{0:#,##0}", tongSLDDHThanhCong);

            double tongSLDDHThatBai = double.Parse(bllThongKe.tongSLDonHangTheoTrangThai("Đã từ chối").ToString());
            lb_soDonHangThatBai.Text = string.Format("{0:#,##0}", tongSLDDHThatBai);

            double tongSLThanhVien = double.Parse(bllThongKe.tongSLThanhVien().ToString());
            lb_soLuongThanhVien.Text = string.Format("{0:#,##0}", tongSLThanhVien);

            double tongSachBan = double.Parse(bllThongKe.tongSLSachBanTaiCuaHang().ToString()) + double.Parse(bllThongKe.tongSLSachBanTrucTuyen().ToString());
            lb_soLuongBanSach.Text = string.Format("{0:#,##0}", tongSachBan);
        }
    }
}
