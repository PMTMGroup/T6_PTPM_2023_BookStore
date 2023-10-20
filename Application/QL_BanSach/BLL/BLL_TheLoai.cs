using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_TheLoaiSach
    {
        private DAL_TheLoaiSach theloaiDAL = new DAL_TheLoaiSach();

        public List<DTO_TheLoaiSach> GetAllTheLoaiSachs()
        {
            return theloaiDAL.GetAllTheLoaiSachs();
        }

        public bool insertTheLoaiSach(string maTheLoai, string tenTheLoai)
        {
            var newTheLoaiSach = new DTO_TheLoaiSach
            {
                MaTheLoai = maTheLoai,
                TenTheLoai = tenTheLoai
            };

            return theloaiDAL.insertTheLoaiSach(newTheLoaiSach);
        }

        public bool deleteTheLoaiSach(string maTheLoai)
        {
            return theloaiDAL.deleteTheLoaiSach(maTheLoai);
        }

        public bool updateTheLoaiSach(string maTheLoai, string tenTheLoai)
        {
            var newTheLoaiSach = new DTO_TheLoaiSach
            {
                MaTheLoai = maTheLoai,
                TenTheLoai = tenTheLoai
            };

            return theloaiDAL.updateTheLoaiSach(newTheLoaiSach);
        }

        public bool checkPrimaryKey(string maTheLoai)
        {
            return theloaiDAL.checkPrimaryKey(maTheLoai);
        }

        public bool checkForeignKey(string maTheLoai)
        {
            return theloaiDAL.checkForeignKey(maTheLoai);
        }
    }

}
