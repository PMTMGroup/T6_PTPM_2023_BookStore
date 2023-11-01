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
        private string maTKDN;
        public Frm_QLThanhVien(string maTKDN)
        {
            InitializeComponent();
            this.maTKDN = maTKDN;

            if(thanhvienBLL.getMaQuyenfromMaTaiKhoan(this.maTKDN).Trim() == "user")
                grp_loaiTV.Enabled = false;
            else
                loadDGVLoaiThanhVien();
            loadDGVThanhVien();
            loadCombobox();
        }

        public Frm_QLThanhVien()
        {
            InitializeComponent();
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
        
        public void refreshThanhVien()
        {
            txt_TTTV_maThanhVien.Text = "";
            txt_TTTV_tenThanhVien.Text = "";
            txt_TTTV_sdt.Text = "";
            txt_TTTV_soTienDaMua.Text = "";
            txt_TTTV_matKhau.Text = "";
        }
        public void refreshLoaiThanhVien()
        {
            txt_QLLTV_maLoaiThanhVien.Text = "";
            txt_QLLTV_tenLoaiThanhVien.Text = "";
            txt_QLLTV_soTienCanDat.Text = "";
            num_phantramgg.Value = 1;
        }
        private void btn_TTTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TTTV_maThanhVien.Text = "";
            txt_TTTV_tenThanhVien.Text = "";
            txt_TTTV_sdt.Text = "";
            txt_TTTV_soTienDaMua.Text = "";
            txt_TTTV_matKhau.Text = "";
            cbo_TTTV_loaiThanhVien.Text = "--- Chọn ---";
            cbo_TTTV_loaiThanhVien.SelectedIndex = -1;
        }

        private void btn_TCTTTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TCTTTV_sdt.Text = "";
            gv_TCTTTV_ketQuaTraCuu.DataSource = null;
        }

        private void btn_QLLTV_lamMoi_Click(object sender, EventArgs e)
        {
            txt_QLLTV_maLoaiThanhVien.Text = "";
            txt_QLLTV_tenLoaiThanhVien.Text = "";
            txt_QLLTV_soTienCanDat.Text = "";
            num_phantramgg.Value = 1;
        }

        private void btn_QLLTV_them_Click(object sender, EventArgs e)
        {
            if (txt_QLLTV_maLoaiThanhVien.Text.Trim() == string.Empty || txt_QLLTV_tenLoaiThanhVien.Text.Trim() == string.Empty
                || txt_QLLTV_soTienCanDat.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maLoaiTV = txt_QLLTV_maLoaiThanhVien.Text.Trim();
                string tenLoaiTV = txt_QLLTV_tenLoaiThanhVien.Text.Trim();
                int tienCanDat = int.Parse(txt_QLLTV_soTienCanDat.Text.Trim());

                int phanTramGiamGia = int.Parse(num_phantramgg.Value.ToString().Trim());

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
                            MessageBox.Show("Thêm loại thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loadDGVLoaiThanhVien();
                            refreshLoaiThanhVien();

                        }
                        else
                            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void btn_TTTV_them_Click(object sender, EventArgs e)
        {
            if (txt_TTTV_tenThanhVien.Text.Trim() == string.Empty|| txt_TTTV_sdt.Text.Trim() == string.Empty || txt_TTTV_matKhau.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string tenTV = txt_TTTV_tenThanhVien.Text.Trim();
                string sdt = txt_TTTV_sdt.Text.Trim();
                string matKhau = txt_TTTV_matKhau.Text.Trim();

                int tiendamua = 0;

                if (thanhvienBLL.CheckExistPhoneNumber(sdt))
                    MessageBox.Show("Số điện thoại đã được đăng kí trước đó!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //Mã thành viên phát sinh tự động
                    DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin thành viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (thanhvienBLL.InsertThanhVien(tenTV, sdt, matKhau, tiendamua, "Bronze"))
                        {
                            MessageBox.Show("Thêm thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVThanhVien();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void dgv_loaiTV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_loaiTV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_loaiTV.SelectedRows[0];

                txt_QLLTV_maLoaiThanhVien.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_QLLTV_tenLoaiThanhVien.Text = selectedRow.Cells[1].Value.ToString().Trim();
                num_phantramgg.Value = Int32.Parse( selectedRow.Cells[3].Value.ToString().Trim());
                txt_QLLTV_soTienCanDat.Text = selectedRow.Cells[2].Value.ToString().Trim();
            }
        }

        private void txt_QLLTV_soTienCanDat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_QLLTV_soTienCanDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
                || txt_QLLTV_soTienCanDat.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Loại Thành Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string maloaiTV = selectedRow.Cells["MaLoaiTV"].Value.ToString();
                    string tenLoaiTV = txt_QLLTV_tenLoaiThanhVien.Text.Trim();
                    int tienCanDat = int.Parse(txt_QLLTV_soTienCanDat.Text.Trim());
                    int phanTramGiamGia = int.Parse(num_phantramgg.Value.ToString());

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
                cbo_TTTV_loaiThanhVien.Text = thanhvienBLL.GetLoaiThanhVienFromTenLoaiTV(maLoaiTV).TenLoaiTV;
                txt_TTTV_soTienDaMua.Text = selectedRow.Cells["TienDaMua"].Value.ToString().Trim();
            }
        }

        private void cbo_TTTV_loaiThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadCombobox()
        {
            Dictionary<string, string> loaiThanhVienDictionary = new Dictionary<string, string>();

            List<DTO_LoaiThanhVien> _lstLTV = loaithanhvienBLL.GetAllLoaiThanhVien();

            foreach (DTO_LoaiThanhVien ltv in _lstLTV)
            {
                loaiThanhVienDictionary.Add(ltv.MaLoaiTV, ltv.TenLoaiTV);
            }

            cbo_TTTV_loaiThanhVien.DataSource = new BindingSource(loaiThanhVienDictionary, null);
            cbo_TTTV_loaiThanhVien.DisplayMember = "Value";
            cbo_TTTV_loaiThanhVien.ValueMember = "Key";
        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void txt_TTTV_maThanhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TTTV_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_thanhvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_thanhvien.SelectedRows[0];

                // Lấy mã thành viên từ dòng được chọn
                int maTV = int.Parse(selectedRow.Cells["MaTV"].Value.ToString());

                if (thanhvienBLL.CheckForeignKey(maTV))
                {
                    MessageBox.Show("Thành Viên đang được sử dụng ở nơi khác, không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận xóa thông tin Thành Viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (thanhvienBLL.DeleteThanhVien(maTV))
                        {
                            MessageBox.Show("Xóa Thành Viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVThanhVien();
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
                MessageBox.Show("Vui lòng chọn Thành Viên để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TTTV_luu_Click(object sender, EventArgs e)
        {
            if (dgv_thanhvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_thanhvien.SelectedRows[0];

                // Lấy mã thành viên từ dòng được chọn
                int maTV = int.Parse(selectedRow.Cells["MaTV"].Value.ToString().Trim());
                string sdtSelected = selectedRow.Cells["SDT"].Value.ToString().Trim();

                // Kiểm tra thông tin ThanhVien đã được nhập đầy đủ
                if (string.IsNullOrEmpty(txt_TTTV_tenThanhVien.Text) || string.IsNullOrEmpty(txt_TTTV_sdt.Text)
                    || string.IsNullOrEmpty(txt_TTTV_matKhau.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Thành Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string tenTV = txt_TTTV_tenThanhVien.Text.Trim();
                    string sdt = txt_TTTV_sdt.Text.Trim();
                    string matKhau = txt_TTTV_matKhau.Text.Trim();

                    if (matKhau.Length < 6)
                    {
                        MessageBox.Show("Mật khẩu cần có ít nhất 6 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txt_TTTV_sdt.Text.Trim() != sdtSelected)
                        {
                            if (thanhvienBLL.CheckExistPhoneNumber(txt_TTTV_sdt.Text.Trim()))
                                MessageBox.Show("Số điện thoại đã được đăng kí trước đó!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                            {
                                DialogResult dialog = MessageBox.Show("Xác nhận lưu thông tin Thành Viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                                if (dialog == DialogResult.Yes)
                                {
                                    if (thanhvienBLL.UpdateThanhVien(maTV,tenTV, txt_TTTV_sdt.Text.Trim(), matKhau))
                                    {
                                        MessageBox.Show("Lưu Thành Viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        loadDGVThanhVien();
                                        refreshThanhVien();
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
                            DialogResult dialog = MessageBox.Show("Xác nhận lưu thông tin Thành Viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialog == DialogResult.Yes)
                            {
                                if (thanhvienBLL.UpdateThanhVien(maTV,tenTV, sdtSelected, matKhau))
                                {
                                    MessageBox.Show("Lưu Thành Viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadDGVThanhVien();
                                    refreshThanhVien();
                                }
                                else
                                {
                                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Thành Viên để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_TTTV_soTienDaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }

        private void btn_TCTTTV_traCuu_Click(object sender, EventArgs e)
        {
            string sDT = txt_TCTTTV_sdt.Text.Trim();
            if (sDT.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền thông tin SĐT thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO_ThanhVien thanhVien = thanhvienBLL.GetThanhVienFromSDT(sDT);
                if (thanhVien == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin của Thành Viên từ SĐT!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    gv_TCTTTV_ketQuaTraCuu.DataSource = new List<DTO_ThanhVien> { thanhVien };

                }
            }
        }

        private void txt_TCTTTV_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_TTTV_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}


