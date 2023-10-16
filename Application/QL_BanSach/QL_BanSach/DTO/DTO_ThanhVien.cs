using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThanhVien
    {
        private int maTV;
        private int tienDaMua;
        private string maLoaiTV;
        private string matKhau;
        private string tenThanhVien;
        private string sDT;

        public DTO_ThanhVien() { }
        public DTO_ThanhVien(int maTV, string tenThanhVien, string sDT, string matKhau, int tienDaMua, string maLoaiTV)
        {
            this.maTV = maTV;
            this.tenThanhVien = tenThanhVien;
            this.sDT=sDT;
            this.matKhau=matKhau;
            this.tienDaMua=tienDaMua;
            this.maLoaiTV = maLoaiTV;
        }
        public int MaTV
        {
            get { return maTV; }
            set { maTV = value; }
        }

        public string TenThanhVien
        {
            get { return tenThanhVien; }
            set { tenThanhVien = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        
        public int TienDaMua
        {
            get { return tienDaMua; }
            set { tienDaMua = value; }
        }

        public string MaLoaiTV
        {
            get { return maLoaiTV; }
            set { maLoaiTV = value; }
        }
    }
}
