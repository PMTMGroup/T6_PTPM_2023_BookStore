using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_ThongKe
    {
        DBConnection db = new DBConnection();

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

        public List<DTO_HoaDonKho> GetDSHoaDonKhoTheoLoai(string loaiHDK)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = context.HoaDonKhos.Where(hd => hd.MaLoaiHD == loaiHDK).ToList();
                List<DTO_HoaDonKho> ds = new List<DTO_HoaDonKho>();
                foreach (HoaDonKho hdb in query)
                {
                    ds.Add(new DTO_HoaDonKho
                    {
                        SoHDK = hdb.SoHDK,
                        NgayLap = (DateTime)hdb.NgayLap,
                        TongTien = (int)hdb.TongTien,
                        GhiChu = hdb.GhiChu,
                        MaLoaiHD = hdb.MaLoaiHD,
                        MaTaiKhoan = hdb.MaTaiKhoan
                    });
                }
                if (ds.Count < 1)
                    return null;
                return ds;
            }
        }

        public List<DTO_DonDatHang> GetDSDonDatHangfromTrangThaiDDH(string trangThaiDDH)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<DTO_DonDatHang> listDDH = new List<DTO_DonDatHang>();
                List<DonDatHang> DDH = context.DonDatHangs.Where(s => s.TrangThaiDonHang == trangThaiDDH).ToList();
                foreach (DonDatHang s in DDH)
                {
                    listDDH.Add(new DTO_DonDatHang
                    {
                        SoHD = s.SoHD,
                        NgayLap = s.NgayLap.ToString(),
                        HinhThucThanhToan = s.HinhThucThanhToan,
                        MaTV = (int)s.MaTV,
                        MaGiamGia = s.MaGiamGia,
                        PhiShip = (int)s.PhiShip,
                        TongTien = (int)s.TongTien,
                        TongGiam = (int)s.TongGiam,
                        ThanhTien = (int)s.ThanhTien,
                        HoTenNguoiNhan = s.HoTenNguoiNhan,
                        SDTNguoiNhan = s.SDTNguoiNhan,
                        Email = s.Email,
                        DiaChiNhanHang = s.DiaChiNhanHang,
                        GhiChu = s.GhiChu,
                        TrangThaiDonHang = s.TrangThaiDonHang
                    });
                }
                return listDDH;
            }
        }

        public List<DTO_Sach> GetAllSaches()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Saches.Select(s => new DTO_Sach
                {
                    MaSach = s.MaSach,
                    TenSach = s.TenSach,
                    TacGia = s.TacGia,
                    SoTrang = (int)s.SoTrang,
                    GiaBan = (int)s.GiaBan,
                    SoLuongTon = (int)s.SoLuongTon,
                    MaTheLoai = s.MaTheLoai,
                    MaNXB = s.MaNXB,
                    MaTang = s.MaTang,
                    MaKe = s.MaKe,
                    HinhAnh = s.HinhAnh
                }).ToList();
            }
        }
        public List<DTO_TaiKhoan> GetAllTaiKhoan()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.TaiKhoans.Select(s => new DTO_TaiKhoan
                {
                    MaTaiKhoan = s.MaTaiKhoan,
                    TenDangNhap = s.TenDangNhap,
                    MatKhau = s.MatKhau,
                    HoTen = s.HoTen,
                    SDT = s.SDT,
                    MaQuyen = s.MaQuyen,
                    BiKhoa = ((bool)s.BiKhoa) ? 1 : 0
                }).ToList();
            }
        }

        public List<DTO_DonDatHang> GetAllDonDatHang()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.DonDatHangs.Select(s => new DTO_DonDatHang
                {
                    SoHD = s.SoHD,
                    NgayLap = s.NgayLap.ToString(),
                    HinhThucThanhToan = s.HinhThucThanhToan,
                    MaTV = (int)s.MaTV,
                    MaGiamGia = s.MaGiamGia,
                    PhiShip = (int)s.PhiShip,
                    TongTien = (int)s.TongTien,
                    TongGiam = (int)s.TongGiam,
                    ThanhTien = (int)s.ThanhTien,
                    HoTenNguoiNhan = s.HoTenNguoiNhan,
                    SDTNguoiNhan = s.SDTNguoiNhan,
                    Email = s.Email,
                    DiaChiNhanHang = s.DiaChiNhanHang,
                    GhiChu = s.GhiChu,
                    TrangThaiDonHang = s.TrangThaiDonHang
                }).ToList();
            }
        }

        public List<DTO_ThanhVien> GetAllThanhVien()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = from tv in context.ThanhViens
                            join ltv in context.LoaiThanhViens on tv.MaLoaiTV equals ltv.MaLoaiTV
                            select new DTO_ThanhVien
                            {
                                MaTV = tv.MaTV,
                                TenThanhVien = tv.TenThanhVien,
                                SDT = tv.SDT,
                                MatKhau = tv.MatKhau,
                                TienDaMua = (int)tv.TienDaMua,
                                MaLoaiTV = ltv.TenLoaiTV
                            };

                return query.ToList();
            }
        }

        public List<DTO_ChiTietHoaDonBan> GetAllCTHoaDonBan()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = from hdb in context.ChiTietHoaDonBans
                            select new DTO_ChiTietHoaDonBan
                            {
                                SoHD = hdb.SoHD,
                                MaSach = hdb.MaSach,
                                SoLuong = (int)hdb.SoLuong,
                                TongTien = (int)hdb.TongTien
                            };

                return query.ToList();
            }
        }

        public List<DTO_ChiTietDonDatHang> GetAllCTDDHThanhCong()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = from ddh in context.DonDatHangs
                            join ct in context.ChiTietDonDatHangs on ddh.SoHD equals ct.SoHD
                            where ddh.TrangThaiDonHang == "Đã giao hàng"
                            select new DTO_ChiTietDonDatHang(
                                ct.SoHD, ct.MaSach, (int)ct.SoLuong, (int)ct.TongTien
                            );

                return query.ToList();
            }
        }
    }
}
