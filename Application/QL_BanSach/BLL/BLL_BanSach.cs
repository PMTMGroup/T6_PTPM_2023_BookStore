using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_BanSach
    {
        DAL_BanSach dalBanSach = new DAL_BanSach();
        DAL_Sach dalSach = new DAL_Sach();
        public DTO_Sach getSachfromMaSach(string maSach)
        {
            return dalBanSach.getSachfromMaSach(maSach);
        }

        public DTO_NhaXuatBan getNXBfromMaNXB(string maNXB)
        {
            return dalSach.getNXBfromMaNXB(maNXB);
        }

        public DTO_TheLoaiSach getTheLoaifromMaTheLoai(string maTheLoai)
        {
            return dalSach.getTheLoaifromMaTheLoai(maTheLoai);
        }

        public DTO_Sach getSachfromTenSach(string tenSach)
        {
            return dalBanSach.getSachfromTenSach(tenSach);
        }

        public DTO_ThanhVien getThanhVienfromSDT(string _sdt)
        {
            return dalBanSach.getThanhVienfromSDT(_sdt);
        }

        public DTO_LoaiThanhVien getLoaiTVfromMaLoaiTV(string _maLoai)
        {
            return dalBanSach.getLoaiTVfromMaLoaiTV(_maLoai);
        }
        public DTO_PhieuGiamGia getPGGfromMaPGG(string _magg)
        {
            return dalBanSach.getPGGfromMaPGG(_magg);
        }

        public bool storeHDBanSach(DTO_HoaDonBan hdb)
        {
            return dalBanSach.storeHDBanSach(hdb);
        }

        public bool storeCTHDBanSach(List<DTO_ChiTietHoaDonBan> _ds)
        {
            return dalBanSach.storeCTHDBanSach(_ds);
        }

        public int getSoHDnewStore()
        {
            return dalBanSach.getSoHDnewStore();
        }
    }
}
