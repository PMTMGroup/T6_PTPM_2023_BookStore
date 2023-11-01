using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();
        public List<DTO_TaiKhoan> GetAllTaiKhoan()
        {
            return dalTaiKhoan.GetAllTaiKhoan();
        }

        public DTO_Quyen getQuyenfromMaQuyen(string maQuyen)
        {
            return dalTaiKhoan.getQuyenfromMaQuyen(maQuyen);
        }

        public bool insertTaiKhoan(DTO_TaiKhoan _taiKhoan)
        {
            return dalTaiKhoan.insertTaiKhoan(_taiKhoan);
        }

        public bool deleteTaiKhoan(string maTaiKhoan)
        {
            return dalTaiKhoan.deleteTaiKhoan(maTaiKhoan);
        }

        public bool updateTaiKhoan(DTO_TaiKhoan _taiKhoan)
        {
            return dalTaiKhoan.updateTaiKhoan(_taiKhoan);
        }

        public bool checkPrimaryKey(string maTaiKhoan)
        {
            return dalTaiKhoan.checkPrimaryKey(maTaiKhoan);
        }

        public bool checkForeignKey(string maTaiKhoan)
        {
            return dalTaiKhoan.checkForeignKey(maTaiKhoan);
        }

        public bool checkExistTenDangNhap(string tenDN)
        {
            return dalTaiKhoan.checkExistTenDangNhap(tenDN);
        }

        public DTO_TaiKhoan getTaiKhoanfromMaTaiKhoan(string maTK)
        {
            return dalTaiKhoan.getTaiKhoanfromMaTaiKhoan(maTK);
        }

        public bool doiMatKhau(string maTaiKhoan, string mkMoi)
        {
            return dalTaiKhoan.doiMatKhau(maTaiKhoan,mkMoi);
        }
    }
}
