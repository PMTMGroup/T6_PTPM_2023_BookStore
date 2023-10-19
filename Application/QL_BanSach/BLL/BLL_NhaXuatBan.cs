using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_NhaXuatBan
    {
        private DAL_NhaXuatBan nxbDAL = new DAL_NhaXuatBan();

        public List<DTO_NhaXuatBan> GetAllNXBs()
        {
            return nxbDAL.GetAllNXBs();
        }

        public bool insertNXB(string maNXB, string tenNXB)
        {
            var newNXB = new DTO_NhaXuatBan
            {
                MaNXB = maNXB,
                TenNXB = tenNXB
            };

            return nxbDAL.insertNXB(newNXB);
        }

        public bool deleteNXB(string maNXB)
        {
            return nxbDAL.deleteNXB(maNXB);
        }

        public bool updateNXB(string maNXB, string tenNXB)
        {
            var newNXB = new DTO_NhaXuatBan
            {
                MaNXB = maNXB,
                TenNXB = tenNXB
            };

            return nxbDAL.updateNXB(newNXB);
        }

        public bool checkPrimaryKey(string maNXB)
        {
            return nxbDAL.checkPrimaryKey(maNXB);
        }

        public bool checkForeignKey(string maNXB)
        {
            return nxbDAL.checkForeignKey(maNXB);
        }
    }
}
