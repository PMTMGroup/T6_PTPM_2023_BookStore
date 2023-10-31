using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DangNhap
    {
        DBConnection db = new DBConnection();
        public DTO_TaiKhoan getTaiKhoan(string tenDN, string matKhau)
        {
            using(var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var account = context.TaiKhoans.Where(s => s.TenDangNhap == tenDN).Where(s => s.MatKhau == matKhau).FirstOrDefault();
                if (account != null)
                    return new DTO_TaiKhoan { 
                        MaTaiKhoan = account.MaTaiKhoan, TenDangNhap = account.TenDangNhap, MatKhau = account.MatKhau, HoTen = account.HoTen,
                        SDT = account.SDT, MaQuyen = account.MaQuyen, BiKhoa = account.BiKhoa == true ? 1 : 0
                    };
                return null;
            }
        }
    }
}
