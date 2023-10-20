using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        DBConnection db = new DBConnection();
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
                    BiKhoa = ((bool)s.BiKhoa) ?1:0
                }).ToList();
            }
        }

        public DTO_Quyen getQuyenfromMaQuyen(string maQuyen)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                Quyen _quyen = context.Quyens.FirstOrDefault(s => s.MaQuyen == maQuyen);
                return new DTO_Quyen(_quyen.MaQuyen, _quyen.TenQuyen);
            }
        }

        public bool insertTaiKhoan(DTO_TaiKhoan _taiKhoan)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newTK = new TaiKhoan
                    {
                        MaTaiKhoan = _taiKhoan.MaTaiKhoan,
                        TenDangNhap = _taiKhoan.TenDangNhap,
                        MatKhau = _taiKhoan.MatKhau,
                        HoTen = _taiKhoan.HoTen,
                        SDT = _taiKhoan.SDT,
                        MaQuyen = _taiKhoan.MaQuyen,
                        BiKhoa = (_taiKhoan.BiKhoa == 1) ? true : false
                    };

                    context.TaiKhoans.InsertOnSubmit(newTK);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteTaiKhoan(string maTaiKhoan)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var tkDelete = context.TaiKhoans.SingleOrDefault(s => s.MaTaiKhoan == maTaiKhoan);

                    if (tkDelete != null)
                    {
                        context.TaiKhoans.DeleteOnSubmit(tkDelete);
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

        public bool updateTaiKhoan(DTO_TaiKhoan _taiKhoan)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var tkUpdate = context.TaiKhoans.SingleOrDefault(s => s.MaTaiKhoan == _taiKhoan.MaTaiKhoan);

                    if (tkUpdate != null)
                    {
                        tkUpdate.TenDangNhap = _taiKhoan.TenDangNhap;
                        tkUpdate.MatKhau = _taiKhoan.MatKhau;
                        tkUpdate.HoTen = _taiKhoan.HoTen;
                        tkUpdate.SDT = _taiKhoan.SDT;
                        tkUpdate.MaQuyen = _taiKhoan.MaQuyen;
                        tkUpdate.BiKhoa = (_taiKhoan.BiKhoa == 1) ? true : false;
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

        public bool checkPrimaryKey(string maTaiKhoan)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.TaiKhoans.Any(s => s.MaTaiKhoan == maTaiKhoan);
            }
        }

        public bool checkForeignKey(string maTaiKhoan)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                bool fkHDB =  context.HoaDonBans.Any(s => s.MaTaiKhoan == maTaiKhoan);
                bool fkHDK = context.HoaDonKhos.Any(s => s.MaTaiKhoan == maTaiKhoan);
                if (!fkHDB && !fkHDK)
                    return false;
                return true;
            }
        }
    }
}
