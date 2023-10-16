using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TheLoaiSach
    {
        public DTO_TheLoaiSach() { }
        public DTO_TheLoaiSach(string maTheLoai, string tenTheLoai)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
        }
        private string maTheLoai;

        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }
        private string tenTheLoai;

        public string TenTheLoai
        {
            get { return tenTheLoai; }
            set { tenTheLoai = value; }
        }
    }
}
