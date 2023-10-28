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
    public partial class Frm_QLHoaDonBan : Form
    {
        BLL_HoaDonBan hoadonbanBLL = new BLL_HoaDonBan();
        public Frm_QLHoaDonBan()
        {
            InitializeComponent();
            loadHDB();
        }

        private void gv_dsHoaDonBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadHDB()
        {
            List<DTO_HoaDonBan> hdb = hoadonbanBLL.GetAllHoaDonBan();
            gv_dsHoaDonBanHang.DataSource = hdb;
           
        }
        public void loadCTHDB()
        {

        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (rdo_soHD.Checked)
            {
                string soHDText = txt_soHoaDon.Text.Trim();

                if (string.IsNullOrEmpty(soHDText))
                {
                    MessageBox.Show("Vui lòng điền thông tin số hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int soHD = int.Parse(soHDText);
                    {
                        DTO_HoaDonBan hoaDonBan = hoadonbanBLL.GetHoaDonBanFromSHD(soHD);
                        if (hoaDonBan == null)
                        {
                            MessageBox.Show("Không tìm thấy thông tin hóa đơn bán từ số hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Hiển thị kết quả tìm kiếm
                            gv_dsHoaDonBanHang.DataSource = new List<DTO_HoaDonBan> { hoaDonBan };
                        }
                    }
                }
            }
            if(rdo_nguoiLap.Checked)
            {
                string nguoiLap = txt_nguoiLap.Text.Trim();

                if (string.IsNullOrEmpty(nguoiLap))
                {
                    MessageBox.Show("Vui lòng điền thông tin người lập hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<DTO_HoaDonBan> hoaDonBanList = hoadonbanBLL.GetHoaDonBanFromNguoiLap(nguoiLap);

                    if (hoaDonBanList.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin hóa đơn bán từ người lập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Hiển thị kết quả tìm kiếm
                        gv_dsHoaDonBanHang.DataSource = hoaDonBanList;
                    }
                }

            }

            if (rdo_maTV.Checked)
            {
                if (string.IsNullOrEmpty(txt_maThanhVien.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền thông tin mã thành viên để thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int maTV = Int32.Parse(txt_maThanhVien.Text.Trim());
                    List<DTO_HoaDonBan> hoaDonBanList = hoadonbanBLL.GetHoaDonBanFromThanhVien(maTV);

                    if (hoaDonBanList.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy thông tin hóa đơn bán từ thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Hiển thị kết quả tìm kiếm
                        gv_dsHoaDonBanHang.DataSource = hoaDonBanList;
                    }
                }
            }

            if (rdo_ngayLap.Checked)
            {
                List<DTO_HoaDonBan> hoaDonBanList = hoadonbanBLL.GetHoaDonBanFromNgayLap(date_NgayLap.Value);

                if (hoaDonBanList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin hóa đơn bán từ ngày lập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Hiển thị kết quả tìm kiếm
                    gv_dsHoaDonBanHang.DataSource = hoaDonBanList;
                }
            }
        }

        private void txt_nguoiLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void gv_dsHoaDonBanHang_SelectionChanged(object sender, EventArgs e)
        {
            if(gv_dsHoaDonBanHang.SelectedRows.Count > 0)
            {
                DataGridViewRow r = gv_dsHoaDonBanHang.SelectedRows[0];
                int soHDB = Int32.Parse( r.Cells[0].Value.ToString().Trim());
                
                gv_chiTietHoaDonBanHang.DataSource = null;
                gv_chiTietHoaDonBanHang.DataSource = hoadonbanBLL.GetCTHoaDonBanFromSoHD(soHDB);
            }
        }

        private void rdo_soHD_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] listTB = new TextBox[] { txt_maThanhVien, txt_nguoiLap };
            foreach (TextBox x in listTB)
            {
                x.Text = string.Empty;
                x.Enabled = false;
            }
            date_NgayLap.Enabled = false;
            txt_soHoaDon.Enabled = true;
        }


        private void txt_soHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_maThanhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void rdo_ngayLap_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] listTB = new TextBox[] { txt_maThanhVien, txt_nguoiLap, txt_soHoaDon};
            foreach (TextBox x in listTB)
            {
                x.Text = string.Empty;
                x.Enabled = false;
            }
            date_NgayLap.Enabled = true ;


        }

        private void rdo_maTV_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] listTB = new TextBox[] { txt_soHoaDon, txt_nguoiLap };
            foreach (TextBox x in listTB)
            {
                x.Text = string.Empty;
                x.Enabled = false;
            }
            date_NgayLap.Enabled = false;
            txt_maThanhVien.Enabled = true;


        }

        private void rdo_nguoiLap_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] listTB = new TextBox[] { txt_soHoaDon, txt_maThanhVien };
            foreach (TextBox x in listTB)
            {
                x.Text = string.Empty;
                x.Enabled = false;
            }
            date_NgayLap.Enabled = false;
            txt_nguoiLap.Enabled = true;


        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            loadHDB();
            TextBox[] listTB = new TextBox[] { txt_maThanhVien, txt_nguoiLap };
            foreach (TextBox x in listTB)
            {
                x.Text = string.Empty;
                x.Enabled = false;
            }
            date_NgayLap.Enabled = false;
            txt_soHoaDon.Enabled = true;
            rdo_soHD.Checked = true;
        }
    }
}
