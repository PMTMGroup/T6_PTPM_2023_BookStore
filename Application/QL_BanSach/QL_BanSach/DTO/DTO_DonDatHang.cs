using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonDatHang
    {
        public DTO_DonDatHang() { }
        public DTO_DonDatHang(int soHD,DateTime ngayLap,string hinhThucThanhToan,int maTV,string maGiamGia,
            int phiShip,int tongTien,int tongGiam,int thanhTien,string hoTenNguoiNhan,string sDTNguoiNhan,
            string email, string diaChiNhanHang, string ghiChu, string trangThaiDonHang)
        {
            this.soHD=soHD;
            this.ngayLap=ngayLap;
            this.hinhThucThanhToan=hinhThucThanhToan;
            this.maTV=maTV;
            this.maGiamGia=maGiamGia;
            this.phiShip=phiShip;
            this.tongTien=tongTien;
            this.tongGiam=tongGiam;
            this.thanhTien=thanhTien;
            this.hoTenNguoiNhan=hoTenNguoiNhan;
            this.sDTNguoiNhan=sDTNguoiNhan;
            this.email=email;
            this.diaChiNhanHang=diaChiNhanHang;
            this.ghiChu=ghiChu;
            this.trangThaiDonHang=trangThaiDonHang;
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
        private string hinhThucThanhToan;

        public string HinhThucThanhToan
        {
            get { return hinhThucThanhToan; }
            set { hinhThucThanhToan = value; }
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
        private int phiShip;

        public int PhiShip
        {
            get { return phiShip; }
            set { phiShip = value; }
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
        private string hoTenNguoiNhan;

        public string HoTenNguoiNhan
        {
            get { return hoTenNguoiNhan; }
            set { hoTenNguoiNhan = value; }
        }
        private string sDTNguoiNhan;

        public string SDTNguoiNhan
        {
            get { return sDTNguoiNhan; }
            set { sDTNguoiNhan = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string diaChiNhanHang;

        public string DiaChiNhanHang
        {
            get { return diaChiNhanHang; }
            set { diaChiNhanHang = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private string trangThaiDonHang;

        public string TrangThaiDonHang
        {
            get { return trangThaiDonHang; }
            set { trangThaiDonHang = value; }
        }
    }
}
