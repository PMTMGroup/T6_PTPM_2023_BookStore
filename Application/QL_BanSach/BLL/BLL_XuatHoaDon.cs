using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_XuatHoaDon
    {
        DAL_XuatHoaDon dalXHD = new DAL_XuatHoaDon();

        public void insertTableXuatHoaDon(int soHD)
        {
            dalXHD.insertTableXuatHoaDon(soHD);
        }

        public void deleteTableXuatHoaDon()
        {
            dalXHD.deleteTableXuatHoaDon();
        }

        public int getSoHDXuatHoaDon()
        {
            return dalXHD.getSoHDXuatHoaDon();
        }
    }
}
