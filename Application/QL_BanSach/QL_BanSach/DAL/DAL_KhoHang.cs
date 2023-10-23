using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KhoHang
    {
        DBConnection db = new DBConnection();

        public List<DTO_HoaDonKho> GetAllHoaDonKho()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = from hdb in context.HoaDonKhos
                            select new DTO_HoaDonKho
                            {
                                SoHDK = hdb.SoHDK,
                                NgayLap = (DateTime)hdb.NgayLap,
                                TongTien = (int)hdb.TongTien,
                                GhiChu = hdb.GhiChu,
                                MaLoaiHD = hdb.MaLoaiHD,
                                MaTaiKhoan = hdb.MaTaiKhoan
                            };

                return query.ToList();
            }
        }

        public List<DTO_HoaDonKho> GetDSHoaDonKhoTheoLoai(string loaiHDK)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                if(loaiHDK == "ALL")
                {
                    var queryALL = from hdb in context.HoaDonKhos
                                select new DTO_HoaDonKho
                                {
                                    SoHDK = hdb.SoHDK,
                                    NgayLap = (DateTime)hdb.NgayLap,
                                    TongTien = (int)hdb.TongTien,
                                    GhiChu = hdb.GhiChu,
                                    MaLoaiHD = hdb.MaLoaiHD,
                                    MaTaiKhoan = hdb.MaTaiKhoan
                                };

                    return queryALL.ToList();
                }
                else
                {                                   
                    var query = context.HoaDonKhos.Where(hd => hd.MaLoaiHD == loaiHDK).ToList();
                    List<DTO_HoaDonKho> ds = new List<DTO_HoaDonKho>();
                    foreach(HoaDonKho hdb in query)
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
        }
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
        public List<DTO_Sach> getListSachTheoSoLuongTon(int slTon)
        {
            List<DTO_Sach> list = new List<DTO_Sach>();
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<Sach> arr = context.Saches.Where(s => s.SoLuongTon < slTon).ToList();
                if(arr.Count < 1)
                {
                    return null;
                }

                foreach (Sach s in arr)
                {
                    list.Add(new DTO_Sach {
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
                    });
                }
            }
            return list;
        }

        public bool storeHDKho(DTO_HoaDonKho hdk)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    HoaDonKho _newHDB = new HoaDonKho
                    {
                        TongTien = hdk.TongTien,
                        NgayLap = hdk.NgayLap,
                        GhiChu = hdk.GhiChu,
                        MaTaiKhoan = hdk.MaTaiKhoan,
                        MaLoaiHD = hdk.MaLoaiHD
                    };
                    context.HoaDonKhos.InsertOnSubmit(_newHDB);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool storeCTHDKho(List<DTO_ChiTietHoaDonKho> _ds)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    foreach (DTO_ChiTietHoaDonKho hd in _ds)
                    {
                        ChiTietHoaDonKho _newCTHDB = new ChiTietHoaDonKho
                        {
                            SoHDK = hd.SoHDK,
                            MaSach = hd.MaSach,
                            SoLuong = hd.SoLuong,
                            Gia = hd.Gia
                        };
                        context.ChiTietHoaDonKhos.InsertOnSubmit(_newCTHDB);
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

        public int getSoHDKnewStore()
        {
            int soHD = 0;
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<DTO_HoaDonKho> ds = context.HoaDonKhos.Select(hdk => new DTO_HoaDonKho
                {
                    SoHDK = (int)hdk.SoHDK,
                    TongTien = (int)hdk.TongTien,
                    NgayLap = (DateTime)hdk.NgayLap,
                    GhiChu = hdk.GhiChu,
                    MaTaiKhoan = hdk.MaTaiKhoan,
                    MaLoaiHD = hdk.MaLoaiHD                    
                }).ToList();

                foreach (DTO_HoaDonKho hd in ds)
                {
                    soHD = hd.SoHDK;
                }
            }
            return soHD;
        }

        public bool updateSoLuongTon(string loaiHDK, List<DTO_ChiTietHoaDonKho> _ds)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    if (loaiHDK == "Nhập kho")
                    {
                        foreach (DTO_ChiTietHoaDonKho hd in _ds)
                        {
                            var _sach = context.Saches.SingleOrDefault(s => s.MaSach == hd.MaSach);
                            if (_sach != null)
                            {
                                _sach.SoLuongTon += hd.SoLuong;
                                context.SubmitChanges();
                            }
                        }
                    }
                    else
                    {
                        foreach (DTO_ChiTietHoaDonKho hd in _ds)
                        {
                            var _sach = context.Saches.SingleOrDefault(s => s.MaSach == hd.MaSach);
                            if (_sach != null)
                            {
                                _sach.SoLuongTon -= hd.SoLuong;
                                context.SubmitChanges();
                            }
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

        public bool checkXuatKho(List<DTO_ChiTietHoaDonKho> _ds)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                foreach (DTO_ChiTietHoaDonKho hd in _ds)
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

        public List<DTO_ChiTietHoaDonKho> getDSCTHDKfromSoHD(int sohdk)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<DTO_ChiTietHoaDonKho> ds = new List<DTO_ChiTietHoaDonKho>();
                var list = context.ChiTietHoaDonKhos.Where(s => s.SoHDK == sohdk).ToList();
                foreach(ChiTietHoaDonKho hd in list)
                {
                    ds.Add(new DTO_ChiTietHoaDonKho(
                        hd.SoHDK, hd.MaSach, (int)hd.SoLuong, (int)hd.Gia
                        ));
                }

                return ds;
            }
        }
    }
}
