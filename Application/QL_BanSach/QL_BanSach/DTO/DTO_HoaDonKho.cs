using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonKho
    {
        public DTO_HoaDonKho() { }
        public DTO_HoaDonKho(int soHDK,int tongTien, DateTime ngayLap, string ghiChu, string maTaiKhoan, string maLoaiHD)
        {
            this.soHDK = soHDK;
            this.tongTien = tongTien;
            this.ngayLap = ngayLap;
            this.ghiChu = ghiChu;
            this.maTaiKhoan = maTaiKhoan;
            this.maLoaiHD = maLoaiHD;
        }
        private int soHDK;

        public int SoHDK
        {
            get { return soHDK; }
            set { soHDK = value; }
        }
        private int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        private DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private string maTaiKhoan;

        public string MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        private string maLoaiHD;

        public string MaLoaiHD
        {
            get { return maLoaiHD; }
            set { maLoaiHD = value; }
        }
    }
}
