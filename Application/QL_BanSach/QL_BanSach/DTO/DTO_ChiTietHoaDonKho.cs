using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonKho
    {
        public DTO_ChiTietHoaDonKho() { }
        public DTO_ChiTietHoaDonKho(int soHDK, string maSach, int soLuong, int gia) {
            this.soHDK = soHDK;
            this.maSach = maSach;
            this.soLuong = soLuong;
            this.gia = gia;
        }
        private int soHDK;

        public int SoHDK
        {
            get { return soHDK; }
            set { soHDK = value; }
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
        private int gia;

        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}
