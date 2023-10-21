using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_PhieuGiamGia
    {
        private DBConnection db = new DBConnection();

        public List<DTO_PhieuGiamGia> GetAllPhieuGiamGia()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.PhieuGiamGias.Select(s => new DTO_PhieuGiamGia
                {
                    MaGiamGia = s.MaGiamGia,
                    TenGiamGia = s.TenGiamGia,
                    PhanTramGiamGia = (int)s.PhanTramGiamGia,
                    NgayBD = (DateTime)s.NgayBD,
                    NgayKT = (DateTime)s.NgayKT
                }).ToList();
            }
        }

        public bool InsertPhieuGiamGia(DTO_PhieuGiamGia phieuGiamGia)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newPhieuGiamGia = new PhieuGiamGia
                    {
                        MaGiamGia = phieuGiamGia.MaGiamGia,
                        TenGiamGia = phieuGiamGia.TenGiamGia,
                        PhanTramGiamGia = phieuGiamGia.PhanTramGiamGia,
                        NgayBD = phieuGiamGia.NgayBD,
                        NgayKT = phieuGiamGia.NgayKT
                    };

                    context.PhieuGiamGias.InsertOnSubmit(newPhieuGiamGia);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePhieuGiamGia(string maGiamGia)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var phieuGiamGiaDelete = context.PhieuGiamGias.SingleOrDefault(s => s.MaGiamGia == maGiamGia);

                    if (phieuGiamGiaDelete != null)
                    {
                        context.PhieuGiamGias.DeleteOnSubmit(phieuGiamGiaDelete);
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

        public bool UpdatePhieuGiamGia(DTO_PhieuGiamGia phieuGiamGia)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var phieuGiamGiaUpdate = context.PhieuGiamGias.SingleOrDefault(s => s.MaGiamGia == phieuGiamGia.MaGiamGia);

                    if (phieuGiamGiaUpdate != null)
                    {
                        phieuGiamGiaUpdate.TenGiamGia = phieuGiamGia.TenGiamGia;
                        phieuGiamGiaUpdate.PhanTramGiamGia = phieuGiamGia.PhanTramGiamGia;
                        phieuGiamGiaUpdate.NgayBD = phieuGiamGia.NgayBD;
                        phieuGiamGiaUpdate.NgayKT = phieuGiamGia.NgayKT;
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

        public bool CheckPrimaryKey(string maGiamGia)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.PhieuGiamGias.Any(s => s.MaGiamGia == maGiamGia);
            }
        }
        public bool CheckForeignKey(string maGiamGia)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                bool fkHDB = context.HoaDonBans.Any(s => s.MaGiamGia == maGiamGia);
               
                if (!fkHDB)
                    return false;
                return true;
            }
        }
    }
}
