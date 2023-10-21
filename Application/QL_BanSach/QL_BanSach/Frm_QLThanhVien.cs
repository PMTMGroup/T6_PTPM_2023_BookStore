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
    public partial class Frm_QLThanhVien : Form
    {
        private BLL_ThanhVien thanhvienBLL = new BLL_ThanhVien();
        private BLL_LoaiThanhVien loaithanhvienBLL = new BLL_LoaiThanhVien();
        public Frm_QLThanhVien()
        {
            InitializeComponent();
            loadDGVLoaiThanhVien();
            loadDGVThanhVien();
        }
        public void loadDGVLoaiThanhVien()
        {
            List<DTO_LoaiThanhVien> ltvs = loaithanhvienBLL.GetAllLoaiThanhVien();
            dgv_loaiTV.DataSource = ltvs;
        }
        public void loadDGVThanhVien()
        {
            List<DTO_ThanhVien> tvs = thanhvienBLL.GetAllThanhVien();
            dgv_thanhvien.DataSource = tvs;
            
        }
        public void refreshLoaiThanhVien()
        {
            txt_TTTV_maThanhVien.Text = "";
            txt_TTTV_tenThanhVien.Text = "";
            txt_TTTV_sdt.Text = "";
            txt_TTTV_soTienDaMua.Text = "";
            txt_TTTV_matKhau.Text = "";
        }
        private void btn_TTTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_QLLTV_maLoaiThanhVien.Text = "";
            txt_QLLTV_tenLoaiThanhVien.Text = "";
            txt_QLLTV_soTienCanDat.Text = "";
            txt_QLLTV_phanTramGiamGia.Text = "";
        }

        private void btn_TCTTTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TCTTTV_sdt.Text = "";
        }

        private void btn_QLLTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_QLLTV_maLoaiThanhVien.Text = "";
            txt_QLLTV_tenLoaiThanhVien.Text = "";
            txt_QLLTV_soTienCanDat.Text = "";
            txt_QLLTV_phanTramGiamGia.Text = "";
        }

        private void btn_QLLTV_them_Click(object sender, EventArgs e)
        {
            if (txt_QLLTV_maLoaiThanhVien.Text.Trim() == string.Empty || txt_QLLTV_tenLoaiThanhVien.Text.Trim() == string.Empty
                || txt_QLLTV_phanTramGiamGia.Text.Trim() == string.Empty || txt_QLLTV_soTienCanDat.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maLoaiTV = txt_QLLTV_maLoaiThanhVien.Text.Trim();
                string tenLoaiTV = txt_QLLTV_tenLoaiThanhVien.Text.Trim();
                int tienCanDat = int.Parse(txt_QLLTV_soTienCanDat.Text.Trim());

                int phanTramGiamGia = int.Parse(txt_QLLTV_phanTramGiamGia.Text.Trim()); 

                if (tienCanDat < 0)
                {
                    MessageBox.Show("Số tiền cần đạt không thể âm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (loaithanhvienBLL.CheckPrimaryKey(maLoaiTV))
                {
                    MessageBox.Show("Mã loại thành viên đã tồn tại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin loại thành viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (loaithanhvienBLL.InsertLoaiThanhVien(maLoaiTV, tenLoaiTV, tienCanDat, phanTramGiamGia))
                        {
                            MessageBox.Show("Thêm loại thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loadDGVLoaiThanhVien();
                            refreshLoaiThanhVien();
                            
                        }
                        else
                            MessageBox.Show("An error occurred, please try again later!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void btn_TTTV_them_Click(object sender, EventArgs e)
        {
        //    if (txt_MaTV.Text.Trim() == string.Empty || txt_TenTV.Text.Trim() == string.Empty
        //|| txt_SDT.Text.Trim() == string.Empty || txt_MatKhau.Text.Trim() == string.Empty
        //|| cb_MaLoaiTV.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        string maTV = txt_MaTV.Text.Trim();
        //        string tenTV = txt_TenTV.Text.Trim();
        //        string sdt = txt_SDT.Text.Trim();
        //        string matKhau = txt_MatKhau.Text.Trim();
        //        string maLoaiTV = cb_MaLoaiTV.SelectedItem.ToString(); // Lấy mã loại thành viên từ ComboBox

        //        // Kiểm tra xem mã thành viên đã tồn tại chưa (cần viết hàm CheckPrimaryKey)
        //        if (thanhvienBLL.CheckPrimaryKey(maTV))
        //        {
        //            MessageBox.Show("Mã thành viên đã tồn tại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin thành viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        //            if (dialog == DialogResult.Yes)
        //            {
        //                if (thanhvienBLL.InsertThanhVien(maTV, tenTV, sdt, matKhau, maLoaiTV))
        //                {
        //                    MessageBox.Show("Thêm thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                    loadDGVThanhVien();
        //                    refreshThanhVien();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }
        //            }
        //        }
        //    }
        }

        private void dgv_loaiTV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_loaiTV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_loaiTV.SelectedRows[0];

                txt_QLLTV_maLoaiThanhVien.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_QLLTV_tenLoaiThanhVien.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txt_QLLTV_phanTramGiamGia.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txt_QLLTV_soTienCanDat.Text = selectedRow.Cells[3].Value.ToString().Trim();
            }
        }

        private void txt_QLLTV_soTienCanDat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_QLLTV_soTienCanDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }

        private void txt_QLLTV_phanTramGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }

        private void btn_QLLTV_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_loaiTV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_loaiTV.SelectedRows[0];

                // Lấy mã loại thành viên từ dòng được chọn
                string maLoaiTV = selectedRow.Cells["MaLoaiTV"].Value.ToString();

                if (loaithanhvienBLL.CheckForeignKey(maLoaiTV))
                {
                    MessageBox.Show("Loại Thành Viên đang được sử dụng ở nơi khác, không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận xóa thông tin Loại Thành Viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (loaithanhvienBLL.DeleteLoaiThanhVien(maLoaiTV))
                        {
                            MessageBox.Show("Xóa Loại Thành Viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVLoaiThanhVien();
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
                MessageBox.Show("Vui lòng chọn Loại Thành Viên để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_QLLTV_luu_Click(object sender, EventArgs e)
        {
            if (dgv_loaiTV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_loaiTV.SelectedRows[0];

                // Lấy mã loại thành viên từ dòng được chọn
                string maLoaiTV = selectedRow.Cells["MaLoaiTV"].Value.ToString();

                if (txt_QLLTV_maLoaiThanhVien.Text.Trim() == string.Empty || txt_QLLTV_tenLoaiThanhVien.Text.Trim() == string.Empty
                || txt_QLLTV_phanTramGiamGia.Text.Trim() == string.Empty || txt_QLLTV_soTienCanDat.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Loại Thành Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string maloaiTV = txt_QLLTV_maLoaiThanhVien.Text.Trim();
                    string tenLoaiTV = txt_QLLTV_tenLoaiThanhVien.Text.Trim();
                    int tienCanDat = int.Parse(txt_QLLTV_soTienCanDat.Text.Trim());
                    int phanTramGiamGia = int.Parse(txt_QLLTV_phanTramGiamGia.Text.Trim()); 

                    if (tienCanDat < 0)
                    {
                        MessageBox.Show("Số tiền cần đạt không thể là số âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Xác nhận sửa thông tin Loại Thành Viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dialog == DialogResult.Yes)
                        {
                            if (loaithanhvienBLL.UpdateLoaiThanhVien(maLoaiTV, tenLoaiTV, tienCanDat, phanTramGiamGia))
                            {
                                MessageBox.Show("Sửa thông tin Loại Thành Viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadDGVLoaiThanhVien();
                                refreshLoaiThanhVien();
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
                MessageBox.Show("Vui lòng chọn Loại Thành Viên để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_thanhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_thanhvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_thanhvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_thanhvien.SelectedRows[0];

                txt_TTTV_maThanhVien.Text = selectedRow.Cells["MaTV"].Value.ToString().Trim();
                txt_TTTV_tenThanhVien.Text = selectedRow.Cells["TenThanhVien"].Value.ToString().Trim();
                txt_TTTV_sdt.Text = selectedRow.Cells["SDT"].Value.ToString().Trim();
                txt_TTTV_matKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString().Trim();

                string maLoaiTV = selectedRow.Cells["MaLoaiTV"].Value.ToString().Trim();
                cbo_TTTV_loaiThanhVien.SelectedItem = maLoaiTV; // Chọn mã loại thành viên trong ComboBox
            }
        }

        private void cbo_TTTV_loaiThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void Form_Load(object sender, EventArgs e)
        {

        }

    }
}
