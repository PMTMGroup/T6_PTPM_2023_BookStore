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
using DemoBuoi7;

namespace Frm_DangNhap
{
    public partial class Frm_ThongKe : Form
    {
        BLL_ThongKe bllThongKe = new BLL_ThongKe();

        private string maTKDN;
        public Frm_ThongKe(string maTKDN)
        {
            InitializeComponent();
            this.maTKDN = maTKDN;

            if (bllThongKe.getMaQuyenfromMaTaiKhoan(this.maTKDN) == "user")
            {
                Label[] list = new Label[]{
                    lb_tongTienBanSach,lb_tongTienXuatKho,lb_tongTienNhapSach,lb_tongLoiNhuan,lb_tongDauSach,lb_tongSachTon,lb_soLuongNhanVien,lb_tongDonDatHang, lb_soDonHangThanhCong,lb_soDonHangThatBai,lb_soLuongThanhVien,lb_soLuongBanSach
                };
                foreach (Label l in list)
                    l.Text = string.Empty;
                btn_XuatBaoCao.Enabled = false;
            }

            else
            {
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
        public Frm_ThongKe()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string tenNguoiLap = bllThongKe.getTaiKhoanfromMaTaiKhoan(maTKDN).TenDangNhap.Trim();
            string dayNow = DateTime.Today.Day.ToString();
            string monthNow = DateTime.Today.Month.ToString();
            string yearNow = DateTime.Today.Year.ToString();

            WordExport export = new WordExport();
            export.XuatBaoCaoThongKe(dayNow, monthNow, yearNow, tenNguoiLap, lb_tongTienBanSach.Text,
                lb_tongTienXuatKho.Text, lb_tongTienNhapSach.Text, lb_tongLoiNhuan.Text, lb_tongDauSach.Text,
                lb_tongSachTon.Text, lb_soLuongBanSach.Text, lb_tongDonDatHang.Text, lb_soDonHangThanhCong.Text,
                lb_soDonHangThatBai.Text, lb_soLuongNhanVien.Text, lb_soLuongThanhVien.Text);
        }
    }
}
