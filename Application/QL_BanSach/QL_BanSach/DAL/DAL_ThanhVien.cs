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

        public bool CheckExistPhoneNumber(string sdt)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.ThanhViens.Any(s => s.SDT == sdt);
            }
        }

        public bool CheckForeignKey(int maTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                bool fkHDB = context.HoaDonBans.Any(s => s.MaTV == maTV);
                bool fkDDH = context.DonDatHangs.Any(s => s.MaTV == maTV);
                bool fkGioHang = context.GioHangs.Any(s => s.MaND == maTV);
                if (!fkHDB && !fkDDH && !fkGioHang)
                    return false;
                return true;
            }
        }
        public DTO_ThanhVien GetThanhVienFromSDT(string sDT)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString)) 
            {
                ThanhVien _tv = context.ThanhViens.FirstOrDefault(tv => tv.SDT == sDT);
                if (_tv != null)
                {
                   return new DTO_ThanhVien((int)_tv.MaTV, _tv.TenThanhVien, _tv.SDT, _tv.MatKhau, (int)_tv.TienDaMua, _tv.MaLoaiTV);

                }
                else
                {
                    return null; // Trả về null nếu không tìm thấy Thành viên với SDT tương ứng
                }

            }
        }

        public DTO_LoaiThanhVien GetLoaiThanhVienFromTenLoaiTV(string tenLoaiTV)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                LoaiThanhVien _tv = context.LoaiThanhViens.FirstOrDefault(tv => tv.TenLoaiTV == tenLoaiTV);
                if (_tv != null)
                {
                    return new DTO_LoaiThanhVien(_tv.MaLoaiTV, _tv.TenLoaiTV, (int)_tv.TienCanDat, (int)_tv.PhanTramGiamGia);

                }
                else
                {
                    return null; // Trả về null nếu không tìm thấy Thành viên với SDT tương ứng
                }

            }
        }

        public string getMaQuyenfromMaTaiKhoan(string maTK)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var account = context.TaiKhoans.Where(s => s.MaTaiKhoan == maTK).FirstOrDefault();
                if (account != null)
                    return account.MaQuyen;
                return null;
            }
        }
    }
}
