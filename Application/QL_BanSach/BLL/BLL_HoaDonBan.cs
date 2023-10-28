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

        public List<DTO_ChiTietHoaDonBan> GetCTHoaDonBanFromSoHD(int soHDB)
        {
            return hoadonbanDAL.GetCTHoaDonBanFromSoHD(soHDB);
        }

        public List<DTO_HoaDonBan> GetHoaDonBanFromThanhVien(int maTV)
        {
            return hoadonbanDAL.GetHoaDonBanFromThanhVien(maTV);
        }

        public List<DTO_HoaDonBan> GetHoaDonBanFromNgayLap(DateTime dateLap)
        {
            return hoadonbanDAL.GetHoaDonBanFromNgayLap(dateLap);
        }
    }
}
