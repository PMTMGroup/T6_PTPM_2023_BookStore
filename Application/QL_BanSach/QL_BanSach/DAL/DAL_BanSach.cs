using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_BanSach
    {
        DBConnection db = new DBConnection();
        public DTO_Sach getSachfromMaSach(string maSach)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                Sach _sach = context.Saches.FirstOrDefault(s => s.MaSach == maSach);
                if (_sach != null)
                    return new DTO_Sach(_sach.MaSach, _sach.TenSach, _sach.TacGia, (int)_sach.SoTrang, (int)_sach.GiaBan
                    , (int)_sach.SoLuongTon, _sach.MaTheLoai, _sach.MaNXB, _sach.MaTang, _sach.MaKe, _sach.HinhAnh);
                return null;
            }
        }

        public DTO_Sach getSachfromTenSach(string tenSach)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                Sach _sach = context.Saches.FirstOrDefault(s => s.TenSach == tenSach);
                if(_sach != null)
                    return new DTO_Sach(_sach.MaSach, _sach.TenSach, _sach.TacGia, (int)_sach.SoTrang, (int)_sach.GiaBan
                    , (int)_sach.SoLuongTon, _sach.MaTheLoai, _sach.MaNXB, _sach.MaTang, _sach.MaKe, _sach.HinhAnh);
                return null;
            }
        }

        public DTO_ThanhVien getThanhVienfromSDT(string _sdt)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                ThanhVien _tv = context.ThanhViens.FirstOrDefault(s => s.SDT == _sdt);
                if (_tv != null)
                    return new DTO_ThanhVien((int)_tv.MaTV, _tv.TenThanhVien, _tv.SDT, _tv.MatKhau, (int)_tv.TienDaMua, _tv.MaLoaiTV);
                return null;
            }
        }

        public DTO_LoaiThanhVien getLoaiTVfromMaLoaiTV(string _maLoai)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                LoaiThanhVien _tv = context.LoaiThanhViens.FirstOrDefault(s => s.MaLoaiTV == _maLoai);
                if (_tv != null)
                    return new DTO_LoaiThanhVien(_tv.MaLoaiTV, _tv.TenLoaiTV, (int)_tv.TienCanDat, (int)_tv.PhanTramGiamGia);
                return null;
            }
        }

        public DTO_PhieuGiamGia getPGGfromMaPGG(string _magg)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                PhieuGiamGia _gg = context.PhieuGiamGias.FirstOrDefault(s => s.MaGiamGia == _magg);
                if (_gg != null)
                    return new DTO_PhieuGiamGia(_gg.MaGiamGia, _gg.TenGiamGia, (int)_gg.PhanTramGiamGia, (DateTime)_gg.NgayBD, (DateTime)_gg.NgayKT);
                return null;
            }
        }

        public bool storeHDBanSach(DTO_HoaDonBan hdb)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    HoaDonBan _newHDB = new HoaDonBan
                    {
                        NgayLap = hdb.NgayLap,
                        TongTien = hdb.TongTien,
                        TongGiam = hdb.TongGiam,
                        ThanhTien = hdb.ThanhTien,
                        MaTV = hdb.MaTV,
                        MaGiamGia = hdb.MaGiamGia,
                        MaTaiKhoan = hdb.MaTaiKhoan
                    };
                    context.HoaDonBans.InsertOnSubmit(_newHDB);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool storeCTHDBanSach(List<DTO_ChiTietHoaDonBan> _ds)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    foreach(DTO_ChiTietHoaDonBan hd in _ds)
                    {
                        ChiTietHoaDonBan _newCTHDB = new ChiTietHoaDonBan
                        {
                            SoHD = hd.SoHD,
                            MaSach = hd.MaSach,
                            SoLuong = hd.SoLuong,
                            TongTien = hd.TongTien
                        };
                        context.ChiTietHoaDonBans.InsertOnSubmit(_newCTHDB);
                        context.SubmitChanges();
                    }                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getSoHDnewStore()
        {
            int soHD = 0;
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<DTO_HoaDonBan> ds =  context.HoaDonBans.Select(s => new DTO_HoaDonBan
                {
                    SoHD = s.SoHD,
                    NgayLap = (DateTime)s.NgayLap,
                    TongGiam = (int)s.TongGiam,
                    TongTien = (int)s.TongTien,
                    ThanhTien = (int)s.ThanhTien,
                    MaTV = (int)s.MaTV,
                    MaGiamGia = s.MaGiamGia,
                    MaTaiKhoan = s.MaTaiKhoan,
                }).ToList();

                foreach(DTO_HoaDonBan hd in ds)
                {
                    soHD = hd.SoHD;
                }
            }
            return soHD;            
        }

        public bool updateSoLuongTon(List<DTO_ChiTietHoaDonBan> _ds)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {                    
                    foreach (DTO_ChiTietHoaDonBan hd in _ds)
                    {
                        var _sach = context.Saches.SingleOrDefault(s => s.MaSach == hd.MaSach);
                        if (_sach != null)
                        {
                            _sach.SoLuongTon -= hd.SoLuong;
                            context.SubmitChanges();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool checkSLTonKho(List<DTO_ChiTietHoaDonBan> _ds)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                foreach (DTO_ChiTietHoaDonBan hd in _ds)
                {
                    var _sach = context.Saches.SingleOrDefault(s => s.MaSach == hd.MaSach);
                    if (_sach.SoLuongTon < hd.SoLuong)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
