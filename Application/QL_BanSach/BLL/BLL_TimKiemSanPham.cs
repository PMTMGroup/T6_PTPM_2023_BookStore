using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_TimKiemSanPham
    {
        DAL_TimKiemSanPham dalTKSP = new DAL_TimKiemSanPham();
        public List<DTO_NhaXuatBan> GetAllNXBs()
        {
            return dalTKSP.GetAllNXBs();
        }

        public List<DTO_TheLoaiSach> GetAllTheLoaiSachs()
        {
            return dalTKSP.GetAllTheLoaiSachs();
        }

        public DTO_Sach getSachfromMaSach(string maSach)
        {
            return dalTKSP.getSachfromMaSach(maSach);
        }

        public DTO_Sach getSachfromTenSach(string tenSach)
        {
            return dalTKSP.getSachfromTenSach(tenSach);
        }

        public DTO_Tang getTangfromMaTang(string maTang)
        {
            return dalTKSP.getTangfromMaTang(maTang);
        }

        public DTO_KeDat getKetDatfromMaKe(string maKeDat)
        {
            return dalTKSP.getKetDatfromMaKe(maKeDat);
        }

        public List<DTO_Sach> getListSachfromTacGia(string tenTG)
        {
            return dalTKSP.getListSachfromTacGia(tenTG);
        }
        public List<DTO_Sach> getListSachfromMaNXB(string maNXB)
        {
            return dalTKSP.getListSachfromMaNXB(maNXB);
        }

        public List<DTO_Sach> getListSachfromMaTheLoai(string maTL)
        {
            return dalTKSP.getListSachfromMaTheLoai(maTL);
        }

        public DTO_NhaXuatBan getNXBfromTenNXB(string tenNXB)
        {
            return dalTKSP.getNXBfromTenNXB(tenNXB);
        }

        public DTO_TheLoaiSach getTheLoaifromTenTheLoai(string tenTheLoai)
        {
            return dalTKSP.getTheLoaifromTenTheLoai(tenTheLoai);
        }
    }
}
