using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

    namespace BLL
    {
        public class BLL_ThanhVien
        {
            private DAL_ThanhVien thanhVienDAL = new DAL_ThanhVien();

            public List<DTO_ThanhVien> GetAllThanhVien()
            {
                return thanhVienDAL.GetAllThanhVien();
            }

            public bool InsertThanhVien(int maTV, string tenThanhVien, string sDT, string matKhau, int tienDaMua, string maLoaiTV)
            {
                var newThanhVien = new DTO_ThanhVien
                {
                    MaTV = maTV,
                    TenThanhVien = tenThanhVien,
                    SDT = sDT,
                    MatKhau = matKhau,
                    TienDaMua = tienDaMua,
                    MaLoaiTV = maLoaiTV
                };

                return thanhVienDAL.InsertThanhVien(newThanhVien);
            }

            public bool DeleteThanhVien(int maTV)
            {
                return thanhVienDAL.DeleteThanhVien(maTV);
            }

            public bool UpdateThanhVien(int maTV, string tenThanhVien, string sDT, string matKhau, int tienDaMua, string maLoaiTV)
            {
                var updatedThanhVien = new DTO_ThanhVien
                {
                    MaTV = maTV,
                    TenThanhVien = tenThanhVien,
                    SDT = sDT,
                    MatKhau = matKhau,
                    TienDaMua = tienDaMua,
                    MaLoaiTV = maLoaiTV
                };

                return thanhVienDAL.UpdateThanhVien(updatedThanhVien);
            }

            public bool CheckPrimaryKey(int maTV)
            {
                return thanhVienDAL.CheckPrimaryKey(maTV);
            }

            public bool CheckForeignKey(int maTV)
            {
                return thanhVienDAL.CheckForeignKey(maTV);
            }

        }
    }


