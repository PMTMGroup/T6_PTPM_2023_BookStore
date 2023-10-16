using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sach
    {
        public DTO_Sach() {  }
        public DTO_Sach(string maSach,string tenSach,string tacGia,int soTrang,int giaBan,int soLuongTon,string maTheLoai,string maNXB,string maTang, string maKe, string hinhAnh)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.soTrang = soTrang;
            this.giaBan = giaBan;
            this.soLuongTon = soLuongTon;
            this.maTheLoai = maTheLoai;
            this.maNXB = maNXB;
            this.maTang = maTang;
            this.maKe = maKe;
            this.hinhAnh = hinhAnh;
        }
        private string maSach;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        private string tenSach;

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        private string tacGia;

        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        private int giaBan;

        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        private int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
        private string maTheLoai;

        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }
        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
        private string maTang;

        public string MaTang
        {
            get { return maTang; }
            set { maTang = value; }
        }
        private string maKe;

        public string MaKe
        {
            get { return maKe; }
            set { maKe = value; }
        }
        private string hinhAnh;

        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
    }
}
