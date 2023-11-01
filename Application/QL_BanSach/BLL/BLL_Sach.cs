using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Sach
    {
        private DAL_Sach sachDAL = new DAL_Sach();

        public List<DTO_Sach> GetAllSaches()
        {
            return sachDAL.GetAllSaches();
        }

        public DTO_NhaXuatBan getNXBfromMaNXB(string maNXB)
        {
            return sachDAL.getNXBfromMaNXB(maNXB);
        }

        public DTO_TheLoaiSach getTheLoaifromMaTheLoai(string maTheLoai)
        {
            return sachDAL.getTheLoaifromMaTheLoai(maTheLoai);
        }

        public DTO_Tang getTangfromMaTang(string maTang)
        {
            return sachDAL.getTangfromMaTang(maTang);
        }

        public DTO_KeDat getKeDatfromMaKe(string maKe)
        {
            return sachDAL.getKetDatfromMaKe(maKe);
        }

        public bool checkPrimaryKey(string maSach)
        {
            return sachDAL.checkPrimaryKey(maSach);
        }

        public bool checkForeignKey(string maSach)
        {
            return sachDAL.checkForeignKey(maSach);
        }

        public DTO_NhaXuatBan getNXBfromTenNXB(string tenNXB)
        {
            return sachDAL.getNXBfromTenNXB(tenNXB);
        }

        public DTO_TheLoaiSach getTheLoaifromTenTheLoai(string tenTheLoai)
        {
            return sachDAL.getTheLoaifromTenTheLoai(tenTheLoai);
        }

        public DTO_Tang getTangfromTenTang(string tenTang)
        {
            return sachDAL.getTangfromTenTang(tenTang);
        }

        public DTO_KeDat getKetDatfromTenKe(string tenKeDat)
        {
            return sachDAL.getKetDatfromTenKe(tenKeDat);
        }

        public bool insertSach(DTO_Sach s)
        {
            return sachDAL.insertSach(s);
        }

        public bool updateSach(DTO_Sach s)
        {
            return sachDAL.updateSach(s);
        }

        public bool deleteSach(string maSach)
        {
            return sachDAL.deleteSach(maSach);
        }
    }
}
