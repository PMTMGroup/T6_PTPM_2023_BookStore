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
        }

        private void txt_nguoiLap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
