using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TimKiemSanPham
    {
        DBConnection db = new DBConnection();
        public List<DTO_NhaXuatBan> GetAllNXBs()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.NhaXuatBans.Select(s => new DTO_NhaXuatBan
                {
                    MaNXB = s.MaNXB,
                    TenNXB = s.TenNXB
                }).ToList();
            }
        }

        public List<DTO_TheLoaiSach> GetAllTheLoaiSachs()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.TheLoaiSaches.Select(s => new DTO_TheLoaiSach
                {
                    MaTheLoai = s.MaTheLoai,
                    TenTheLoai = s.TenTheLoai
                }).ToList();
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

        public DTO_Sach getSachfromTenSach(string tenSach)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                Sach _sach = context.Saches.FirstOrDefault(s => s.TenSach == tenSach);
                if (_sach != null)
                    return new DTO_Sach(_sach.MaSach, _sach.TenSach, _sach.TacGia, (int)_sach.SoTrang, (int)_sach.GiaBan
                    , (int)_sach.SoLuongTon, _sach.MaTheLoai, _sach.MaNXB, _sach.MaTang, _sach.MaKe, _sach.HinhAnh);
                return null;
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

        public List<DTO_Sach> getListSachfromTacGia(string tenTG)
        {
            List<DTO_Sach> list = new List<DTO_Sach>();
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<Sach> ds = context.Saches.Where(s => s.TacGia == tenTG).ToList();
                if (ds.Count < 1)
                    return null;
                else
                {
                    foreach(Sach s in ds)
                    {
                        list.Add(new DTO_Sach
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
                        });
                    }
                }
                return list;
            }
        }

        public List<DTO_Sach> getListSachfromMaNXB(string maNXB)
        {
            List<DTO_Sach> list = new List<DTO_Sach>();
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<Sach> ds = context.Saches.Where(s => s.MaNXB == maNXB).ToList();
                if (ds.Count < 1)
                    return null;
                else
                {
                    foreach (Sach s in ds)
                    {
                        list.Add(new DTO_Sach
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
                        });
                    }
                }
                return list;
            }
        }

        public List<DTO_Sach> getListSachfromMaTheLoai(string maTL)
        {
            List<DTO_Sach> list = new List<DTO_Sach>();
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<Sach> ds = context.Saches.Where(s => s.MaTheLoai == maTL).ToList();
                if (ds.Count < 1)
                    return null;
                else
                {
                    foreach (Sach s in ds)
                    {
                        list.Add(new DTO_Sach
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
                        });
                    }
                }
                return list;
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
    }
}
