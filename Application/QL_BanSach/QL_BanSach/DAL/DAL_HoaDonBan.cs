using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HoaDonBan
    {
        private DBConnection db = new DBConnection();

        public List<DTO_HoaDonBan> GetAllHoaDonBan()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = from hdb in context.HoaDonBans
                            select new DTO_HoaDonBan
                            {
                                SoHD = hdb.SoHD,
                                NgayLap = (DateTime)hdb.NgayLap,
                                TongTien = (int)hdb.TongTien,
                                TongGiam = (int)hdb.TongGiam,
                                ThanhTien = (int)hdb.ThanhTien,
                                MaTV = (int)hdb.MaTV,
                                MaGiamGia = hdb.MaGiamGia,
                                MaTaiKhoan = hdb.MaTaiKhoan
                            };

                return query.ToList();
            }
        }
        public DTO_HoaDonBan GetHoaDonBanFromSHD(int soHD)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                HoaDonBan hoaDonBan = context.HoaDonBans.FirstOrDefault(hdb => hdb.SoHD == soHD);
                if (hoaDonBan != null)
                {
                    return new DTO_HoaDonBan
                    {
                        SoHD = hoaDonBan.SoHD,
                        NgayLap = (DateTime)hoaDonBan.NgayLap,
                        TongTien = (int)hoaDonBan.TongTien,
                        TongGiam = (int)hoaDonBan.TongGiam,
                        ThanhTien = (int)hoaDonBan.ThanhTien,
                        MaTV = (int)hoaDonBan.MaTV,
                        MaGiamGia = hoaDonBan.MaGiamGia,
                        MaTaiKhoan = hoaDonBan.MaTaiKhoan
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public List<DTO_HoaDonBan> GetHoaDonBanFromNguoiLap(string nguoiLap)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var hoaDonBans = context.HoaDonBans.Where(hdb => hdb.MaTaiKhoan == nguoiLap).Select(hdb => new DTO_HoaDonBan
                {
                    SoHD = hdb.SoHD,
                    NgayLap = (DateTime)hdb.NgayLap,
                    TongTien = (int)hdb.TongTien,
                    TongGiam = (int)hdb.TongGiam,
                    ThanhTien = (int)hdb.ThanhTien,
                    MaTV = (int)hdb.MaTV,
                    MaGiamGia = hdb.MaGiamGia,
                    MaTaiKhoan = hdb.MaTaiKhoan
                }).ToList();

                return hoaDonBans;
            }
        }

        public List<DTO_HoaDonBan> GetHoaDonBanFromThanhVien(int maTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var hoaDonBans = context.HoaDonBans.Where(hdb => hdb.MaTV == maTV).Select(hdb => new DTO_HoaDonBan
                {
                    SoHD = hdb.SoHD,
                    NgayLap = (DateTime)hdb.NgayLap,
                    TongTien = (int)hdb.TongTien,
                    TongGiam = (int)hdb.TongGiam,
                    ThanhTien = (int)hdb.ThanhTien,
                    MaTV = (int)hdb.MaTV,
                    MaGiamGia = hdb.MaGiamGia,
                    MaTaiKhoan = hdb.MaTaiKhoan
                }).ToList();

                return hoaDonBans;
            }
        }

        public List<DTO_HoaDonBan> GetHoaDonBanFromNgayLap(DateTime dateLap)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var hoaDonBans = context.HoaDonBans.Where(hdb => hdb.NgayLap == dateLap).Select(hdb => new DTO_HoaDonBan
                {
                    SoHD = hdb.SoHD,
                    NgayLap = (DateTime)hdb.NgayLap,
                    TongTien = (int)hdb.TongTien,
                    TongGiam = (int)hdb.TongGiam,
                    ThanhTien = (int)hdb.ThanhTien,
                    MaTV = (int)hdb.MaTV,
                    MaGiamGia = hdb.MaGiamGia,
                    MaTaiKhoan = hdb.MaTaiKhoan
                }).ToList();

                return hoaDonBans;
            }
        }

        public List<DTO_ChiTietHoaDonBan> GetCTHoaDonBanFromSoHD(int soHDB)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var CThoaDonBans = context.ChiTietHoaDonBans.Where(hdb => hdb.SoHD == soHDB).Select(hdb => new DTO_ChiTietHoaDonBan
                {
                    SoHD = hdb.SoHD,
                    MaSach = hdb.MaSach,
                    SoLuong = (int)hdb.SoLuong,
                    TongTien = (int)hdb.TongTien
                }).ToList();

                return CThoaDonBans;
            }
        }
    }
}
