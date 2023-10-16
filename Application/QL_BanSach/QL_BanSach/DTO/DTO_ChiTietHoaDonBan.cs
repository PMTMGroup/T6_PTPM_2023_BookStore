using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonBan
    {
        public DTO_ChiTietHoaDonBan() { }
        public DTO_ChiTietHoaDonBan(int soHD, string maSach, int soLuong, int tongTien)
        {
            this.soHD = soHD;
            this.maSach = maSach;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }

        private int soHD;

        public int SoHD
        {
            get { return soHD; }
            set { soHD = value; }
        }
        private string maSach;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
