using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_HoaDonBan
    {
        private DAL_HoaDonBan hoadonbanDAL = new DAL_HoaDonBan();

        public List<DTO_HoaDonBan> GetAllHoaDonBan()
        {
            return hoadonbanDAL.GetAllHoaDonBan();
        }
        public DTO_HoaDonBan GetHoaDonBanFromSHD(int soHD)
        {
            return hoadonbanDAL.GetHoaDonBanFromSHD(soHD);
        }
        public List<DTO_HoaDonBan> GetHoaDonBanFromNguoiLap(string nguoiLap)
        {
            return hoadonbanDAL.GetHoaDonBanFromNguoiLap(nguoiLap);
        }

    }
}
