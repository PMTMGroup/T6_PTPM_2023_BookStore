using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_KeDat
    {
        DBConnection db = new DBConnection();
        public List<DTO_KeDat> GetAllKeDats()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.KeDats.Select(s => new DTO_KeDat
                {
                    MaKe = s.MaKe,
                    TenKe = s.TenKe
                }).ToList();
            }
        }

        public bool insertKeDat(DTO_KeDat _kedat)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newKeDat = new KeDat
                    {
                        MaKe = _kedat.MaKe,
                        TenKe = _kedat.TenKe
                    };

                    context.KeDats.InsertOnSubmit(newKeDat);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteKeDat(string maKe)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var kedatDelete = context.KeDats.SingleOrDefault(s => s.MaKe == maKe);

                    if (kedatDelete != null)
                    {
                        context.KeDats.DeleteOnSubmit(kedatDelete);
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

        public bool updateKeDat(DTO_KeDat _kedat)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var kedatUpdate = context.KeDats.SingleOrDefault(s => s.MaKe == _kedat.MaKe);

                    if (kedatUpdate != null)
                    {
                        kedatUpdate.TenKe = _kedat.TenKe;
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

        public bool checkPrimaryKey(string maKe)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.KeDats.Any(s => s.MaKe == maKe);
            }
        }

        public bool checkForeignKey(string maKe)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Saches.Any(s => s.MaKe == maKe);
            }
        }
    }
}