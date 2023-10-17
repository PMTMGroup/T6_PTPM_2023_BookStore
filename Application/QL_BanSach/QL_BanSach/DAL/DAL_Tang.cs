using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Linq;

namespace DAL
{
    public class DAL_Tang
    {
        DBConnection db = new DBConnection();
        public List<DTO_Tang> GetAllTangs()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Tangs.Select(s => new DTO_Tang
                {
                    MaTang = s.MaTang,
                    TenTang = s.TenTang
                }).ToList();
            }
        }

        public bool insertTang(DTO_Tang _tang)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newTang = new Tang
                    {
                        MaTang = _tang.MaTang,
                        TenTang = _tang.TenTang
                    };

                    context.Tangs.InsertOnSubmit(newTang);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteTang(string maTang)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var tangDelete = context.Tangs.SingleOrDefault(s => s.MaTang == maTang);

                    if (tangDelete != null)
                    {
                        context.Tangs.DeleteOnSubmit(tangDelete);
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

        public bool updateTang(DTO_Tang _tang)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var tangUpdate = context.Tangs.SingleOrDefault(s => s.MaTang == _tang.MaTang);

                    if (tangUpdate != null)
                    {
                        tangUpdate.TenTang = _tang.TenTang;
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

        public bool checkPrimaryKey(string maTang)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Tangs.Any(s => s.MaTang == maTang);
            }
        }

        public bool checkForeignKey(string maTang)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Saches.Any(s => s.MaTang == maTang);
            }
        }
    }
}
