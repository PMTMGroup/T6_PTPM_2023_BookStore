using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_PhieuGiamGia
    {
        private DAL_PhieuGiamGia phieuGiamGiaDAL = new DAL_PhieuGiamGia();

        public List<DTO_PhieuGiamGia> GetAllPhieuGiamGia()
        {
            return phieuGiamGiaDAL.GetAllPhieuGiamGia();
        }

        public bool InsertPhieuGiamGia(string maGiamGia, string tenGiamGia, int phanTramGiamGia, DateTime ngayBD, DateTime ngayKT)
        {
            var newPhieuGiamGia = new DTO_PhieuGiamGia
            {
                MaGiamGia = maGiamGia,
                TenGiamGia = tenGiamGia,
                PhanTramGiamGia = phanTramGiamGia,
                NgayBD = ngayBD,
                NgayKT = ngayKT
            };

            return phieuGiamGiaDAL.InsertPhieuGiamGia(newPhieuGiamGia);
        }

        public bool DeletePhieuGiamGia(string maGiamGia)
        {
            return phieuGiamGiaDAL.DeletePhieuGiamGia(maGiamGia);
        }

        public bool UpdatePhieuGiamGia(string maGiamGia, string tenGiamGia, int phanTramGiamGia, DateTime ngayBD, DateTime ngayKT)
        {
            var updatedPhieuGiamGia = new DTO_PhieuGiamGia
            {
                MaGiamGia = maGiamGia,
                TenGiamGia = tenGiamGia,
                PhanTramGiamGia = phanTramGiamGia,
                NgayBD = ngayBD,
                NgayKT = ngayKT
            };

            return phieuGiamGiaDAL.UpdatePhieuGiamGia(updatedPhieuGiamGia);
        }

        public bool CheckPrimaryKey(string maGiamGia)
        {
            return phieuGiamGiaDAL.CheckPrimaryKey(maGiamGia);
        }
        public bool CheckForeignKey(string maGiamGia)
        {
            return phieuGiamGiaDAL.CheckForeignKey(maGiamGia);
        }

        public string getMaQuyenfromMaTaiKhoan(string maTK)
        {
            return phieuGiamGiaDAL.getMaQuyenfromMaTaiKhoan(maTK);
        }
    }
}
