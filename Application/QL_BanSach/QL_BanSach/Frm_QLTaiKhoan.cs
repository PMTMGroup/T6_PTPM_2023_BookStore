using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Frm_DangNhap
{
    public partial class Frm_QLTaiKhoan : Form
    {
        BLL_TaiKhoan bllTaiKhoan = new BLL_TaiKhoan();
        public Frm_QLTaiKhoan()
        {
            InitializeComponent();
            loadDGVDSTaiKhoan();
        }

        private void btn_QLTK_lamMoi_Click(object sender, EventArgs e)
        {
            refreshFieldInput();
        }
        
        private void refreshFieldInput()
        {
            txt_QLTK_maTaiKhoan.Text = "";
            txt_QLTK_hoTen.Text = "";
            txt_QLTK_sdt.Text = "";
            txt_QLTK_tenDangNhap.Text = "";
            txt_QLTK_matKhau.Text = "";
        }

        private void loadDGVDSTaiKhoan()
        {
            List<DTO_TaiKhoan> dsTaiKhoan = bllTaiKhoan.GetAllTaiKhoan();
            gv_QLTK.DataSource = dsTaiKhoan;
        }

        private void gv_QLTK_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_QLTK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_QLTK.SelectedRows[0];
                txt_QLTK_maTaiKhoan.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_QLTK_tenDangNhap.Text = selectedRow.Cells[1].Value.ToString().Trim();
                txt_QLTK_matKhau.Text = selectedRow.Cells[2].Value.ToString().Trim();
                txt_QLTK_hoTen.Text = selectedRow.Cells[3].Value.ToString().Trim();
                txt_QLTK_sdt.Text = selectedRow.Cells[4].Value.ToString().Trim();
                cbo_QLTK_quyen.Text = bllTaiKhoan.getQuyenfromMaQuyen(selectedRow.Cells[5].Value.ToString().Trim()).TenQuyen;
                cbo_QLTK_trangThai.Text = (selectedRow.Cells[6].Value.ToString() == "False")?"Hoạt động":"Bị khóa";
            }
        }

        private void btn_QLTK_them_Click(object sender, EventArgs e)
        {
            if (!checkFullInfo())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Tài khoản mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maTK = txt_QLTK_maTaiKhoan.Text.Trim();

                if (bllTaiKhoan.checkPrimaryKey(maTK))
                    MessageBox.Show("Mã tài khoản đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin Tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        string maQuyen = (cbo_QLTK_quyen.SelectedItem.ToString() == "Quyền User") ? "user":"admin";
                        int biKhoa = (cbo_QLTK_trangThai.SelectedItem.ToString() == "Hoạt động") ? 0: 1;

                        DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan(maTK, txt_QLTK_tenDangNhap.Text.Trim(), txt_QLTK_matKhau.Text.Trim(), txt_QLTK_hoTen.Text.Trim(), txt_QLTK_sdt.Text.Trim(), maQuyen, biKhoa);
                        if (bllTaiKhoan.insertTaiKhoan(taiKhoan))
                        {
                            MessageBox.Show("Thêm Tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVDSTaiKhoan();
                            refreshFieldInput();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_QLTK_luu_Click(object sender, EventArgs e)
        {
            if (gv_QLTK.SelectedRows.Count > 0)
            {
                if (!checkFullInfo())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataGridViewRow selectedRow = gv_QLTK.SelectedRows[0];

                    DialogResult dialog = MessageBox.Show("Xác nhận sửa thông tin Tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        string maQuyen = (cbo_QLTK_quyen.SelectedItem.ToString() == "Quyền User") ? "user" : "admin";
                        int biKhoa = (cbo_QLTK_trangThai.SelectedItem.ToString() == "Hoạt động") ? 0 : 1;

                        DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan(selectedRow.Cells[0].Value.ToString().Trim(), txt_QLTK_tenDangNhap.Text.Trim(), txt_QLTK_matKhau.Text.Trim(), txt_QLTK_hoTen.Text.Trim(), txt_QLTK_sdt.Text.Trim(), maQuyen, biKhoa);

                        if (bllTaiKhoan.updateTaiKhoan(taiKhoan))
                        {
                            MessageBox.Show("Sửa thông tin Tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVDSTaiKhoan();
                            refreshFieldInput();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn Tài khoản để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_QLTK_xoa_Click(object sender, EventArgs e)
        {
            if (gv_QLTK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_QLTK.SelectedRows[0];

                if (bllTaiKhoan.checkForeignKey(selectedRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Tài khoản đang giữ khóa ngoại, không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận xóa thông tin Tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (bllTaiKhoan.deleteTaiKhoan(selectedRow.Cells[0].Value.ToString().Trim()))
                        {
                            MessageBox.Show("Xóa Tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVDSTaiKhoan();
                            refreshFieldInput();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn Tài khoản để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool checkFullInfo()
        {
            if (txt_QLTK_maTaiKhoan.Text.Trim() == string.Empty || txt_QLTK_tenDangNhap.Text.Trim() == string.Empty || txt_QLTK_matKhau.Text.Trim() == string.Empty || txt_QLTK_hoTen.Text.Trim() == string.Empty
                || txt_QLTK_sdt.Text.Trim() == string.Empty || cbo_QLTK_trangThai.SelectedIndex < 0 || cbo_QLTK_quyen.SelectedIndex < 0)
                return false;
            return true;
        }
    }
}
