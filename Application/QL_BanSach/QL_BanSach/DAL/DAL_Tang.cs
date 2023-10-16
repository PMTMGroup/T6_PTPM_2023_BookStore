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
    }
}
