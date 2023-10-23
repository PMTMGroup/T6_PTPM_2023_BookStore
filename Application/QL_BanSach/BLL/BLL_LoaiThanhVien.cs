using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_LoaiThanhVien
    {
        private DAL_LoaiThanhVien loaiThanhVienDAL = new DAL_LoaiThanhVien();

        public List<DTO_LoaiThanhVien> GetAllLoaiThanhVien()
        {
            return loaiThanhVienDAL.GetAllLoaiThanhVien();
        }
        

        public bool InsertLoaiThanhVien(string maLoaiTV, string tenLoaiTV, int tienCanDat, int phanTramGiamGia)
        {
            var newLoaiThanhVien = new DTO_LoaiThanhVien
            {
                MaLoaiTV = maLoaiTV,
                TenLoaiTV = tenLoaiTV,
                TienCanDat = tienCanDat,
                PhanTramGiamGia = phanTramGiamGia
            };

            return loaiThanhVienDAL.InsertLoaiThanhVien(newLoaiThanhVien);
        }

        public bool DeleteLoaiThanhVien(string maLoaiTV)
        {
            return loaiThanhVienDAL.DeleteLoaiThanhVien(maLoaiTV);
        }

        public bool UpdateLoaiThanhVien(string maLoaiTV, string tenLoaiTV, int tienCanDat, int phanTramGiamGia)
        {
            var updatedLoaiThanhVien = new DTO_LoaiThanhVien
            {
                MaLoaiTV = maLoaiTV,
                TenLoaiTV = tenLoaiTV,
                TienCanDat = tienCanDat,
                PhanTramGiamGia = phanTramGiamGia
            };

            return loaiThanhVienDAL.UpdateLoaiThanhVien(updatedLoaiThanhVien);
        }

        public bool CheckPrimaryKey(string maLoaiTV)
        {
            return loaiThanhVienDAL.CheckPrimaryKey(maLoaiTV);
        }
        public bool CheckForeignKey(string maLoaiTV)
        {
            return loaiThanhVienDAL.CheckForeignKey(maLoaiTV);
        }
        

    }
}
