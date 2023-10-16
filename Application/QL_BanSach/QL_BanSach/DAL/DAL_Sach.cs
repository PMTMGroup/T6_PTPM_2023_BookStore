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
    }
}
