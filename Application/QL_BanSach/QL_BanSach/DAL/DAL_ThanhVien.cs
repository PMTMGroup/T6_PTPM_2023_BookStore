using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_ThanhVien
    {
        private DBConnection db = new DBConnection();

        public List<DTO_ThanhVien> GetAllThanhVien()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var query = from tv in context.ThanhViens
                            join ltv in context.LoaiThanhViens on tv.MaLoaiTV equals ltv.MaLoaiTV
                            select new DTO_ThanhVien
                            {
                                MaTV = tv.MaTV,
                                TenThanhVien = tv.TenThanhVien,
                                SDT = tv.SDT,
                                MatKhau = tv.MatKhau,
                                TienDaMua = (int)tv.TienDaMua,
                                MaLoaiTV = ltv.TenLoaiTV // Lấy tên loại thành viên thay vì mã
                            };

                return query.ToList();
            }
        }


        public bool InsertThanhVien(DTO_ThanhVien thanhVien)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newThanhVien = new ThanhVien
                    {
                        MaTV = thanhVien.MaTV,
                        TenThanhVien = thanhVien.TenThanhVien,
                        SDT = thanhVien.SDT,
                        MatKhau = thanhVien.MatKhau,
                        TienDaMua = thanhVien.TienDaMua,
                        MaLoaiTV = thanhVien.MaLoaiTV
                    };

                    context.ThanhViens.InsertOnSubmit(newThanhVien);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteThanhVien(int maTV)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var thanhVienDelete = context.ThanhViens.SingleOrDefault(s => s.MaTV == maTV);

                    if (thanhVienDelete != null)
                    {
                        context.ThanhViens.DeleteOnSubmit(thanhVienDelete);
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

        public bool UpdateThanhVien(DTO_ThanhVien thanhVien)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var thanhVienUpdate = context.ThanhViens.SingleOrDefault(s => s.MaTV == thanhVien.MaTV);

                    if (thanhVienUpdate != null)
                    {
                        thanhVienUpdate.TenThanhVien = thanhVien.TenThanhVien;
                        thanhVienUpdate.SDT = thanhVien.SDT;
                        thanhVienUpdate.MatKhau = thanhVien.MatKhau;
                        thanhVienUpdate.TienDaMua = thanhVien.TienDaMua;
                        thanhVienUpdate.MaLoaiTV = thanhVien.MaLoaiTV;
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

        public bool CheckPrimaryKey(int maTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.ThanhViens.Any(s => s.MaTV == maTV);
            }
        }

        public bool CheckForeignKey(int maTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                bool fkHDB = context.HoaDonBans.Any(s => s.MaTV == maTV);
                bool fkDDH = context.DonDatHangs.Any(s => s.MaTV == maTV);
                if (!fkHDB && !fkDDH)
                    return false;
                return true;
            }
        }
    }
}
