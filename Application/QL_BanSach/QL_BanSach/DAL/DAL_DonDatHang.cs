﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DonDatHang
    {
        DBConnection db = new DBConnection();
        public List<DTO_DonDatHang> GetAllDonDatHang()
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                return context.DonDatHangs.Select(s => new DTO_DonDatHang
                {
                    SoHD=s.SoHD,
                    NgayLap=s.NgayLap.ToString(),
                    HinhThucThanhToan=s.HinhThucThanhToan,
                    MaTV=(int)s.MaTV,
                    MaGiamGia=s.MaGiamGia,
                    PhiShip=(int)s.PhiShip,
                    TongTien = (int)s.TongTien,
                    TongGiam = (int)s.TongGiam,
                    ThanhTien = (int)s.ThanhTien,
                    HoTenNguoiNhan=s.HoTenNguoiNhan,
                    SDTNguoiNhan=s.SDTNguoiNhan,
                    Email=s.Email,
                    DiaChiNhanHang=s.DiaChiNhanHang,
                    GhiChu=s.GhiChu,
                    TrangThaiDonHang=s.TrangThaiDonHang
                }).ToList();
            }
        }

        public List<DTO_DonDatHang> GetDSDonDatHangfromTrangThaiDDH(string trangThaiDDH)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<DTO_DonDatHang> listDDH = new List<DTO_DonDatHang>();
                List<DonDatHang> DDH = context.DonDatHangs.Where(s => s.TrangThaiDonHang == trangThaiDDH).ToList();
                foreach (DonDatHang s in DDH)
                {
                    listDDH.Add(new DTO_DonDatHang {
                        SoHD = s.SoHD,
                        NgayLap = s.NgayLap.ToString(),
                        HinhThucThanhToan = s.HinhThucThanhToan,
                        MaTV = (int)s.MaTV,
                        MaGiamGia = s.MaGiamGia,
                        PhiShip = (int)s.PhiShip,
                        TongTien = (int)s.TongTien,
                        TongGiam = (int)s.TongGiam,
                        ThanhTien = (int)s.ThanhTien,
                        HoTenNguoiNhan = s.HoTenNguoiNhan,
                        SDTNguoiNhan = s.SDTNguoiNhan,
                        Email = s.Email,
                        DiaChiNhanHang = s.DiaChiNhanHang,
                        GhiChu = s.GhiChu,
                        TrangThaiDonHang = s.TrangThaiDonHang
                    });
                }
                return listDDH;
            }
        }

        public List<DTO_ChiTietDonDatHang> GetDSChiTietDDHfromMaDDH(int maDDH)
        {
            using (var context = new QLCuaHangSachDataContext(db.connectionString))
            {
                List<DTO_ChiTietDonDatHang> listCTDDH = new List<DTO_ChiTietDonDatHang>();
                List<ChiTietDonDatHang> CTDDH = context.ChiTietDonDatHangs.Where(s => s.SoHD == maDDH).ToList();
                foreach(ChiTietDonDatHang i in CTDDH)
                {
                    listCTDDH.Add(new DTO_ChiTietDonDatHang(
                        i.SoHD, i.MaSach, (int)i.SoLuong, (int)i.TongTien
                    ));
                }
                return listCTDDH;
            }
        }

        public bool updateTrangThaiDonDatHang(int SoDDH, string trangThaiCapNhat)
        {
            try
            {
                using (var context = new QLCuaHangSachDataContext(db.connectionString))
                {
                    var donDatHang = context.DonDatHangs.SingleOrDefault(i => i.SoHD == SoDDH);
                    if(donDatHang != null)
                    {
                        donDatHang.TrangThaiDonHang = trangThaiCapNhat;
                        context.SubmitChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
