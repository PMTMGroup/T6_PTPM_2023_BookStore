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
    }
}
