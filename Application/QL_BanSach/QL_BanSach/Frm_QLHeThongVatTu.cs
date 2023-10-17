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
    public partial class Frm_QLHeThongVatTu : Form
    {
        private BLL_Tang tangBLL = new BLL_Tang();
        public Frm_QLHeThongVatTu()
        {
            InitializeComponent();
            loadDGVTang();
        }

        public void loadDGVTang()
        {
            List<DTO_Tang> tangs = tangBLL.GetAllTangs();
            dgv_tang.DataSource = tangs;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TTT_lamMoi_Click(object sender, EventArgs e)
        {
            refreshTang();
        }

        private void refreshTang()
        {
            txt_maTang.Text = "";
            txt_tenTang.Text = "";
        }

        private void btn_TTNXB_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maNXB.Text = "";
            txt_tenNXB.Text = "";
        }

        private void btn_TTTL_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maTheLoai.Text = "";
            txt_tenTheLoai.Text = "";

        }

        private void btn_TTKD_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maKe.Text = "";
            txt_tenKe.Text = "";
        }

        private void btn_TTT_them_Click(object sender, EventArgs e)
        {
            if (txt_tenTang.Text.Trim() == string.Empty || txt_maTang.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Tầng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maTang =  txt_maTang.Text.Trim();
                string tenTang = txt_tenTang.Text.Trim();

                if(tangBLL.checkPrimaryKey(maTang))
                    MessageBox.Show("Mã tầng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận thêm thông tin Tầng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialog == DialogResult.Yes)
                    {
                        if (tangBLL.insertTang(maTang, tenTang))
                        {
                            MessageBox.Show("Thêm Tầng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVTang();
                            refreshTang();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                
            }
        }

        private void btn_TTT_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_tang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_tang.SelectedRows[0];

                if(tangBLL.checkForeignKey(selectedRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Tầng đang giữ khóa ngoại, không thể xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Xác nhận xóa thông tin Tầng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if(dialog == DialogResult.Yes)
                    {
                        if(tangBLL.deleteTang(selectedRow.Cells[0].Value.ToString().Trim()))
                        {
                            MessageBox.Show("Xóa Tầng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDGVTang();
                            refreshTang();
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                
            }
            else
                MessageBox.Show("Vui lòng chọn Tầng để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgv_tang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_tang.SelectedRows[0];

                txt_maTang.Text = selectedRow.Cells[0].Value.ToString().Trim();
                txt_tenTang.Text = selectedRow.Cells[1].Value.ToString().Trim();
            }
        }

        private void btn_TTT_luu_Click(object sender, EventArgs e)
        {
            if (dgv_tang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_tang.SelectedRows[0];

                DialogResult dialog = MessageBox.Show("Xác nhận sửa thông tin Tầng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes)
                {
                    if (tangBLL.updateTang(selectedRow.Cells[0].Value.ToString().Trim(), txt_tenTang.Text.Trim()))
                    {
                        MessageBox.Show("Sửa thông tin Tầng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDGVTang();
                        refreshTang();
                    }
                    else
                        MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn Tầng để thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
