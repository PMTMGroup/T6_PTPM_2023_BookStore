using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_KhoHang
    {
        DAL_KhoHang dalKhoHang = new DAL_KhoHang();
        public List<DTO_Sach> getListSachTheoSoLuongTon(int slTon)
        {
            return dalKhoHang.getListSachTheoSoLuongTon(slTon);
        }
        public DTO_Sach getSachfromMaSach(string maSach)
        {
            return dalKhoHang.getSachfromMaSach(maSach);
        }

        public bool storeHDKho(DTO_HoaDonKho hdk)
        {
            return dalKhoHang.storeHDKho(hdk);
        }

        public bool storeCTHDKho(List<DTO_ChiTietHoaDonKho> _ds)
        {
            return dalKhoHang.storeCTHDKho(_ds);
        }
        public int getSoHDKnewStore()
        {
            return dalKhoHang.getSoHDKnewStore();
        }

        public bool updateSoLuongTon(string loaiHDK, List<DTO_ChiTietHoaDonKho> _ds)
        {
           return dalKhoHang.updateSoLuongTon(loaiHDK, _ds);
        }

        public bool checkXuatKho(List<DTO_ChiTietHoaDonKho> _ds)
        {
            return dalKhoHang.checkXuatKho(_ds);
        }

        public List<DTO_HoaDonKho> GetAllHoaDonKho()
        {
            return dalKhoHang.GetAllHoaDonKho();
        }

        public List<DTO_HoaDonKho> GetDSHoaDonKhoTheoLoai(string loaiHDK)
        {
            return dalKhoHang.GetDSHoaDonKhoTheoLoai(loaiHDK);
        }

        public List<DTO_ChiTietHoaDonKho> getDSCTHDKfromSoHD(int sohdk)
        {
            return dalKhoHang.getDSCTHDKfromSoHD(sohdk);
        }
    }
}
