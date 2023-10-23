using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_ThongKe
    {
        DAL_ThongKe dalThongKe = new DAL_ThongKe();

        public int tongTienBanSach()
        {
            int total = 0;
            List<DTO_HoaDonBan> _ds = dalThongKe.GetAllHoaDonBan();
            foreach (DTO_HoaDonBan hd in _ds)
            {
                total += hd.ThanhTien;
            }
            return total;
        }

        public int tongTienSachNhapHoacXuatKho(string loaiHDK)
        {
            int total = 0;
            List<DTO_HoaDonKho> _ds = dalThongKe.GetDSHoaDonKhoTheoLoai(loaiHDK);
            if (_ds != null)
            {
                foreach (DTO_HoaDonKho hd in _ds)
                {
                    total += hd.TongTien;
                }
                return total;
            }
            return 0;
        }

        public int tongTienBanSachTrucTuyen()
        {
            int total = 0;
            List<DTO_DonDatHang> _ds = dalThongKe.GetDSDonDatHangfromTrangThaiDDH("Đã giao hàng");
            if (_ds != null)
            {
                foreach (DTO_DonDatHang hd in _ds)
                {
                    total += hd.ThanhTien;
                }
                return total;
            }
            return 0;
        }

        public int tongDauSach()
        {
            if (dalThongKe.GetAllSaches() != null)
                return dalThongKe.GetAllSaches().Count;
            return 0;
        }

        public int tongSLSachTon()
        {
            int total = 0;
            List<DTO_Sach> _ds = dalThongKe.GetAllSaches();
            foreach (DTO_Sach s in _ds)
            {
                total += s.SoLuongTon;
            }
            return total;
        }

        public int tongSLTaiKhoanNV()
        {
            if (dalThongKe.GetAllTaiKhoan() != null)
                return dalThongKe.GetAllTaiKhoan().Count;
            return 0;
        }

        public int tongSLDonDatHang()
        {
            if (dalThongKe.GetAllDonDatHang() != null)
                return dalThongKe.GetAllDonDatHang().Count;
            return 0;
        }

        public int tongSLDonHangTheoTrangThai(string trangThai)
        {
            List<DTO_DonDatHang> _ds = dalThongKe.GetDSDonDatHangfromTrangThaiDDH(trangThai);
            return _ds.Count;
        }

        public int tongSLThanhVien()
        {
            if (dalThongKe.GetAllThanhVien() != null)
                return dalThongKe.GetAllThanhVien().Count;
            return 0;
        }

        public int tongSLSachBanTaiCuaHang()
        {
            int total = 0;
            List<DTO_ChiTietHoaDonBan> _ds = dalThongKe.GetAllCTHoaDonBan();
            if (_ds != null)
            {
                foreach (DTO_ChiTietHoaDonBan s in _ds)
                {
                    total += s.SoLuong;
                }
                return total;
            }
            return 0;
        }

        public int tongSLSachBanTrucTuyen()
        {
            int total = 0;
            List<DTO_ChiTietDonDatHang> _ds = dalThongKe.GetAllCTDDHThanhCong();
            if (_ds != null)
            {
                foreach (DTO_ChiTietDonDatHang s in _ds)
                {
                    total += s.SoLuong;
                }
                return total;
            }
            return 0;
        }
    }
}
