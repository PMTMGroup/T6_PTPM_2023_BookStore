using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        public DTO_TaiKhoan() { }
        public DTO_TaiKhoan(string maTaiKhoan, string tenDangNhap, string matKhau, string hoTen, string sDT, string maQuyen, int biKhoa)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenDangNhap = tenDangNhap;
            this.matKhau=matKhau;
            this.hoTen=hoTen;
            this.sDT=sDT;
            this.maQuyen=maQuyen;
            this.biKhoa=biKhoa;
        }
        private string maTaiKhoan;

        public string MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
        private string tenDangNhap;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string sDT;

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private string maQuyen;

        public string MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }
        private int biKhoa;

        public int BiKhoa
        {
            get { return biKhoa; }
            set { biKhoa = value; }
        }
    }
}
