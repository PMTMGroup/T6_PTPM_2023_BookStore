using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiThanhVien
    {
        public DTO_LoaiThanhVien() { }
        public DTO_LoaiThanhVien(string maLoaiTV, string tenLoaiTV, int tienCanDat, int phanTramGiamGia)
        {
            this.maLoaiTV = maLoaiTV;
            this.tenLoaiTV = tenLoaiTV;
            this.tienCanDat = tienCanDat;
            this.phanTramGiamGia = phanTramGiamGia;
        }
        private string maLoaiTV;

        public string MaLoaiTV
        {
            get { return maLoaiTV; }
            set { maLoaiTV = value; }
        }
        private string tenLoaiTV;

        public string TenLoaiTV
        {
            get { return tenLoaiTV; }
            set { tenLoaiTV = value; }
        }
        private int tienCanDat;

        public int TienCanDat
        {
            get { return tienCanDat; }
            set { tienCanDat = value; }
        }
        private int phanTramGiamGia;

        public int PhanTramGiamGia
        {
            get { return phanTramGiamGia; }
            set { phanTramGiamGia = value; }
        }
    }
}
