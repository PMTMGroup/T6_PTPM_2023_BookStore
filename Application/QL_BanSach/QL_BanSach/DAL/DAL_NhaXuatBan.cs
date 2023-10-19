using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhaXuatBan
    {
        DBConnection db = new DBConnection();
        public List<DTO_NhaXuatBan> GetAllNXBs()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.NhaXuatBans.Select(s => new DTO_NhaXuatBan
                {
                    MaNXB = s.MaNXB,
                    TenNXB = s.TenNXB
                }).ToList();
            }
        }

        public bool insertNXB(DTO_NhaXuatBan _nxb)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var newNXB = new NhaXuatBan
                    {
                        MaNXB = _nxb.MaNXB,
                        TenNXB = _nxb.TenNXB
                    };

                    context.NhaXuatBans.InsertOnSubmit(newNXB);
                    context.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNXB(string maNXB)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var nxbDelete = context.NhaXuatBans.SingleOrDefault(s => s.MaNXB == maNXB);

                    if (nxbDelete != null)
                    {
                        context.NhaXuatBans.DeleteOnSubmit(nxbDelete);
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

        public bool updateNXB(DTO_NhaXuatBan _nxb)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var nxbUpdate = context.NhaXuatBans.SingleOrDefault(s => s.MaNXB == _nxb.MaNXB);

                    if (nxbUpdate != null)
                    {
                        nxbUpdate.TenNXB  = _nxb.TenNXB;
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

        public bool checkPrimaryKey(string maNXB)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.NhaXuatBans.Any(s => s.MaNXB == maNXB);
            }
        }

        public bool checkForeignKey(string maNXB)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.Saches.Any(s => s.MaNXB == maNXB);
            }
        }
    }
}
