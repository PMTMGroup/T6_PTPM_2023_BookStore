using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonBan
    {
        public DTO_HoaDonBan() { }
        public DTO_HoaDonBan(int soHD, DateTime ngayLap, int tongTien, int tongGiam, int thanhTien, int maTV, string maGiamGia, string maTaiKhoan)
        {
            this.soHD=soHD;
            this.ngayLap=ngayLap;
            this.tongTien=tongTien;
            this.tongGiam=tongGiam;
            this.thanhTien=thanhTien;
            this.maTV=maTV;
            this.maGiamGia=maGiamGia;
            this.maTaiKhoan = maTaiKhoan;
        }
        private int soHD;

        public int SoHD
        {
            get { return soHD; }
            set { soHD = value; }
        }
        private DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        private int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        private int tongGiam;

        public int TongGiam
        {
            get { return tongGiam; }
            set { tongGiam = value; }
        }
        private int thanhTien;

        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        private int maTV;

        public int MaTV
        {
            get { return maTV; }
            set { maTV = value; }
        }
        private string maGiamGia;

        public string MaGiamGia
        {
            get { return maGiamGia; }
            set { maGiamGia = value; }
        }
        private string maTaiKhoan;

        public string MaTaiKhoan
        {
            get { return maTaiKhoan; }
            set { maTaiKhoan = value; }
        }
    }
}
