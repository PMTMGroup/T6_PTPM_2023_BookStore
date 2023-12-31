﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using DTO;
using BLL;

namespace Frm_DangNhap
{
    public partial class Frm_QLDonDatHang : Form
    {
        BLL_DonDatHang bllDonDatHang = new BLL_DonDatHang();
        public Frm_QLDonDatHang()
        {
            InitializeComponent();
            loadDGVDSDonDatHang();
        }

        public void loadDGVDSDonDatHang()
        {
            dgv_dondathang.DataSource = bllDonDatHang.GetAllDonDatHang();
        }

        private void dgv_dondathang_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_dondathang.SelectedRows.Count > 0)
            {
                DataGridViewRow rowSeleted = dgv_dondathang.SelectedRows[0];
                dgv_chitietddh.DataSource = bllDonDatHang.GetDSChiTietDDHfromMaDDH(int.Parse(rowSeleted.Cells[0].Value.ToString()));
                txt_soDonHang.Text = rowSeleted.Cells[0].Value.ToString();
                txt_ngayLap.Text = rowSeleted.Cells[1].Value.ToString();
                txt_hinhThucThanhToan.Text = rowSeleted.Cells[2].Value.ToString();
                txt_maThanhVien.Text = rowSeleted.Cells[3].Value.ToString();
                txt_maGiamGia.Text = rowSeleted.Cells[4].Value.ToString();
                txt_phiShip.Text = rowSeleted.Cells[5].Value.ToString();
                txt_tongTien.Text =rowSeleted.Cells[6].Value.ToString(); 
                txt_tongGiamGia.Text = rowSeleted.Cells[7].Value.ToString();
                txt_thanhTien.Text = rowSeleted.Cells[8].Value.ToString();
                txt_hoTenNguoiNhan.Text = rowSeleted.Cells[9].Value.ToString();
                txt_sdt.Text =rowSeleted.Cells[10].Value.ToString();
                txt_email.Text = rowSeleted.Cells[11].Value.ToString();
                txt_diaChiGiaoHang.Text =rowSeleted.Cells[12].Value.ToString(); 
                txt_ghiChu.Text = rowSeleted.Cells[13].Value.ToString();
                cbo_trangThaiDonHang.Text = rowSeleted.Cells[14].Value.ToString();
            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            if (cbo_trangThaiDonHangLoc.SelectedIndex < 0)
                MessageBox.Show("Vui lòng chọn trạng thái để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dgv_dondathang.DataSource = bllDonDatHang.GetDSDonDatHangfromTrangThaiDDH(cbo_trangThaiDonHangLoc.SelectedItem.ToString().Trim());
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(cbo_trangThaiDonHang.SelectedIndex < 0)
                MessageBox.Show("Vui lòng chọn trạng thái để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DataGridViewRow rowSeleted = dgv_dondathang.SelectedRows[0];
                int maTV = Int32.Parse( rowSeleted.Cells[3].Value.ToString());
                int tongTienDonHang = Int32.Parse(rowSeleted.Cells[6].Value.ToString());

                string oldStatusOrder = rowSeleted.Cells[14].Value.ToString();
                string newStatusOrder = cbo_trangThaiDonHang.SelectedItem.ToString();
                if(checkReverseStatusOrder(oldStatusOrder, newStatusOrder))
                {
                    MessageBox.Show("Trạng thái đơn đặt hàng phải một chiều!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<DTO_ChiTietDonDatHang> listCTDDH = bllDonDatHang.GetDSChiTietDDHfromMaDDH(int.Parse(rowSeleted.Cells[0].Value.ToString()));

                if (newStatusOrder == "Đang giao hàng")
                {
                    foreach (DTO_ChiTietDonDatHang ctddh in listCTDDH)
                    {
                        if (ctddh.SoLuong > bllDonDatHang.getSachfromMaSach(ctddh.MaSach.Trim()).SoLuongTon)
                        {
                            MessageBox.Show("Sách #" + ctddh.MaSach.Trim() + " có tên #" + bllDonDatHang.getSachfromMaSach(ctddh.MaSach.Trim()).TenSach + " không đủ đáp ứng, vui lòng nhập sách thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                DialogResult resualt = MessageBox.Show("Xác nhận cập nhật trạng thái của đơn đặt hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                if(resualt == DialogResult.Yes)
                {
                    if (newStatusOrder == "Đang giao hàng")
                    {
                        bllDonDatHang.updateSoLuongTon(listCTDDH);

                        if(maTV != 1)
                        {
                            bllDonDatHang.updateTienDaMuaCuaThanhVien(maTV, tongTienDonHang);
                        }
                    }

                    bool ketQuaCapNhat = bllDonDatHang.updateTrangThaiDonDatHang(int.Parse(txt_soDonHang.Text.Trim()), cbo_trangThaiDonHang.SelectedItem.ToString());

                    if (ketQuaCapNhat)
                    {
                        const string CsrfToken = "elcrNeYB73hWdlM9Tti5ykqlSyfux3jE26E1Fhuy";

                        string email = txt_email.Text.Trim();
                        string hoten = txt_hoTenNguoiNhan.Text.Trim();
                        string sohd = txt_soDonHang.Text.Trim();
                        string ngaydh = txt_ngayLap.Text.Trim();
                        string trangthai = cbo_trangThaiDonHang.SelectedItem.ToString();

                        string apiUrlWithQueryString = "http://127.0.0.1:8000/send-mail-notification?email="+ email +"&hoten="+hoten+"&sohoadon="+sohd+"&ngaydathang="+ngaydh+"&trangthai="+trangthai;

                        using (HttpClient httpClient = new HttpClient())
                        {
                            try
                            {
                                var task = httpClient.GetAsync(apiUrlWithQueryString);
                                HttpResponseMessage response = task.Result;

                                if (response.IsSuccessStatusCode)
                                {
                                    MessageBox.Show("Cập nhật trạng thái đơn đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    loadDGVDSDonDatHang();
                                }
                                else
                                {
                                    MessageBox.Show("Gửi email thông báo thất bại. Mã lỗi: " + response.StatusCode);
                                }
                            }
                            catch (HttpRequestException ex)
                            {
                                MessageBox.Show("Lỗi trong quá trình gửi yêu cầu: " + ex.Message);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Cập nhật trạng thái đơn đặt hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private bool checkReverseStatusOrder(string oldStatus, string newStatus)
        {
            int valueOldStatus=0, valueNewStatus=0;
            switch(oldStatus)
            {
                case "Đang xử lý": valueOldStatus = 1; break;
                case "Đang giao hàng": valueOldStatus = 2; break;
                case "Đã giao hàng": valueOldStatus = 3; break;
                case "Đã từ chối": valueOldStatus = 4; break;
            }

            switch (newStatus)
            {
                case "Đang xử lý": valueNewStatus = 1; break;
                case "Đang giao hàng": valueNewStatus = 2; break;
                case "Đã giao hàng": valueNewStatus = 3; break;
                case "Đã từ chối": valueNewStatus = 4; break;
            }

            return valueNewStatus <= valueOldStatus ? true : false;
        }
    }
}
