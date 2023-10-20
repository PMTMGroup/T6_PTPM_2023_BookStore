using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_KeDat
    {
        private DAL_KeDat kedatDAL = new DAL_KeDat();

        public List<DTO_KeDat> GetAllKeDats()
        {
            return kedatDAL.GetAllKeDats();
        }

        public bool insertKeDat(string maKe, string tenKe)
        {
            var newKeDat = new DTO_KeDat
            {
                MaKe = maKe,
                TenKe = tenKe
            };

            return kedatDAL.insertKeDat(newKeDat);
        }

        public bool deleteKeDat(string maKe)
        {
            return kedatDAL.deleteKeDat(maKe);
        }

        public bool updateKeDat(string maKe, string tenKe)
        {
            var newKeDat = new DTO_KeDat
            {
                MaKe = maKe,
                TenKe = tenKe
            };

            return kedatDAL.updateKeDat(newKeDat);
        }

        public bool checkPrimaryKey(string maKe)
        {
            return kedatDAL.checkPrimaryKey(maKe);
        }

        public bool checkForeignKey(string maKe)
        {
            return kedatDAL.checkForeignKey(maKe);
        }

    }
}
