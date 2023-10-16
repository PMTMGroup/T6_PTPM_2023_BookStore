using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiHoaDon
    {
        public DTO_LoaiHoaDon() { }
        public DTO_LoaiHoaDon(string maLoaiHD, string tenLoaiHD)
        {
            this.maLoaiHD = maLoaiHD;
            this.tenLoaiHD = tenLoaiHD;
        }
        private string maLoaiHD;

        public string MaLoaiHD
        {
            get { return maLoaiHD; }
            set { maLoaiHD = value; }
        }
        private string tenLoaiHD;

        public string TenLoaiHD
        {
            get { return tenLoaiHD; }
            set { tenLoaiHD = value; }
        }
    }
}
