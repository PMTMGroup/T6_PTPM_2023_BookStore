using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_TheLoaiSach
    {
        DBConnection db = new DBConnection();
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

        public bool insertTheLoaiSach(DTO_TheLoaiSach _theloaisach)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newTheLoaiSach = new TheLoaiSach
                    {
                        MaTheLoai = _theloaisach.MaTheLoai,
                        TenTheLoai = _theloaisach.TenTheLoai
                    };

                    context.TheLoaiSaches.InsertOnSubmit(newTheLoaiSach);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteTheLoaiSach(string maTheLoai)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var theloaisachDelete = context.TheLoaiSaches.SingleOrDefault(s => s.MaTheLoai == maTheLoai);

                    if (theloaisachDelete != null)
                    {
                        context.TheLoaiSaches.DeleteOnSubmit(theloaisachDelete);
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

        public bool updateTheLoaiSach(DTO_TheLoaiSach _theloaisach)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var theloaisachUpdate = context.TheLoaiSaches.SingleOrDefault(s => s.MaTheLoai == _theloaisach.MaTheLoai);

                    if (theloaisachUpdate != null)
                    {
                        theloaisachUpdate.TenTheLoai = _theloaisach.TenTheLoai;
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

        public bool checkPrimaryKey(string maTheLoai)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.TheLoaiSaches.Any(s => s.MaTheLoai == maTheLoai);
            }
        }

        public bool checkForeignKey(string maTheLoai)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Saches.Any(s => s.MaTheLoai == maTheLoai);
            }
        }
    }

}
