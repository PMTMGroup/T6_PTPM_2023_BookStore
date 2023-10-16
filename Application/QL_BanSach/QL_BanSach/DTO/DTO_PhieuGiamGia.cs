using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuGiamGia
    {
        public DTO_PhieuGiamGia() { }
        public DTO_PhieuGiamGia(string maGiamGia, string tenGiamGia, int phanTramGiamGia, DateTime ngayBD, DateTime ngayKT) {
            this.maGiamGia = maGiamGia;
            this.tenGiamGia = tenGiamGia;
            this.phanTramGiamGia = phanTramGiamGia;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }
        private string maGiamGia;

        public string MaGiamGia
        {
            get { return maGiamGia; }
            set { maGiamGia = value; }
        }
        private string tenGiamGia;

        public string TenGiamGia
        {
            get { return tenGiamGia; }
            set { tenGiamGia = value; }
        }
        private int phanTramGiamGia;

        public int PhanTramGiamGia
        {
            get { return phanTramGiamGia; }
            set { phanTramGiamGia = value; }
        }
        private DateTime ngayBD;

        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        private DateTime ngayKT;

        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }
    }
}
