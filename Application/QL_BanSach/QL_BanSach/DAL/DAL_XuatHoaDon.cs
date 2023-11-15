using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_XuatHoaDon
    {
        DBConnection db = new DBConnection();
        public void insertTableXuatHoaDon(int soHD)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var cthoadonban = from cthdb in context.ChiTietHoaDonBans where cthdb.SoHD == soHD select cthdb;
                List<ChiTietHoaDonBan> listCTHDB = cthoadonban.ToList();
                foreach(ChiTietHoaDonBan cthdb in listCTHDB)
                {
                    XuatHoaDon dtoXHD = new XuatHoaDon();
                    dtoXHD.SoHD = soHD;
                    dtoXHD.MaSach = cthdb.MaSach.Trim();
                    
                    Sach sachOBJ = context.Saches.Where(s=>s.MaSach == cthdb.MaSach.Trim()).FirstOrDefault();
                    dtoXHD.TenSach = sachOBJ.TenSach.Trim();
                    dtoXHD.DonGia = (int)sachOBJ.GiaBan;

                    dtoXHD.SoLuong = (int)cthdb.SoLuong;
                    dtoXHD.TienTamTinh = (int)cthdb.TongTien;

                    HoaDonBan hdb = context.HoaDonBans.Where(hdbOBJ=>hdbOBJ.SoHD == soHD).FirstOrDefault();
                    dtoXHD.NgayLap = hdb.NgayLap;
                    dtoXHD.TongTien = (int)hdb.TongTien;
                    dtoXHD.TongGiam = (int)hdb.TongGiam;
                    dtoXHD.ThanhTien = (int)hdb.ThanhTien;
                    dtoXHD.MaTV = (int)hdb.MaTV;
                    dtoXHD.MaGiamGia = hdb.MaGiamGia;
                    dtoXHD.MaTaiKhoan = hdb.MaTaiKhoan;

                    context.XuatHoaDons.InsertOnSubmit(dtoXHD);
                    context.SubmitChanges();
                }
            }
        }

        public void deleteTableXuatHoaDon()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var xuatHoaDon = from hd in context.XuatHoaDons select hd;
                List<XuatHoaDon> listXHD = xuatHoaDon.ToList();
                foreach (XuatHoaDon xhd in listXHD)
                {
                    context.XuatHoaDons.DeleteOnSubmit(xhd);
                    context.SubmitChanges();
                }
            }
        }

        public int getSoHDXuatHoaDon()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                var hoadonban = from hdb in context.HoaDonBans select hdb;
                List<HoaDonBan> listHDB = hoadonban.ToList();
                int soHDLast = 0;
                foreach(HoaDonBan hdb in listHDB)
                {
                    soHDLast = (int)hdb.SoHD;
                }
                return soHDLast;
            }
        }
    }
}
