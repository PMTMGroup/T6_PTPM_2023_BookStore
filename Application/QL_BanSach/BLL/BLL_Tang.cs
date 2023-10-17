using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Tang
    {
        private DAL_Tang tangDAL = new DAL_Tang();

        public List<DTO_Tang> GetAllTangs()
        {
            return tangDAL.GetAllTangs();
        }

        public bool insertTang(string maTang, string tenTang)
        {
            var newTang = new DTO_Tang
            {
                MaTang = maTang,
                TenTang = tenTang
            };

            return tangDAL.insertTang(newTang);
        }

        public bool deleteTang(string maTang)
        {
            return tangDAL.deleteTang(maTang);
        }

        public bool updateTang(string maTang, string tenTang)
        {
            var newTang = new DTO_Tang
            {
                MaTang = maTang,
                TenTang = tenTang
            };

            return tangDAL.updateTang(newTang);
        }
        
        public bool checkPrimaryKey(string maTang)
        {
            return tangDAL.checkPrimaryKey(maTang);
        }

        public bool checkForeignKey(string maTang)
        {
            return tangDAL.checkForeignKey(maTang);
        }
    }
}
