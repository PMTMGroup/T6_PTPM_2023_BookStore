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
    public partial class Frm_QLPhieuGiamGia : Form
    {
        private BLL_PhieuGiamGia phieugiamgiaBLL = new BLL_PhieuGiamGia();
        public Frm_QLPhieuGiamGia(string maTKDN)
        {
            InitializeComponent();

            if (phieugiamgiaBLL.getMaQuyenfromMaTaiKhoan(maTKDN).Trim() == "user")
                grp_uudai.Enabled = false;
            else
                loadDGVPhieuGiamGia();
        }

        public Frm_QLPhieuGiamGia()
        {
            InitializeComponent();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maGiamGia.Text = "";
            txt_tenUuDai.Text = "";
            num_phanTramGiam.Value = 0;
            dtp_ngayBatDau.Value = dtp_ngayKetThuc.Value = DateTime.Today;
        }

        private void gv_thongTinUuDai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadDGVPhieuGiamGia()
        {
            List<DTO_PhieuGiamGia> pggs = phieugiamgiaBLL.GetAllPhieuGiamGia();
            gv_thongTinUuDai.DataSource = pggs;
        }
        public void refreshPhieuGiamGia()
        {
            txt_maGiamGia.Text = "";
            txt_tenUuDai.Text = "";
            num_phanTramGiam.Value = 0;
            dtp_ngayBatDau.Value = dtp_ngayKetThuc.Value = DateTime.Today;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        
        }

        private void Frm_QLPhieuGiamGia_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maGiamGia.Text.Trim() == string.Empty || txt_maGiamGia.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Phiếu Giảm Giá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maGiamGia = txt_maGiamGia.Text.Trim();
                string tenGiamGia = txt_tenUuDai.Text.Trim();
                int phanTramGiamGia = (int)num_phanTramGiam.Value; // Lấy giá trị từ NumericUpDown
                DateTime ngayBD = dtp_ngayBatDau.Value;
                DateTime ngayKT = dtp_ngayKetThuc.Value;

                if (ngayBD > ngayKT)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (phieugiamgiaBLL.CheckPrimaryKey(maGiamGia))
                    MessageBox.Show("Mã giảm giá đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin Phiếu Giảm Giá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (phieugiamgiaBLL.InsertPhieuGiamGia(maGiamGia, tenGiamGia, phanTramGiamGia, ngayBD, ngayKT))
                        {
                            MessageBox.Show("Thêm Phiếu Giảm Giá mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Gọi hàm loadDGVPhieuGiamGia() để cập nhật DataGridView hiển thị
                            loadDGVPhieuGiamGia();
                            // Gọi hàm refreshPhieuGiamGia() để làm mới các controls nhập liệu
                            refreshPhieuGiamGia();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (gv_thongTinUuDai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_thongTinUuDai.SelectedRows[0];

                // Lấy mã giảm giá từ dòng được chọn
                string maGiamGia = selectedRow.Cells["MaGiamGia"].Value.ToString();

                if (phieugiamgiaBLL.CheckForeignKey(maGiamGia))
                {
                    MessageBox.Show("Phiếu giảm giá đang giữ khóa ngoại, không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận xóa thông tin Phiếu Giảm Giá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (phieugiamgiaBLL.DeletePhieuGiamGia(maGiamGia))
                        {
                            MessageBox.Show("Xóa Phiếu Giảm Giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVPhieuGiamGia();
                            // Cập nhật DataGridView hiển thị
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Phiếu Giảm Giá để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (gv_thongTinUuDai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_thongTinUuDai.SelectedRows[0];

                // Lấy mã giảm giá từ dòng được chọn
                string maGiamGia = selectedRow.Cells["MaGiamGia"].Value.ToString().Trim();

                if (txt_tenUuDai.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Phiếu Giảm Giá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string tenGiamGia = txt_tenUuDai.Text.Trim();
                    int phanTramGiamGia = (int)num_phanTramGiam.Value;
                    DateTime ngayBD = dtp_ngayBatDau.Value;
                    DateTime ngayKT = dtp_ngayKetThuc.Value;

                    if (ngayBD > ngayKT)
                    {
                        MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Xác nhận sửa thông tin Phiếu Giảm Giá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dialog == DialogResult.Yes)
                        {
                            if (phieugiamgiaBLL.UpdatePhieuGiamGia(maGiamGia, tenGiamGia, phanTramGiamGia, ngayBD, ngayKT))
                            {
                                MessageBox.Show("Sửa thông tin Phiếu Giảm Giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadDGVPhieuGiamGia();
                                refreshPhieuGiamGia();
                            }
                            else
                            {
                                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Phiếu Giảm Giá để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gv_thongTinUuDai_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_thongTinUuDai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_thongTinUuDai.SelectedRows[0];

                txt_maGiamGia.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_tenUuDai.Text = selectedRow.Cells[1].Value.ToString().Trim();
                num_phanTramGiam.Value = int.Parse(selectedRow.Cells[2].Value.ToString().Trim());
                dtp_ngayBatDau.Value = DateTime.Parse(selectedRow.Cells[3].Value.ToString().Trim());
                dtp_ngayKetThuc.Value = DateTime.Parse(selectedRow.Cells[4].Value.ToString().Trim());
            }
        }

    }
}
