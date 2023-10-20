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
    }
}
