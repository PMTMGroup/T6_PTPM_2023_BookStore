using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Frm_DangNhap
{
    public partial class Frm_QLKhoHang : Form
    {
        BLL_KhoHang bllKhoHang = new BLL_KhoHang();
        public Frm_QLKhoHang()
        {
            InitializeComponent();
            loadData();
            loadDataDefault();
        }

        private void btn_TTHDK_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maSach.Text = "";
            num_gianhap.Value = 0;
            num_slkho.Value = 1;
            txt_ghiChu.Text = "";
        }

        private void loadData()
        {
            DateTime today = DateTime.Today;
            txt_ngayLap.Text = today.ToString();
        }

        private void btn_DSSachSapHet_loc_Click(object sender, EventArgs e)
        {
            int slTon = int.Parse( num_soLuong.Value.ToString());
            List<DTO_Sach> list = bllKhoHang.getListSachTheoSoLuongTon(slTon);
            if(list == null)
                MessageBox.Show("Không có sách nào số lượng tồn dưới " + slTon + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                gv_dsSachSapHet.DataSource = null;
                gv_dsSachSapHet.DataSource = list;
            }
        }

        private void refreshDGV()
        {
            gv_chiTietHoaDonKho.DataSource = null;
            gv_chiTietHoaDonKho.DataSource = listKho;
        }
        private void gv_dsSachSapHet_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_dsSachSapHet.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = gv_dsSachSapHet.SelectedRows[0];
                txt_maSach.Text = selectRow.Cells[0].Value.ToString().Trim();
            }
        }

        List<DTO_ChiTietHoaDonKho> listKho = new List<DTO_ChiTietHoaDonKho>();
        private void btn_TTHDK_xacNhan_Click(object sender, EventArgs e)
        {
           if(!checkFullInfo())
               MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           else
           {
               if(bllKhoHang.getSachfromMaSach(txt_maSach.Text.Trim()) == null)
                   MessageBox.Show("Không tìm thấy thông tin Sách từ Mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               else
               {
                   bool checkExist = isExistInList(listKho, txt_maSach.Text.Trim());
                   if (!checkExist)
                   {
                       listKho.Add(new DTO_ChiTietHoaDonKho(
                            0, txt_maSach.Text.Trim(), int.Parse(num_slkho.Value.ToString()), int.Parse(num_gianhap.Value.ToString())
                       ));
                   }
                   else
                   {
                       foreach (DTO_ChiTietHoaDonKho hd in listKho)
                       {
                           if (hd.MaSach == txt_maSach.Text.Trim())
                           {
                               hd.SoLuong = hd.SoLuong + Convert.ToInt32(num_slkho.Value);
                           }
                       }
                   }
                   refreshDGV();
               }
           }

        }

        private bool checkFullInfo()
        {
            if (txt_maSach.Text.Trim() == "")
                return false;
            return true;
        }

        private bool isExistInList(List<DTO_ChiTietHoaDonKho> _dsMua, string _maSach)
        {
            foreach (DTO_ChiTietHoaDonKho hd in _dsMua)
            {
                if (hd.MaSach == _maSach)
                    return true;
            }
            return false;
        }

        private void btn_chiTietHoaDonKho_lapHoaDon_Click(object sender, EventArgs e)
        {
            if (cbo_TTHDK_loaiHoaDon.SelectedIndex < 0)
                MessageBox.Show("Vui lòng chọn loại hóa đơn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (listKho.Count < 1)
                    MessageBox.Show("Danh sách Sách nhập/xuất kho đang rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận hoàn tất hóa đơn kho hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (dialog == DialogResult.Yes)
                    {
                        if(cbo_TTHDK_loaiHoaDon.SelectedItem.ToString() == "Xuất kho")
                        {
                            bool checkSoLuongTon = bllKhoHang.checkXuatKho(listKho);
                            if(!checkSoLuongTon)
                                MessageBox.Show("Số lượng tồn của Sách không đủ cung cấp Xuất kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                            {
                                DateTime today = DateTime.Today;
                                bool storeHDK = bllKhoHang.storeHDKho(new DTO_HoaDonKho(
                                    0,
                                    tinhTongTienHoaDonKho(listKho),
                                    today,
                                    (txt_ghiChu.Text.Trim() == string.Empty) ? "Không" : txt_ghiChu.Text.Trim(),
                                    "TK02",
                                    (cbo_TTHDK_loaiHoaDon.SelectedItem.ToString() == "Nhập kho") ? "HDNhapKho" : "HDXuatKho"
                                ));

                                int soHDKnewStore = bllKhoHang.getSoHDKnewStore();

                                foreach (DTO_ChiTietHoaDonKho hd in listKho)
                                    hd.SoHDK = soHDKnewStore;

                                bool storeCTHDK = bllKhoHang.storeCTHDKho(listKho);
                                bool updateSLT = bllKhoHang.updateSoLuongTon("Xuất kho",listKho);

                                if (storeHDK && storeCTHDK && updateSLT)
                                {
                                    MessageBox.Show("Tạo hóa đơn kho hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    refreshAllData();
                                }
                                else
                                    MessageBox.Show("Lỗi trong quá trình thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            DateTime today = DateTime.Today;
                            bool storeHDK = bllKhoHang.storeHDKho(new DTO_HoaDonKho(
                                0,
                                tinhTongTienHoaDonKho(listKho),
                                today,
                                (txt_ghiChu.Text.Trim() == string.Empty) ? "Không" : txt_ghiChu.Text.Trim(),
                                "TK02",
                                (cbo_TTHDK_loaiHoaDon.SelectedItem.ToString() == "Nhập kho") ? "HDNhapKho" : "HDXuatKho"
                            ));

                            int soHDKnewStore = bllKhoHang.getSoHDKnewStore();

                            foreach (DTO_ChiTietHoaDonKho hd in listKho)
                                hd.SoHDK = soHDKnewStore;

                            bool storeCTHDK = bllKhoHang.storeCTHDKho(listKho);
                            bool updateSLT = bllKhoHang.updateSoLuongTon("Nhập kho", listKho);

                            if (storeHDK && storeCTHDK && updateSLT)
                            {
                                MessageBox.Show("Tạo hóa đơn kho hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refreshAllData();
                            }
                            else
                                MessageBox.Show("Lỗi trong quá trình thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                }
            }
        }

        private int tinhTongTienHoaDonKho(List<DTO_ChiTietHoaDonKho> ds)
        {
            int tongTien = 0;
            foreach(DTO_ChiTietHoaDonKho hd in ds)
            {
                tongTien += hd.Gia * hd.SoLuong;
            }
            return tongTien;
        }

        private void refreshAllData()
        {
            txt_maSach.Text = "";
            num_gianhap.Value = 0;
            num_slkho.Value = 1;
            txt_ghiChu.Text = "";
            listKho = new List<DTO_ChiTietHoaDonKho>();
            gv_chiTietHoaDonKho.DataSource = null;
            cbo_TTHDK_loaiHoaDon.SelectedIndex = -1;
            cbo_TTHDK_loaiHoaDon.Text = "--- Chọn ---";
            loadDataDefault();
        }

        private void btn_xoahet_Click(object sender, EventArgs e)
        {
            refreshAllData();
            listKho = new List<DTO_ChiTietHoaDonKho>();
            gv_chiTietHoaDonKho.DataSource = null;
        }

        private void loadDataDefault()
        {
            gv_dsHoaDonKho.DataSource = null;
            gv_dsHoaDonKho.DataSource = bllKhoHang.GetAllHoaDonKho();
            gv_dsHoaDonKho.ClearSelection();
        }

        private void btn_DSHoaDonKho_loc_Click(object sender, EventArgs e)
        {
            if(cbo_loaiHoaDon.SelectedIndex < 0)
                MessageBox.Show("Vui lòng chọn loại hóa đơn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string loaiHDK = "";
                if(cbo_loaiHoaDon.SelectedItem.ToString() == "Tất cả")
                    loaiHDK = "ALL";
                else
                {
                    if(cbo_loaiHoaDon.SelectedItem.ToString() == "Nhập kho")
                        loaiHDK = "HDNhapKho";
                    else
                        loaiHDK = "HDXuatKho";
                }
                gv_dsHoaDonKho.DataSource = null;
                gv_dsHoaDonKho.DataSource = bllKhoHang.GetDSHoaDonKhoTheoLoai(loaiHDK);
            }
        }

        private void gv_dsHoaDonKho_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_dsHoaDonKho.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = gv_dsHoaDonKho.SelectedRows[0];
                listKho = bllKhoHang.getDSCTHDKfromSoHD(int.Parse(selectRow.Cells[0].Value.ToString()));
                refreshDGV();
            }
        }
    }
}
