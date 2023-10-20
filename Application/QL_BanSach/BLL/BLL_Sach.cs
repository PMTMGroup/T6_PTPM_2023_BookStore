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
    }
}
