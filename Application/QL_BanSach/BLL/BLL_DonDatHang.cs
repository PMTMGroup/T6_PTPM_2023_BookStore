﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_DonDatHang
    {
        DAL_DonDatHang dalDonDatHang = new DAL_DonDatHang();

        public List<DTO_DonDatHang> GetAllDonDatHang()
        {
            return dalDonDatHang.GetAllDonDatHang();
        }

        public List<DTO_DonDatHang> GetDSDonDatHangfromTrangThaiDDH(string trangThaiDDH)
        {
            if (trangThaiDDH == "Tất cả")
                return dalDonDatHang.GetAllDonDatHang();
            return dalDonDatHang.GetDSDonDatHangfromTrangThaiDDH(trangThaiDDH);
        }

        public List<DTO_ChiTietDonDatHang> GetDSChiTietDDHfromMaDDH(int maDDH)
        {
            return dalDonDatHang.GetDSChiTietDDHfromMaDDH(maDDH);
        }

        public bool updateTrangThaiDonDatHang(int SoDDH, string trangThaiCapNhat)
        {
            return dalDonDatHang.updateTrangThaiDonDatHang(SoDDH, trangThaiCapNhat);
        }

        public DTO_Sach getSachfromMaSach(string maSach)
        {
            return dalDonDatHang.getSachfromMaSach(maSach);
        }

        public bool updateSoLuongTon(List<DTO_ChiTietDonDatHang> _ds)
        {
            return dalDonDatHang.updateSoLuongTon(_ds);
        }
        public void updateTienDaMuaCuaThanhVien(int _maTV, int tienMua)
        {
            dalDonDatHang.updateTienDaMuaCuaThanhVien(_maTV, tienMua);
        }

    }
}
