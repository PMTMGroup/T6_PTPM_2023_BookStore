using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Sach
    {
        DBConnection db = new DBConnection();
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

        public DTO_NhaXuatBan getNXBfromMaNXB(string maNXB)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                NhaXuatBan _nxb = context.NhaXuatBans.FirstOrDefault(s => s.MaNXB == maNXB);
                return new DTO_NhaXuatBan(_nxb.MaNXB, _nxb.TenNXB);
            }
        }

        public DTO_TheLoaiSach getTheLoaifromMaTheLoai(string maTheLoai)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                TheLoaiSach _tl = context.TheLoaiSaches.FirstOrDefault(s => s.MaTheLoai == maTheLoai);
                return new DTO_TheLoaiSach(_tl.MaTheLoai, _tl.TenTheLoai);
            }
        }

        public DTO_Tang getTangfromMaTang(string maTang)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                Tang _tl = context.Tangs.FirstOrDefault(s => s.MaTang == maTang);
                return new DTO_Tang(_tl.MaTang, _tl.TenTang);
            }
        }

        public DTO_KeDat getKetDatfromMaKe(string maKeDat)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                KeDat _kd = context.KeDats.FirstOrDefault(s => s.MaKe == maKeDat);
                return new DTO_KeDat(_kd.MaKe, _kd.TenKe);
            }
        }

        public bool checkPrimaryKey(string maSach)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Saches.Any(s => s.MaSach == maSach);
            }
        }

        public bool checkForeignKey(string maSach)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                bool fkCTDDH = context.ChiTietDonDatHangs.Any(s => s.MaSach == maSach);
                bool fkCTHDB = context.ChiTietHoaDonBans.Any(s => s.MaSach == maSach);
                bool fkCTHDK = context.ChiTietHoaDonKhos.Any(s => s.MaSach == maSach);
                bool fkGH = context.GioHangs.Any(s => s.MaSach == maSach);

                if (!fkCTDDH && !fkCTHDB && !fkCTHDK && !fkGH)
                    return false;
                return true;
            }
        }

        public DTO_NhaXuatBan getNXBfromTenNXB(string tenNXB)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                NhaXuatBan _nxb = context.NhaXuatBans.FirstOrDefault(s => s.TenNXB == tenNXB);
                return new DTO_NhaXuatBan(_nxb.MaNXB, _nxb.TenNXB);
            }
        }

        public DTO_TheLoaiSach getTheLoaifromTenTheLoai(string tenTheLoai)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                TheLoaiSach _tl = context.TheLoaiSaches.FirstOrDefault(s => s.TenTheLoai == tenTheLoai);
                return new DTO_TheLoaiSach(_tl.MaTheLoai, _tl.TenTheLoai);
            }
        }

        public DTO_Tang getTangfromTenTang(string tenTang)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                Tang _tl = context.Tangs.FirstOrDefault(s => s.TenTang == tenTang);
                return new DTO_Tang(_tl.MaTang, _tl.TenTang);
            }
        }

        public DTO_KeDat getKetDatfromTenKe(string tenKeDat)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                KeDat _kd = context.KeDats.FirstOrDefault(s => s.TenKe == tenKeDat);
                return new DTO_KeDat(_kd.MaKe, _kd.TenKe);
            }
        }

        public bool insertSach(DTO_Sach s)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    Sach sach = new Sach
                    {
                        MaSach = s.MaSach,
                        TenSach = s.TenSach,
                        TacGia = s.TacGia,
                        SoTrang = s.SoTrang,
                        GiaBan = s.GiaBan,
                        SoLuongTon = s.SoLuongTon,
                        MaTheLoai = s.MaTheLoai,
                        MaNXB = s.MaNXB,
                        MaTang = s.MaTang,
                        MaKe = s.MaKe,
                        HinhAnh = s.HinhAnh
                    };
                    context.Saches.InsertOnSubmit(sach);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool updateSach(DTO_Sach s)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    Sach sach = context.Saches.Where(_s => _s.MaSach == s.MaSach).FirstOrDefault();

                    sach.TenSach = s.TenSach;
                    sach.TacGia = s.TacGia;
                    sach.SoTrang = s.SoTrang;
                    sach.GiaBan = s.GiaBan;
                    sach.SoLuongTon = s.SoLuongTon;
                    sach.MaTheLoai = s.MaTheLoai;
                    sach.MaNXB = s.MaNXB;
                    sach.MaTang = s.MaTang;
                    sach.MaKe = s.MaKe;
                    sach.HinhAnh = s.HinhAnh;

                    context.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteSach(string maSach)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    Sach sach = context.Saches.Where(_s => _s.MaSach == maSach).FirstOrDefault();

                    context.Saches.DeleteOnSubmit(sach);
                    context.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public int soPhatSinhMaSachCuoiCung()
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    string _maSach = context.Saches.OrderByDescending(s => s.MaSach).Select(s => s.MaSach).FirstOrDefault();
                    return Int32.Parse(_maSach.Substring(1)) + 1;
                }
            }
            catch
            {
                return 1;
            }
        }
    }
}
