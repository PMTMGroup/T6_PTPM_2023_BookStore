using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_DangNhap
    {
        DAL_DangNhap dalDangNhap = new DAL_DangNhap();
        public DTO_TaiKhoan getTaiKhoan(string tenDN, string matKhau)
        {
            return dalDangNhap.getTaiKhoan(tenDN, matKhau);
        }
    }
}
