using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_LoaiThanhVien
    {
        private DBConnection db = new DBConnection();

        public List<DTO_LoaiThanhVien> GetAllLoaiThanhVien()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.LoaiThanhViens.Select(s => new DTO_LoaiThanhVien
                {
                    MaLoaiTV = s.MaLoaiTV,
                    TenLoaiTV = s.TenLoaiTV,
                    TienCanDat = (int)s.TienCanDat,
                    PhanTramGiamGia = (int)s.PhanTramGiamGia
                }).ToList();
            }
        }

        public bool InsertLoaiThanhVien(DTO_LoaiThanhVien loaiThanhVien)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newLoaiThanhVien = new LoaiThanhVien
                    {
                        MaLoaiTV = loaiThanhVien.MaLoaiTV,
                        TenLoaiTV = loaiThanhVien.TenLoaiTV,
                        TienCanDat = loaiThanhVien.TienCanDat,
                        PhanTramGiamGia = loaiThanhVien.PhanTramGiamGia
                    };

                    context.LoaiThanhViens.InsertOnSubmit(newLoaiThanhVien);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteLoaiThanhVien(string maLoaiTV)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var loaiThanhVienDelete = context.LoaiThanhViens.SingleOrDefault(s => s.MaLoaiTV == maLoaiTV);

                    if (loaiThanhVienDelete != null)
                    {
                        context.LoaiThanhViens.DeleteOnSubmit(loaiThanhVienDelete);
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

        public bool UpdateLoaiThanhVien(DTO_LoaiThanhVien loaiThanhVien)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var loaiThanhVienUpdate = context.LoaiThanhViens.SingleOrDefault(s => s.MaLoaiTV == loaiThanhVien.MaLoaiTV);

                    if (loaiThanhVienUpdate != null)
                    {
                        loaiThanhVienUpdate.TenLoaiTV = loaiThanhVien.TenLoaiTV;
                        loaiThanhVienUpdate.TienCanDat = loaiThanhVien.TienCanDat;
                        loaiThanhVienUpdate.PhanTramGiamGia = loaiThanhVien.PhanTramGiamGia;
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

        public bool CheckPrimaryKey(string maLoaiTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.LoaiThanhViens.Any(s => s.MaLoaiTV == maLoaiTV);
            }
        }
        public bool CheckForeignKey(string maLoaiTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                bool fkHDB = context.ThanhViens.Any(s => s.MaLoaiTV == maLoaiTV);  
                if (!fkHDB )
                    return false;
                return true;
            }
        }
        

    }
}


